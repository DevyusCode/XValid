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
public class DomainNameValidatorTests
{
	[TestCase("example.com", ExpectedResult = true)]
	[TestCase("subdomain.example.com", ExpectedResult = true)]
	[TestCase("www.example.com", ExpectedResult = true)]
	[TestCase("domain-with-hyphen.com", ExpectedResult = true)]
	[TestCase("123example.com", ExpectedResult = true)]
	[TestCase("example123.com", ExpectedResult = true)]
	[TestCase("longdomainnameconsistingofsixtythreexs.com", ExpectedResult = true)]
	[TestCase("a.com", ExpectedResult = true)]
	[TestCase("abc.com", ExpectedResult = true)]
	[TestCase("a.b.c.com", ExpectedResult = true)]
	[TestCase("domain..name.com", ExpectedResult = false)]
	[TestCase(".example.com", ExpectedResult = false)]
	[TestCase("example.com.", ExpectedResult = false)]
	[TestCase("example..com", ExpectedResult = false)]
	[TestCase("example..com.", ExpectedResult = false)]
	[TestCase("a-dash-starting.com", ExpectedResult = true)]
	[TestCase("ending-with-dash-.com", ExpectedResult = false)]
	[TestCase("tooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooong.com", ExpectedResult = false)]
	[TestCase("domain name with spaces.com", ExpectedResult = false)]
	[TestCase("domain!name.com", ExpectedResult = false)]
	[TestCase("domain@name.com", ExpectedResult = false)]
	[TestCase("example*.com", ExpectedResult = false)]
	[TestCase("example com", ExpectedResult = false)]
	[TestCase("", ExpectedResult = false)]
	[TestCase(" ", ExpectedResult = false)]
	[TestCase(null, ExpectedResult = false)]
	public bool TestDomainNameIsValid(string domainName)
	{
		return DomainNameValidator.IsValid(domainName);
	}
}