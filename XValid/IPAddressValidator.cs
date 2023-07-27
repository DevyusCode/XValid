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
using System.Net;

namespace XValid;


/// <summary>
/// Enumeration representing the version of an IP address.
/// </summary>
public enum IPAddressVersion
{
	/// <summary>
	/// IPv4 version of an IP address.
	/// </summary>
	IPv4,

	/// <summary>
	/// IPv6 version of an IP address.
	/// </summary>
	IPv6
}

/// <summary>
/// Provides methods to validate IP addresses, including checking if they are valid, well-formed, and belong to a certain IP version (IPv4 or IPv6).
/// </summary>
public static class IPAddressValidator
{
	/// <summary>
	/// Validates whether the given IP address is valid and well-formed according to its IP version (IPv4 or IPv6).
	/// </summary>
	/// <param name="ipAddress">The IP address to validate.</param>
	/// <param name="version">The IP address version to check (IPv4 or IPv6).</param>
	/// <returns><c>true</c> if the IP address is valid and well-formed; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// <para>The IP address must not be null, empty, or contain only whitespace characters.</para>
	/// <para>The IP address must belong to the specified IP version (IPv4 or IPv6).</para>
	/// <para>For IPv4, the address must consist of four decimal numbers separated by periods (e.g., 192.168.0.1).</para>
	/// <para>For IPv6, the address must follow the hexadecimal format with eight groups of four hexadecimal digits, separated by colons (e.g., 2001:0db8:85a3:0000:0000:8a2e:0370:7334).</para>
	/// </remarks>
	public static bool IsValidIPAddress(string ipAddress, IPAddressVersion version)
	{
		if (string.IsNullOrWhiteSpace(ipAddress))
			return false;

		if (!IPAddress.TryParse(ipAddress, out IPAddress? parsedIP))
			return false;

		return version switch
		{
			IPAddressVersion.IPv4 => parsedIP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork,
			IPAddressVersion.IPv6 => parsedIP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6,
			_ => false,
		};
	}
}
