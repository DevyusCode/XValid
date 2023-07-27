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
public static class IBANValidator
{
	public static bool IsValidIBAN(string iban)
	{
		if (string.IsNullOrWhiteSpace(iban))
			return false;

		// Remove spaces and convert to uppercase
		iban = iban.Replace(" ", "").ToUpper();

		// Check if the IBAN has the correct length for its country code
		if (!IsValidCountryCode(iban))
			return false;

		// Check if the IBAN contains only alphanumeric characters
		if (!Regex.IsMatch(iban, @"^[A-Z0-9]+$"))
			return false;

		// Move the first four characters to the end of the string
		iban = string.Concat(iban.AsSpan()[4..], iban.AsSpan(0, 4));

		// Replace letters with corresponding numbers using the ISO 13616 conversion
		string ibanNumeric = "";
		foreach (char c in iban)
		{
			if (char.IsLetter(c))
			{
				int value = c - 'A' + 10;
				ibanNumeric += value.ToString();
			}
			else
			{
				ibanNumeric += c;
			}
		}

		// Calculate the modulo of the numeric IBAN
		int remainder = 0;
		for (int i = 0; i < ibanNumeric.Length; i++)
		{
			int digit = int.Parse(ibanNumeric[i].ToString());
			remainder = (remainder * 10 + digit) % 97;
		}

		return remainder == 1;
	}

	public static bool IsValidCountryCode(string iban)
	{
		if (iban.Length < 2)
			return false;

		string countryCode = iban.Substring(0, 2);

		// Implement a list of valid country codes based on ISO 3166-1 alpha-2 standard
		string[] validCountryCodes = new string[]
		{
			"AL", "AD", "AT", "AZ", "BH", "BY", "BE", "BA", "BR", "BG",
			"CR", "HR", "CY", "CZ", "DK", "DO", "TL", "EE", "FO", "FI",
			"FR", "GE", "DE", "GI", "GR", "GL", "GT", "HU", "IS", "IQ",
			"IE", "IL", "IT", "JO", "KZ", "XK", "KW", "LV", "LB", "LI",
			"LT", "LU", "MT", "MR", "MU", "MC", "MD", "ME", "NL", "MK",
			"NO", "PK", "PS", "PL", "PT", "QA", "RO", "LC", "SM", "ST",
			"SA", "RS", "SC", "SK", "SI", "ES", "SE", "CH", "TN", "TR",
			"UA", "AE", "GB", "VA", "VG"
		};

		return Array.Exists(validCountryCodes, code => code == countryCode);
	}
}
