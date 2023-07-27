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
public static class ISBNValidator
{
	public static bool IsValidISBN(string isbn)
	{
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

	private static bool IsNumeric(string value) => long.TryParse(value, out _);

	public static bool IsValidISBN10(string isbn)
	{
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

	public static bool IsValidISBN13(string isbn)
	{
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
