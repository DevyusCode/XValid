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

namespace XValid;
public static class CreditCardValidator
{
	public static bool IsValidCreditCardNumber(string creditCardNumber)
	{
		// Remove any spaces or dashes from the credit card number
		creditCardNumber = creditCardNumber.Replace(" ", "").Replace("-", "");

		// Check if the credit card number is numeric and not empty
		if (!IsNumeric(creditCardNumber) || string.IsNullOrWhiteSpace(creditCardNumber))
			return false;

		// Check if the credit card number passes the Luhn algorithm
		if (!PassesLuhnAlgorithm(creditCardNumber))
			return false;

		// Check if the credit card number matches a supported type
		if (!IsValidCardType(creditCardNumber))
			return false;

		return true;
	}

	private static bool IsNumeric(string value) => long.TryParse(value, out _);
	private static bool PassesLuhnAlgorithm(string creditCardNumber)
	{
		int sum = 0;
		bool isAlternate = false;

		// Start from the rightmost digit and work towards the left
		for (int i = creditCardNumber.Length - 1; i >= 0; i--)
		{
			int digit = int.Parse(creditCardNumber[i].ToString());

			if (isAlternate)
			{
				digit *= 2;
				if (digit > 9)
					digit -= 9;
			}

			sum += digit;
			isAlternate = !isAlternate;
		}

		return (sum % 10) == 0;
	}

	private static bool IsValidCardType(string creditCardNumber)
	{
		// Check for Visa
		if (creditCardNumber.StartsWith("4") && (creditCardNumber.Length == 13 || creditCardNumber.Length == 16))
			return true;

		// Check for MasterCard
		if (creditCardNumber.StartsWith("5") && creditCardNumber.Length == 16 && IsNumeric(creditCardNumber))
			return true;

		// Check for American Express (Amex)
		if (creditCardNumber.StartsWith("3") && (creditCardNumber.Length == 15) && IsNumeric(creditCardNumber))
			return true;

		// Check for Discover
		if ((creditCardNumber.StartsWith("6011") || creditCardNumber.StartsWith("65")) && (creditCardNumber.Length == 16) && IsNumeric(creditCardNumber))
			return true;

		// Check for Diners Club
		if ((creditCardNumber.StartsWith("300") || creditCardNumber.StartsWith("301") || creditCardNumber.StartsWith("302") ||
			creditCardNumber.StartsWith("303") || creditCardNumber.StartsWith("304") || creditCardNumber.StartsWith("305") ||
			creditCardNumber.StartsWith("36") || creditCardNumber.StartsWith("38")) && (creditCardNumber.Length == 14) && IsNumeric(creditCardNumber))
			return true;

		return false;
	}
}
