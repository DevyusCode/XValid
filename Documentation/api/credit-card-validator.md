# CreditCardValidator Class

The `CreditCardValidator` class provides methods to validate credit card numbers, including numeric check, Luhn algorithm, and supported card types.

## Methods

### `IsValidCreditCardNumber`

```csharp
public static bool IsValidCreditCardNumber(string creditCardNumber)
```

The `IsValidCreditCardNumber` method validates whether the given credit card number is valid.

#### Parameters

- `creditCardNumber` (string): The credit card number to validate.

#### Returns

- `true` if the credit card number is valid.
- `false` if the credit card number is not valid.

#### Remarks

- The credit card number must not be null, empty, or contain only whitespace characters.
- The method removes any spaces or dashes from the credit card number before validation.
- The credit card number must be numeric and not empty.
- The credit card number must pass the Luhn algorithm (modulus 10 checksum).
- The credit card number must match one of the supported card types: Visa, MasterCard, American Express (Amex), Discover, or Diners Club.

## Example

```csharp
using XValid;

string creditCardNumber = "4111 1111 1111 1111"; // Example card number (Visa)
bool isValid = CreditCardValidator.IsValidCreditCardNumber(creditCardNumber);

if (isValid)
{
    Console.WriteLine("Valid credit card number!");
}
else
{
    Console.WriteLine("Invalid credit card number!");
}
```

That's it! You can use the `CreditCardValidator` class in your C# code to validate credit card numbers based on the defined checks and supported card types. If you have any questions or need more information, feel free to explore other sections of the API reference or check out the [Get Started](/get-started) page for an overview of XValid.
