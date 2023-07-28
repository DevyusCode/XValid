# CoordinateValidator Class

The `CoordinateValidator` class provides methods to validate latitude and longitude coordinates.

## Methods

### `IsValidCoordinate`

```csharp
public static bool IsValidCoordinate(double latitude, double longitude)
```

The `IsValidCoordinate` method validates whether the given latitude and longitude coordinates are valid.

#### Parameters

- `latitude` (double): The latitude coordinate to validate (in degrees).
- `longitude` (double): The longitude coordinate to validate (in degrees).

#### Returns

- `true` if both latitude and longitude coordinates are valid.
- `false` if either latitude or longitude coordinate is not valid.

#### Remarks

- The latitude coordinate must be within the range of -90 to 90 degrees, inclusive.
- The longitude coordinate must be within the range of -180 to 180 degrees, inclusive.

### `IsValidLatitude`

```csharp
public static bool IsValidLatitude(double latitude)
```

The `IsValidLatitude` method validates whether the given latitude coordinate is valid.

#### Parameters

- `latitude` (double): The latitude coordinate to validate (in degrees).

#### Returns

- `true` if the latitude coordinate is valid.
- `false` if the latitude coordinate is not valid.

#### Remarks

- The latitude coordinate must be within the range of -90 to 90 degrees, inclusive.

### `IsValidLongitude`

```csharp
public static bool IsValidLongitude(double longitude)
```

The `IsValidLongitude` method validates whether the given longitude coordinate is valid.

#### Parameters

- `longitude` (double): The longitude coordinate to validate (in degrees).

#### Returns

- `true` if the longitude coordinate is valid.
- `false` if the longitude coordinate is not valid.

#### Remarks

- The longitude coordinate must be within the range of -180 to 180 degrees, inclusive.

## Example

```csharp
using XValid;

double latitude = 40.7128; // Example latitude
double longitude = -74.0060; // Example longitude
bool isValidCoordinate = CoordinateValidator.IsValidCoordinate(latitude, longitude);

if (isValidCoordinate)
{
    Console.WriteLine("Valid coordinate!");
}
else
{
    Console.WriteLine("Invalid coordinate!");
}
```

That's it! You can use the `CoordinateValidator` class in your C# code to validate latitude and longitude coordinates. If you have any questions or need more information, feel free to explore other sections of the API reference or check out the [Get Started](/get-started) page for an overview of XValid.
