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
using System.Text.RegularExpressions;

namespace XValid;

/// <summary>
/// Represents a simple email validator using regular expressions.
/// </summary>
public static class EmailValidator
{
	/// <summary>
	/// The regular expression pattern used for email validation.
	/// </summary>
	private static readonly string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

	/// <summary>
	/// Validates whether the given email address is valid according to the specified pattern.
	/// </summary>
	/// <param name="email">The email address to validate.</param>
	/// <returns><c>true</c> if the email address is valid; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// The email address must not be null, empty, or contain only whitespace characters.
	/// <para>The method uses the regular expression pattern <see cref="EmailPattern"/> to validate the email address.</para>
	/// The pattern allows email addresses with alphanumeric characters, dots, underscores, percent signs, plus signs,
	/// and hyphens in the local part. The domain part is allowed to contain alphanumeric characters, dots, and hyphens,
	/// with at least two letters at the end.
	/// </remarks>
	public static bool ValidateEmail(string email)
	{
		if (string.IsNullOrWhiteSpace(email))
			return false;

		return Regex.IsMatch(email, EmailPattern);
	}
}
