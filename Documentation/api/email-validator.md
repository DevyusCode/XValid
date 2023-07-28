# EmailValidator Class

The `EmailValidator` class is a simple email validator that uses regular expressions to validate the correctness and syntactical accuracy of an email address.

## Regular Expression Pattern

The `EmailValidator` class uses the following regular expression pattern for email validation:

```csharp
private static readonly string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
```

## Methods

### `IsValidEmail`

```csharp
public static bool IsValidEmail(string email)
```

The `IsValidEmail` method validates whether the given email address is valid according to the specified regular expression pattern.

#### Parameters

- `email` (string): The email address to validate.

#### Returns

- `true` if the email address is valid.
- `false` if the email address is not valid.

#### Remarks

- The email address must not be null, empty, or contain only whitespace characters.
- The method uses the regular expression pattern `EmailPattern` to validate the email address.
- The pattern allows email addresses with alphanumeric characters, dots, underscores, percent signs, plus signs, and hyphens in the local part.
- The domain part is allowed to contain alphanumeric characters, dots, and hyphens, with at least two letters at the end.

## Example

```csharp
using XValid;

string email = "user@example.com";
bool isValid = EmailValidator.IsValidEmail(email);

if (isValid)
{
    Console.WriteLine("Valid email address!");
}
else
{
    Console.WriteLine("Invalid email address!");
}
```

That's it! You can use the `EmailValidator` class in your C# code to validate email addresses based on the defined regular expression pattern. If you have any questions or need more information, feel free to explore other sections of the API reference or check out the [Get Started](/get-started) page for an overview of XValid.
