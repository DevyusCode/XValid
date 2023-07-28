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
public class EmailValidatorTests
{
	[TestCase("john.doe@example.com", ExpectedResult = true)]
	[TestCase("user123@example.co.uk", ExpectedResult = true)]
	[TestCase("user@subdomain.example.com", ExpectedResult = true)]
	[TestCase("user@domain.co", ExpectedResult = true)]
	[TestCase("user@domain.info", ExpectedResult = true)]
	[TestCase("user@domain.invalid", ExpectedResult = true)]
	[TestCase("user@localhost", ExpectedResult = false)]
	[TestCase("user@local", ExpectedResult = false)] // Invalid TLD
	[TestCase("user.domain.com", ExpectedResult = false)] // Missing '@'
	[TestCase("@domain.com", ExpectedResult = false)] // Missing local part
	[TestCase("user@", ExpectedResult = false)] // Missing domain
	[TestCase("user@.com", ExpectedResult = false)] // TLD starting with dot
	[TestCase("", ExpectedResult = false)] // Empty string
	[TestCase(null, ExpectedResult = false)] // Null string
	public bool TestValidateEmail(string email)
	{
		return EmailValidator.IsValidEmail(email);
	}
}