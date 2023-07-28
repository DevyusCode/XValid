# XValid - A Simple Validator Library

![GitHub contributors](https://img.shields.io/github/contributors/DevuysCode/XValid)
![GitHub issues](https://img.shields.io/github/issues/DevuysCode/XValid)
![GitHub](https://img.shields.io/github/license/DevuysCode/XValid)
![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/DevuysCode/XValid/dotnet.yml?branch=main)
![Using PeyrSharp](https://img.shields.io/badge/using-PeyrSharp-DD00FF?logo=nuget)
![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/DevuysCode/XValid)

<br />
<br />
<p align="center">
  <a href="https://github.com/DevuysCode/XValid">
    <img src=".github/images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h1 align="center">XValid</h3>

  <p align="center">
    A simple validator library for various things, such as coordinates, credit cards, domain names, emails, IBANs, IP addresses, ISBNs, and more.
    <br />
    <a href="https://github.com/DevuysCode/XValid/issues/new?assignees=&labels=bug&template=bug-report.yml&title=%5BBug%5D+">Report Bug</a>
    ·
    <a href="https://github.com/DevuysCode/XValid/issues/new?assignees=&labels=enhancement&template=feature-request.yml&title=%5BEnhancement%5D+">Request Feature</a>
    ·
    <a href="https://github.com/DevuysCode/XValid/issues?q=is%3Aopen+is%3Aissue+label%3Abug">Known Issues</a>
  </p>
</p>

## Features

- [x] Validate coordinates.
- [x] Validate credit card numbers.
- [x] Validate domain names.
- [x] Validate email addresses.
- [x] Validate IBANs.
- [x] Validate IP addresses.
- [x] Validate ISBNs.
- [ ] More features are planned for future releases.

## How to Use

1. Install XValid via NuGet using the following command:

```
Install-Package XValid
```

or

```
dotnet add package XValid
```

2. Import the `XValid` namespace in your C# code.

3. Start validating!

### Coordinate Validation

```csharp
using XValid;

double latitude = 40.7128; // Example latitude
double longitude = -74.0060; // Example longitude
bool isValidCoordinate = CoordinateValidator.IsValidCoordinate(latitude, longitude);
```

### Credit Card Validation

```csharp
using XValid;

string creditCardNumber = "4111 1111 1111 1111"; // Example card number (Visa)
bool isValidCreditCard = CreditCardValidator.IsValidCreditCardNumber(creditCardNumber);
```

### Domain Name Validation

```csharp
using XValid;

string domainName = "example.com";
bool isValidDomainName = DomainNameValidator.IsValid(domainName);
```

### Email Validation

```csharp
using XValid;

string email = "user@example.com";
bool isValidEmail = EmailValidator.IsValidEmail(email);
```

### IBAN Validation

```csharp
using XValid;

string iban = "DE89370400440532013000"; // Example IBAN (Germany)
bool isValidIBAN = IBANValidator.IsValidIBAN(iban);
```

### IP Address Validation

```csharp
using XValid;

string ipAddress = "192.0.2.1"; // Example IP address
bool isValidIPAddress = IPAddressValidator.IsValidIPAddress(ipAddress);
```

### ISBN Validation

```csharp
using XValid;

string isbn = "978-3-16-148410-0";
bool isValidISBN = ISBNValidator.IsValidISBN(isbn);
```

## Contribution Guidelines

To contribute to XValid, follow these steps:

1. Ensure you have the following tools installed:
   - Visual Studio 2022 v17.0 or higher
   - .NET 6.0 SDK
   - Git
   - .NET 6
2. Fork the XValid repository and clone it to your local machine.
3. Make your changes or add new features.
4. Write tests to ensure the changes are functioning as expected.
5. Submit a pull request to the main repository.

For more detailed guidelines, check out the [contribution guidelines](CONTRIBUTING.md).

## License

This project is under the [MIT License](LICENSE).
