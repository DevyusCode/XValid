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
public class IPAddressValidatorTests
{
	[TestCase("192.168.0.1", IPAddressVersion.IPv4, ExpectedResult = true)]
	[TestCase("2001:0db8:85a3:0000:0000:8a2e:0370:7334", IPAddressVersion.IPv6, ExpectedResult = true)]
	[TestCase("::1", IPAddressVersion.IPv6, ExpectedResult = true)] // Shortened IPv6 format
	[TestCase("invalid-ip-address", IPAddressVersion.IPv4, ExpectedResult = false)] // Invalid format for IPv4
	[TestCase("192.168.0.256", IPAddressVersion.IPv4, ExpectedResult = false)] // Invalid value for IPv4
	[TestCase("2001:0db8:85a3:0000:0000:8a2e:0370:733G", IPAddressVersion.IPv6, ExpectedResult = false)] // Invalid format for IPv6
	[TestCase("2001:0db8:85a3:0000:0000:8a2e:0370:7334:5678", IPAddressVersion.IPv6, ExpectedResult = false)] // Invalid length for IPv6
	[TestCase("", IPAddressVersion.IPv4, ExpectedResult = false)] // Empty string
	[TestCase(" ", IPAddressVersion.IPv6, ExpectedResult = false)] // Space
	[TestCase(null, IPAddressVersion.IPv4, ExpectedResult = false)] // Null string
	public bool TestIsValidIPAddress(string ipAddress, IPAddressVersion version)
	{
		return IPAddressValidator.IsValidIPAddress(ipAddress, version);
	}
}