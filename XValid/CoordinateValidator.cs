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

/// <summary>
/// Provides methods to validate latitude and longitude coordinates.
/// </summary>
public static class CoordinateValidator
{
	/// <summary>
	/// Validates whether the given latitude and longitude coordinates are valid.
	/// </summary>
	/// <param name="latitude">The latitude coordinate to validate (in degrees).</param>
	/// <param name="longitude">The longitude coordinate to validate (in degrees).</param>
	/// <returns><c>true</c> if both latitude and longitude coordinates are valid; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// <para>The latitude coordinate must be within the range of -90 to 90 degrees, inclusive.</para>
	/// <para>The longitude coordinate must be within the range of -180 to 180 degrees, inclusive.</para>
	/// </remarks>
	public static bool IsValidCoordinate(double latitude, double longitude)
	{
		return IsValidLatitude(latitude) && IsValidLongitude(longitude);
	}

	/// <summary>
	/// Validates whether the given latitude coordinate is valid.
	/// </summary>
	/// <param name="latitude">The latitude coordinate to validate (in degrees).</param>
	/// <returns><c>true</c> if the latitude coordinate is valid; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// <para>The latitude coordinate must be within the range of -90 to 90 degrees, inclusive.</para>
	/// </remarks>
	public static bool IsValidLatitude(double latitude)
	{
		return latitude >= -90 && latitude <= 90;
	}

	/// <summary>
	/// Validates whether the given longitude coordinate is valid.
	/// </summary>
	/// <param name="longitude">The longitude coordinate to validate (in degrees).</param>
	/// <returns><c>true</c> if the longitude coordinate is valid; otherwise, <c>false</c>.</returns>
	/// <remarks>
	/// <para>The longitude coordinate must be within the range of -180 to 180 degrees, inclusive.</para>
	/// </remarks>
	public static bool IsValidLongitude(double longitude)
	{
		return longitude >= -180 && longitude <= 180;
	}
}
