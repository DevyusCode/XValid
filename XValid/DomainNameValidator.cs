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
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XValid;
public static class DomainNameValidator
{
	public static bool IsValid(string domainName)
	{
		if (string.IsNullOrWhiteSpace(domainName))
			return false;

		domainName = domainName.Trim();

		// Check overall length of the domain name
		if (domainName.Length > 255)
			return false;

		// Check if the domain name contains valid characters
		if (!Regex.IsMatch(domainName, @"^[a-zA-Z0-9.-]+$"))
			return false;

		// Check if the domain name starts and ends with alphanumeric characters
		if (!char.IsLetterOrDigit(domainName[0]) || !char.IsLetterOrDigit(domainName[domainName.Length - 1]))
			return false;

		// Check if the domain name doesn't contain two consecutive dots (..)
		if (domainName.Contains(".."))
			return false;

		// Check if the domain name doesn't start or end with a dot (.)
		if (domainName.StartsWith(".") || domainName.EndsWith("."))
			return false;

		// Check if the domain name components (labels) are valid in length
		string[] domainComponents = domainName.Split('.');
		foreach (string component in domainComponents)
		{
			if (component.Length > 63)
				return false;
		}

		return true;
	}
}
