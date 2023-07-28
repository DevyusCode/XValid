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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XValid.Test;
[TestFixture]
public class ISBNValidatorTests
{
	[TestCase("0306406152", ExpectedResult = true)] // Valid ISBN-10
	[TestCase("0-306-40615-2", ExpectedResult = true)] // Valid ISBN-10 with separators
	[TestCase("0451450523", ExpectedResult = true)] // Valid ISBN-10 with 'X' as the last character
	[TestCase("9780470059029", ExpectedResult = true)] // Valid ISBN-13
	[TestCase("978-0-13-149505-0", ExpectedResult = true)] // Valid ISBN-13 with separators
	[TestCase("9780064404990", ExpectedResult = true)] // Valid ISBN-13 with 'X' as the last character
	[TestCase("013149505", ExpectedResult = false)] // Invalid ISBN (too short)
	[TestCase("97801314950500", ExpectedResult = false)] // Invalid ISBN (too long)
	[TestCase("1234567890", ExpectedResult = false)] // Invalid ISBN-10 (fails ISBN-10 checksum)
	[TestCase("9780470059021", ExpectedResult = false)] // Invalid ISBN-13 (fails ISBN-13 checksum)
	[TestCase("invalid-isbn", ExpectedResult = false)] // Invalid ISBN (contains non-numeric characters)
	[TestCase("", ExpectedResult = false)] // Empty string
	[TestCase(" ", ExpectedResult = false)] // Space
	[TestCase(null, ExpectedResult = false)] // Null string
	public bool TestIsValidISBN(string isbn)
	{
		return ISBNValidator.IsValidISBN(isbn);
	}

	[TestCase("0306406152", ExpectedResult = true)] // Valid ISBN-10
	[TestCase("0-306-40615-2", ExpectedResult = true)] // Valid ISBN-10 with separators
	[TestCase("0451450523", ExpectedResult = true)] // Valid ISBN-10 with 'X' as the last character
	[TestCase("013149505", ExpectedResult = false)] // Invalid ISBN (too short)
	[TestCase("9780470059021", ExpectedResult = false)] // Invalid ISBN (fails ISBN-10 checksum)
	[TestCase("invalid-isbn", ExpectedResult = false)] // Invalid ISBN (contains non-numeric characters)
	[TestCase("", ExpectedResult = false)] // Empty string
	[TestCase(" ", ExpectedResult = false)] // Space
	[TestCase(null, ExpectedResult = false)] // Null string
	public bool TestIsValidISBN10(string isbn)
	{
		return ISBNValidator.IsValidISBN10(isbn);
	}

	[TestCase("9780470059029", ExpectedResult = true)] // Valid ISBN-13
	[TestCase("978-0-13-149505-0", ExpectedResult = true)] // Valid ISBN-13 with separators
	[TestCase("9780064404990", ExpectedResult = true)] // Valid ISBN-13 with 'X' as the last character
	[TestCase("97801314950500", ExpectedResult = false)] // Invalid ISBN (too long)
	[TestCase("9780470059021", ExpectedResult = false)] // Invalid ISBN (fails ISBN-13 checksum)
	[TestCase("invalid-isbn", ExpectedResult = false)] // Invalid ISBN (contains non-numeric characters)
	[TestCase("", ExpectedResult = false)] // Empty string
	[TestCase(" ", ExpectedResult = false)] // Space
	[TestCase(null, ExpectedResult = false)] // Null string
	public bool TestIsValidISBN13(string isbn)
	{
		return ISBNValidator.IsValidISBN13(isbn);
	}
}