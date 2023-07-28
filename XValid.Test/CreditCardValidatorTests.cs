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
namespace XValid.Test;
[TestFixture]
public class CreditCardValidatorTests
{
	[TestCase("4111-1111-1111-1111", ExpectedResult = true)]
	[TestCase("4111 1111 1111 1111", ExpectedResult = true)]
	[TestCase("4111-1111-1111-1112", ExpectedResult = false)]
	[TestCase("5555-5555-5555-5555", ExpectedResult = false)]
	[TestCase("6011 1111 1111 1117", ExpectedResult = true)]
	[TestCase("3000 0000 0000 04", ExpectedResult = true)]
	[TestCase("3000 0000 0000 05", ExpectedResult = false)]
	[TestCase("37000000000000", ExpectedResult = false)]
	[TestCase("37000000000001", ExpectedResult = false)]
	[TestCase("3782-822463-10005", ExpectedResult = true)]
	[TestCase("5610-5909-2811-1052", ExpectedResult = false)]
	[TestCase("3542791083283634", ExpectedResult = false)] // Invalid card type
	[TestCase("1234-5678-1234-5678", ExpectedResult = false)] // Invalid card type
	[TestCase("0000000000000000", ExpectedResult = false)] // Invalid card type
	[TestCase("411111111111112", ExpectedResult = false)] // Invalid Luhn algorithm
	public bool TestIsValidCreditCardNumber(string creditCardNumber)
	{
		return CreditCardValidator.IsValidCreditCardNumber(creditCardNumber);
	}
}
