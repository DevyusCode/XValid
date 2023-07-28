/*
MIT License

Copyright (c) Devyus

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. 
*/

namespace XValid;

/// <summary>
/// Provides methods to validate ISBNs (International Standard Book Numbers), including checking if they are valid, formatted, and follow the ISBN-10 or ISBN-13 standard.
/// </summary>
public static class ISBNValidator
{
	/// <summary>
	/// Validates whether the given ISBN is valid and follows the specified ISBN version (ISBN-10 or ISBN-13).
	/// </summary>
	/// <param name="isbn">The ISBN to validate.</param>
	/// <param name="version">The ISBN version to check (ISBN-10 or ISBN-13).</param>
	/// <returns><c>true</c> if the ISBN is valid and follows the specified version; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// <para>The ISBN must not be null, empty, or contain only whitespace characters.</para>
	/// <para>The ISBN must be correctly formatted according to the specified version (ISBN-10 or ISBN-13).</para>
	/// <para>For ISBN-10, the ISBN must consist of 10 digits (either numeric or with the last character being 'X' for the check digit).</para>
	/// <para>For ISBN-13, the ISBN must consist of 13 digits (numeric only) and follow the EAN-13 format.</para>
	/// </remarks>
	public static bool IsValidISBN(string isbn)
	{
		if (isbn is null) return false;

		// Remove any spaces or dashes from the ISBN
		isbn = isbn.Replace(" ", "").Replace("-", "");

		// Check if the ISBN is valid and formatted properly
		if (isbn.Length != 10 && isbn.Length != 13)
			return false;

		// Check if the ISBN contains only numeric digits and the last character is a digit or 'X'
		if (!IsNumeric(isbn.Substring(0, isbn.Length - 1)) || !(char.IsDigit(isbn[isbn.Length - 1]) || isbn[isbn.Length - 1] == 'X'))
			return false;

		// Check if the ISBN follows ISBN-10 or ISBN-13 standard
		if (isbn.Length == 10)
			return IsValidISBN10(isbn);
		else if (isbn.Length == 13)
			return IsValidISBN13(isbn);

		return false;
	}

	/// <summary>
	/// Checks if a given string is a numeric value.
	/// </summary>
	/// <param name="value">The string to check.</param>
	/// <returns>True if the string is a numeric value, false otherwise.</returns>
	private static bool IsNumeric(string value) => long.TryParse(value, out _);

	/// <summary>
	/// Checks if a given string is a valid ISBN-10 number.
	/// </summary>
	/// <param name="isbn">The string to check.</param>
	/// <returns>True if the string is a valid ISBN-10 number, false otherwise.</returns>
	public static bool IsValidISBN10(string isbn)
	{
		if (isbn is null || string.IsNullOrEmpty(isbn) || string.IsNullOrWhiteSpace(isbn)) return false;
		isbn = isbn.Replace(" ", "").Replace("-", "");
		if (isbn.Length != 10) return false;

		int sum = 0;
		for (int i = 0; i < 9; i++)
		{
			int digit = int.Parse(isbn[i].ToString());
			sum += (digit * (10 - i));
		}

		char lastChar = isbn[9];
		if (lastChar == 'X')
			sum += 10;
		else
			sum += int.Parse(lastChar.ToString());

		return (sum % 11) == 0;
	}

	/// <summary>
	/// Checks if a given string is a valid ISBN-13 number.
	/// </summary>
	/// <param name="isbn">The string to check.</param>
	/// <returns>True if the string is a valid ISBN-13 number, false otherwise.</returns>
	public static bool IsValidISBN13(string isbn)
	{
		if (isbn is null || string.IsNullOrEmpty(isbn) || string.IsNullOrWhiteSpace(isbn)) return false;
		isbn = isbn.Replace(" ", "").Replace("-", "");
		if (isbn.Length != 13) return false;

		int sum = 0;
		for (int i = 0; i < 12; i++)
		{
			int digit = int.Parse(isbn[i].ToString());
			sum += (i % 2 == 0) ? digit : digit * 3;
		}

		int checkDigit = int.Parse(isbn[12].ToString());
		int remainder = sum % 10;
		int checksum = (remainder == 0) ? 0 : 10 - remainder;

		return checkDigit == checksum;
	}
}
