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
/// Represents a domain name validator that checks if a domain name is valid and well-formed according to the DNS rules.
/// </summary>
public static class DomainNameValidator
{
	/// <summary>
	/// Validates whether the given domain name is valid and well-formed according to the DNS rules.
	/// </summary>
	/// <param name="domainName">The domain name to validate.</param>
	/// <returns><c>true</c> if the domain name is valid and well-formed; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// <para>The domain name must not be null, empty, or contain only whitespace characters.</para>
	/// <para>The domain name must not exceed 255 characters in overall length.</para>
	/// <para>The domain name may contain alphanumeric characters, dots, and hyphens.</para>
	/// <para>The domain name must start and end with alphanumeric characters.</para>
	/// <para>The domain name must not contain two consecutive dots (..).</para>
	/// <para>The domain name must not start or end with a dot (.).</para>
	/// <para>The domain name components (labels) must not exceed 63 characters in length.</para>
	/// </remarks>
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

		if (domainName.StartsWith("-") || domainName.EndsWith("-") || domainName.Split(".")[^2].EndsWith("-")) return false;

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
