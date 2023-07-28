# IPAddressValidator Class

The `IPAddressValidator` class provides methods to validate IP addresses, including checking if they are valid, well-formed, and belong to a certain IP version (IPv4 or IPv6).

## Enumeration

### `IPAddressVersion`

```csharp
public enum IPAddressVersion
{
    IPv4,
    IPv6
}
```

The `IPAddressVersion` enumeration represents the version of an IP address, either IPv4 or IPv6.

## Methods

### `IsValidIPAddress`

```csharp
public static bool IsValidIPAddress(string ipAddress, IPAddressVersion version)
```

The `IsValidIPAddress` method validates whether the given IP address is valid and well-formed according to its IP version (IPv4 or IPv6).

#### Parameters

- `ipAddress` (string): The IP address to validate.
- `version` (IPAddressVersion): The IP address version to check (IPv4 or IPv6).

#### Returns

- `true` if the IP address is valid and well-formed according to the specified IP version.
- `false` if the IP address is not valid or does not belong to the specified IP version.

#### Remarks

- The IP address must not be null, empty, or contain only whitespace characters.
- The method uses `IPAddress.TryParse` to check if the IP address is valid and can be parsed.
- The IP address must belong to the specified IP version (IPv4 or IPv6).
- For IPv4, the address must consist of four decimal numbers separated by periods (e.g., 192.168.0.1).
- For IPv6, the address must follow the hexadecimal format with eight groups of four hexadecimal digits, separated by colons (e.g., 2001:0db8:85a3:0000:0000:8a2e:0370:7334).

## Example

```csharp
using XValid;

string ipv4Address = "192.168.0.1"; // Example IPv4 address
string ipv6Address = "2001:0db8:85a3:0000:0000:8a2e:0370:7334"; // Example IPv6 address

bool isValidIPv4 = IPAddressValidator.IsValidIPAddress(ipv4Address, IPAddressVersion.IPv4);
bool isValidIPv6 = IPAddressValidator.IsValidIPAddress(ipv6Address, IPAddressVersion.IPv6);

if (isValidIPv4)
{
    Console.WriteLine("Valid IPv4 address!");
}
else
{
    Console.WriteLine("Invalid IPv4 address!");
}

if (isValidIPv6)
{
    Console.WriteLine("Valid IPv6 address!");
}
else
{
    Console.WriteLine("Invalid IPv6 address!");
}
```

That's it! You can use the `IPAddressValidator` class in your C# code to validate IP addresses based on the defined checks and IP versions. If you have any questions or need more information, feel free to explore other sections of the API reference or check out the [Get Started](/get-started) page for an overview of XValid.
