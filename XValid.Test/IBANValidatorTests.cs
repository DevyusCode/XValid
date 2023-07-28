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
public class IBANValidatorTests
{
	[TestCase("GB82WEST12345698765432", ExpectedResult = true)]
	[TestCase("GB82WEST 1234 5698 7654 32", ExpectedResult = true)] // With spaces
	[TestCase("DE89 3704 0044 0532 0130 00", ExpectedResult = true)]
	[TestCase("FR76 3000 6000 0112 3456 7890 189", ExpectedResult = true)]
	[TestCase("ES91 2100 0418 4502 0005 1332", ExpectedResult = true)]
	[TestCase("IT60 X054 2811 1010 0000 0123 456", ExpectedResult = true)]
	[TestCase("NL02 ABNA 0123 4567 89", ExpectedResult = true)]
	[TestCase("CH56 0483 5012 3456 7800 9", ExpectedResult = true)]
	[TestCase("AU91 1234 5678 9012 3456 789", ExpectedResult = false)]
	[TestCase("US42 1234 5678 1234 5678 1234 5678 12", ExpectedResult = false)]
	[TestCase("AL47 2121 1009 0000 0002 3569 8741", ExpectedResult = true)]
	[TestCase("INVALID", ExpectedResult = false)] // Invalid IBAN format
	[TestCase("GB82WEST123456987654321", ExpectedResult = false)] // Invalid length
	[TestCase("GB82WEST12345698765431", ExpectedResult = false)] // Invalid checksum
	[TestCase("GB82 1234 5698 7654 32", ExpectedResult = false)]
	[TestCase("GB82WEST123456987654321", ExpectedResult = false)]
	[TestCase("NL02 1234 5678 89", ExpectedResult = false)]
	[TestCase("NL02ABNA0123456789", ExpectedResult = true)]
	[TestCase("NL 02 ABNA 0123 4567 89", ExpectedResult = true)]
	[TestCase("", ExpectedResult = false)] // Empty string
	[TestCase(" ", ExpectedResult = false)] // Space
	[TestCase(null, ExpectedResult = false)] // Null string
	public bool TestIsValidIBAN(string iban)
	{
		return IBANValidator.IsValidIBAN(iban);
	}

	[TestCase("GB82WEST12345698765432", ExpectedResult = true)]
	[TestCase("DE89 3704 0044 0532 0130 00", ExpectedResult = true)]
	[TestCase("FR76 3000 6000 0112 3456 7890 189", ExpectedResult = true)]
	[TestCase("ES91 2100 0418 4502 0005 1332", ExpectedResult = true)]
	[TestCase("IT60 X054 2811 1010 0000 0123 456", ExpectedResult = true)]
	[TestCase("NL02 ABNA 0123 4567 89", ExpectedResult = true)]
	[TestCase("CH56 0483 5012 3456 7800 9", ExpectedResult = true)]
	[TestCase("AU91 1234 5678 9012 3456 789", ExpectedResult = false)]
	[TestCase("US42 1234 5678 1234 5678 1234 5678 12", ExpectedResult = false)]
	[TestCase("AL47 2121 1009 0000 0002 3569 8741", ExpectedResult = true)]
	[TestCase("INVALID", ExpectedResult = false)] // Invalid country code
	[TestCase("GB82 1234 5698 7654 32", ExpectedResult = true)] 
	[TestCase("GB82WEST123456987654321", ExpectedResult = true)] 
	[TestCase("NL02 1234 5678 89", ExpectedResult = true)]
	[TestCase("NL02ABNA0123456789", ExpectedResult = true)]
	[TestCase("NL 02 ABNA 0123 4567 89", ExpectedResult = true)]
	[TestCase("", ExpectedResult = false)] // Empty string
	[TestCase(" ", ExpectedResult = false)] // Space
	public bool TestIsValidCountryCode(string iban)
	{
		return IBANValidator.IsValidCountryCode(iban);
	}
}