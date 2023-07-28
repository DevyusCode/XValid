# Get Started with XValid

Welcome to XValid! This page will guide you through the steps to get started with the XValid validator library for C#. XValid provides easy-to-use functions to validate various data types, ensuring data integrity in your applications.

## Installation

To use XValid in your C# project, you can install it via NuGet. Open your NuGet Package Manager Console and run the following command:

```bash
Install-Package XValid
```

# Get Started with XValid

Welcome to XValid! This page will guide you through the steps to get started with the XValid validator library for C#. XValid provides easy-to-use functions to validate various data types, ensuring data integrity in your applications.

## Installation

To use XValid in your C# project, you can install it via NuGet. Open your NuGet Package Manager Console and run the following command:

```bash
Install-Package XValid
```

Alternatively, you can install XValid using the Package Manager UI in Visual Studio.

## Usage

Once you have installed XValid, you can start using it in your C# code. First, import the `XValid` namespace to access the validation functions:

```csharp
using XValid;
```

### Email Validation

```csharp
string email = "user@example.com";
bool isValidEmail = Validator.IsValidEmail(email);

if (isValidEmail)
{
    Console.WriteLine("Valid email address!");
}
else
{
    Console.WriteLine("Invalid email address!");
}
```

### ISBN Validation

```csharp
string isbn = "978-3-16-148410-0";
bool isValidISBN = Validator.IsValidISBN(isbn);

if (isValidISBN)
{
    Console.WriteLine("Valid ISBN!");
}
else
{
    Console.WriteLine("Invalid ISBN!");
}
```

### IBAN Validation

```csharp
string iban = "DE89370400440532013000"; // Example IBAN (Germany)
bool isValidIBAN = Validator.IsValidIBAN(iban);

if (isValidIBAN)
{
    Console.WriteLine("Valid IBAN!");
}
else
{
    Console.WriteLine("Invalid IBAN!");
}
```

### Credit Card Validation

```csharp
string creditCardNumber = "4111 1111 1111 1111"; // Example card number (Visa)
bool isValidCreditCard = Validator.IsValidCreditCardNumber(creditCardNumber);

if (isValidCreditCard)
{
    Console.WriteLine("Valid credit card number!");
}
else
{
    Console.WriteLine("Invalid credit card number!");
}
```

### IP Address Validation

```csharp
string ipAddress = "192.0.2.1"; // Example IP address
bool isValidIPAddress = Validator.IsValidIPAddress(ipAddress);

if (isValidIPAddress)
{
    Console.WriteLine("Valid IP address!");
}
else
{
    Console.WriteLine("Invalid IP address!");
}
```

### Coordinate Validation

```csharp
double latitude = 40.7128; // Example latitude
double longitude = -74.0060; // Example longitude
bool isValidCoordinate = Validator.IsValidCoordinate(latitude, longitude);

if (isValidCoordinate)
{
    Console.WriteLine("Valid coordinate!");
}
else
{
    Console.WriteLine("Invalid coordinate!");
}
```

That's it! You're all set to start using XValid for data validation in your C# projects. If you encounter any issues or need further assistance, don't hesitate to check out the [API Reference](/ref) for more details.
