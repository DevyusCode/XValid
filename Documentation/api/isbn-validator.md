# ISBNValidator Class

The `ISBNValidator` class provides methods to validate ISBNs (International Standard Book Numbers), including checking if they are valid, formatted, and follow the ISBN-10 or ISBN-13 standard.

## Methods

### `IsValidISBN`

```csharp
public static bool IsValidISBN(string isbn)
```

The `IsValidISBN` method validates whether the given ISBN is valid and follows the specified ISBN version (ISBN-10 or ISBN-13).

#### Parameters

- `isbn` (string): The ISBN to validate.

#### Returns

- `true` if the ISBN is valid and follows the specified version (ISBN-10 or ISBN-13).
- `false` if the ISBN is not valid or does not follow the specified version.

#### Remarks

- The ISBN must not be null, empty, or contain only whitespace characters.
- The method removes any spaces or dashes from the ISBN before validation.
- The ISBN must be correctly formatted according to the specified version (ISBN-10 or ISBN-13).
- For ISBN-10, the ISBN must consist of 10 digits (either numeric or with the last character being 'X' for the check digit).
- For ISBN-13, the ISBN must consist of 13 digits (numeric only) and follow the EAN-13 format.

### `IsValidISBN10`

```csharp
public static bool IsValidISBN10(string isbn)
```

The `IsValidISBN10` method checks if a given string is a valid ISBN-10 number.

#### Parameters

- `isbn` (string): The string to check.

#### Returns

- `true` if the string is a valid ISBN-10 number.
- `false` otherwise.

#### Remarks

- The method removes any spaces or dashes from the input string before validation.
- The ISBN must not be null, empty, or contain only whitespace characters.
- The ISBN must consist of 10 digits (either numeric or with the last character being 'X' for the check digit).
- The method performs the ISBN-10 validation using the modulus 11 algorithm:

1. Multiply each of the first nine digits of the ISBN by a weight, starting from 10 and decreasing by 1 for each digit.
2. Sum the results of the multiplication.
3. If the last character of the ISBN is 'X', add 10 to the sum; otherwise, add the value of the last digit.
4. The ISBN is valid if the sum is divisible by 11 (i.e., `(sum % 11) == 0`).

### `IsValidISBN13`

```csharp
public static bool IsValidISBN13(string isbn)
```

The `IsValidISBN13` method checks if a given string is a valid ISBN-13 number.

#### Parameters

- `isbn` (string): The string to check.

#### Returns

- `true` if the string is a valid ISBN-13 number.
- `false` otherwise.

#### Remarks

- The method removes any spaces or dashes from the input string before validation.
- The ISBN must not be null, empty, or contain only whitespace characters.
- The ISBN must consist of 13 digits (numeric only) and follow the EAN-13 format.
- The method performs the ISBN-13 validation using the EAN-13 check digit calculation:

1. Multiply each of the first 12 digits of the ISBN by a weight, alternating between 1 and 3 for each digit.
2. Sum the results of the multiplication.
3. Calculate the check digit as follows: `checksum = 10 - (sum % 10)`, or 0 if `(sum % 10) == 0`.
4. The ISBN is valid if the last digit of the ISBN matches the calculated check digit.

## Example

```csharp
using XValid;

string isbn10 = "0-306-40615-2"; // Example ISBN-10
string isbn13 = "978-3-16-148410-0"; // Example ISBN-13

bool isValidISBN10 = ISBNValidator.IsValidISBN(isbn10);
bool isValidISBN13 = ISBNValidator.IsValidISBN(isbn13);

if (isValidISBN10)
{
    Console.WriteLine("Valid ISBN-10!");
}
else
{
    Console.WriteLine("Invalid ISBN-10!");
}

if (isValidISBN13)
{
    Console.WriteLine("Valid ISBN-13!");
}
else
{
    Console.WriteLine("Invalid ISBN-13!");
}
```

That's it! You can use the `ISBNValidator` class in your C# code to validate ISBNs and ensure they are correctly formatted according to the ISBN-10 or ISBN-13 standard. If you have any questions or need more information, feel free to explore other sections of the API reference or check out the [Get Started](/getting-started) page for an overview of XValid.
