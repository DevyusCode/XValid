# IBANValidator Class

The `IBANValidator` class provides methods to validate International Bank Account Numbers (IBANs).

## Methods

### `IsValidIBAN`

```csharp
public static bool IsValidIBAN(string iban)
```

The `IsValidIBAN` method validates whether the given string is a valid IBAN, formatted correctly, and follows the ISO 13616 standard.

#### Parameters

- `iban` (string): The IBAN to be validated.

#### Returns

- `true` if the IBAN is valid.
- `false` if the IBAN is not valid.

#### Remarks

- The IBAN must not be null, empty, or contain only whitespace characters.
- The method removes spaces and converts the IBAN to uppercase before validation.
- The IBAN must have the correct length for its country code.
- The IBAN must contain only alphanumeric characters (letters A-Z, numbers 0-9).
- The IBAN must pass the ISO 13616 check, which involves rearranging and converting letters to corresponding numbers.

### `IsValidCountryCode`

```csharp
public static bool IsValidCountryCode(string iban)
```

The `IsValidCountryCode` method validates whether the given IBAN has a valid country code according to the ISO 3166-1 alpha-2 standard.

<details>
    <summary>Reveal supported countries</summary>

| Country Name                                                                                                                                                              | Country Code | SEPA Member | IBAN Length | IBAN Example (printed format)          |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------ | ----------- | ----------- | -------------------------------------- |
| [Albania](https://bank-code.net/iban/structure/albania-international-bank-account-number "Albania IBAN Structure & Example")                                              | AL           |             | 28          | AL47 2121 1009 0000 0002 3569 8741     |
| [Andorra](https://bank-code.net/iban/structure/andorra-international-bank-account-number "Andorra IBAN Structure & Example")                                              | AD           |             | 24          | AD12 0001 2030 2003 5910 0100          |
| [Austria](https://bank-code.net/iban/structure/austria-international-bank-account-number "Austria IBAN Structure & Example")                                              | AT           | ✔           | 20          | AT61 1904 3002 3457 3201               |
| [Azerbaijan](https://bank-code.net/iban/structure/azerbaijan-international-bank-account-number "Azerbaijan IBAN Structure & Example")                                     | AZ           |             | 28          | AZ21 NABZ 0000 0000 1370 1000 1944     |
| [Bahrain](https://bank-code.net/iban/structure/bahrain-international-bank-account-number "Bahrain IBAN Structure & Example")                                              | BH           |             | 22          | BH67 BMAG 0000 1299 1234 56            |
| [Belarus](https://bank-code.net/iban/structure/belarus-international-bank-account-number "Belarus IBAN Structure & Example")                                              | BY           |             | 28          | BY13 NBRB 3600 9000 0000 2Z00 AB00     |
| [Belgium](https://bank-code.net/iban/structure/belgium-international-bank-account-number "Belgium IBAN Structure & Example")                                              | BE           | ✔           | 16          | BE68 5390 0754 7034                    |
| [Bosnia and Herzegovina](https://bank-code.net/iban/structure/bosnia-and-herzegovina-international-bank-account-number "Bosnia and Herzegovina IBAN Structure & Example") | BA           |             | 20          | BA39 1290 0794 0102 8494               |
| [Brazil](https://bank-code.net/iban/structure/brazil-international-bank-account-number "Brazil IBAN Structure & Example")                                                 | BR           |             | 29          | BR18 0036 0305 0000 1000 9795 493C 1   |
| [Bulgaria](https://bank-code.net/iban/structure/bulgaria-international-bank-account-number "Bulgaria IBAN Structure & Example")                                           | BG           | ✔           | 22          | BG80 BNBG 9661 1020 3456 78            |
| [Costa Rica](https://bank-code.net/iban/structure/costa-rica-international-bank-account-number "Costa Rica IBAN Structure & Example")                                     | CR           |             | 22          | CR05 0152 0200 1026 2840 66            |
| [Croatia](https://bank-code.net/iban/structure/croatia-international-bank-account-number "Croatia IBAN Structure & Example")                                              | HR           | ✔           | 21          | HR12 1001 0051 8630 0016 0             |
| [Cyprus](https://bank-code.net/iban/structure/cyprus-international-bank-account-number "Cyprus IBAN Structure & Example")                                                 | CY           | ✔           | 28          | CY17 0020 0128 0000 0012 0052 7600     |
| [Czechia](https://bank-code.net/iban/structure/czechia-international-bank-account-number "Czechia IBAN Structure & Example")                                              | CZ           | ✔           | 24          | CZ65 0800 0000 1920 0014 5399          |
| [Denmark](https://bank-code.net/iban/structure/denmark-international-bank-account-number "Denmark IBAN Structure & Example")                                              | DK           | ✔           | 18          | DK50 0040 0440 1162 43                 |
| [Dominican Republic](https://bank-code.net/iban/structure/dominican-republic-international-bank-account-number "Dominican Republic IBAN Structure & Example")             | DO           |             | 28          | DO28 BAGR 0000 0001 2124 5361 1324     |
| [El Salvador](https://bank-code.net/iban/structure/el-salvador-international-bank-account-number "El Salvador IBAN Structure & Example")                                  | SV           |             | 28          | SV 62 CENR 00000000000000700025        |
| [Estonia](https://bank-code.net/iban/structure/estonia-international-bank-account-number "Estonia IBAN Structure & Example")                                              | EE           | ✔           | 20          | EE38 2200 2210 2014 5685               |
| [Faroe Islands](https://bank-code.net/iban/structure/faroe-islands-international-bank-account-number "Faroe Islands IBAN Structure & Example")                            | FO           |             | 18          | FO62 6460 0001 6316 34                 |
| [Finland](https://bank-code.net/iban/structure/finland-international-bank-account-number "Finland IBAN Structure & Example")                                              | FI           | ✔           | 18          | FI21 1234 5600 0007 85                 |
| [France](https://bank-code.net/iban/structure/france-international-bank-account-number "France IBAN Structure & Example")                                                 | FR           | ✔           | 27          | FR14 2004 1010 0505 0001 3M02 606      |
| [Georgia](https://bank-code.net/iban/structure/georgia-international-bank-account-number "Georgia IBAN Structure & Example")                                              | GE           |             | 22          | GE29 NB00 0000 0101 9049 17            |
| [Germany](https://bank-code.net/iban/structure/germany-international-bank-account-number "Germany IBAN Structure & Example")                                              | DE           | ✔           | 22          | DE89 3704 0044 0532 0130 00            |
| [Gibraltar](https://bank-code.net/iban/structure/gibraltar-international-bank-account-number "Gibraltar IBAN Structure & Example")                                        | GI           | ✔           | 23          | GI75 NWBK 0000 0000 7099 453           |
| [Greece](https://bank-code.net/iban/structure/greece-international-bank-account-number "Greece IBAN Structure & Example")                                                 | GR           | ✔           | 27          | GR16 0110 1250 0000 0001 2300 695      |
| [Greenland](https://bank-code.net/iban/structure/greenland-international-bank-account-number "Greenland IBAN Structure & Example")                                        | GL           |             | 18          | GL89 6471 0001 0002 06                 |
| [Guatemala](https://bank-code.net/iban/structure/guatemala-international-bank-account-number "Guatemala IBAN Structure & Example")                                        | GT           |             | 28          | GT82 TRAJ 0102 0000 0012 1002 9690     |
| [Hungary](https://bank-code.net/iban/structure/hungary-international-bank-account-number "Hungary IBAN Structure & Example")                                              | HU           | ✔           | 28          | HU42 1177 3016 1111 1018 0000 0000     |
| [Iceland](https://bank-code.net/iban/structure/iceland-international-bank-account-number "Iceland IBAN Structure & Example")                                              | IS           | ✔           | 26          | IS14 0159 2600 7654 5510 7303 39       |
| [Iraq](https://bank-code.net/iban/structure/iraq-international-bank-account-number "Iraq IBAN Structure & Example")                                                       | IQ           |             | 23          | IQ98 NBIQ 8501 2345 6789 012           |
| [Ireland](https://bank-code.net/iban/structure/ireland-international-bank-account-number "Ireland IBAN Structure & Example")                                              | IE           | ✔           | 22          | IE29 AIBK 9311 5212 3456 78            |
| [Israel](https://bank-code.net/iban/structure/israel-international-bank-account-number "Israel IBAN Structure & Example")                                                 | IL           |             | 23          | IL62 0108 0000 0009 9999 999           |
| [Italy](https://bank-code.net/iban/structure/italy-international-bank-account-number "Italy IBAN Structure & Example")                                                    | IT           | ✔           | 27          | IT60 X054 2811 1010 0000 0123 456      |
| [Jordan](https://bank-code.net/iban/structure/jordan-international-bank-account-number "Jordan IBAN Structure & Example")                                                 | JO           |             | 30          | JO94 CBJO 0010 0000 0000 0131 000302   |
| [Kazakhstan](https://bank-code.net/iban/structure/kazakhstan-international-bank-account-number "Kazakhstan IBAN Structure & Example")                                     | KZ           |             | 20          | KZ86 125K ZT50 0410 0100               |
| [Kosovo](https://bank-code.net/iban/structure/kosovo-international-bank-account-number "Kosovo IBAN Structure & Example")                                                 | XK           |             | 20          | XK05 1212 0123 4567 8906               |
| [Kuwait](https://bank-code.net/iban/structure/kuwait-international-bank-account-number "Kuwait IBAN Structure & Example")                                                 | KW           |             | 30          | KW81 CBKU 0000 0000 0000 1234 560101   |
| [Latvia](https://bank-code.net/iban/structure/latvia-international-bank-account-number "Latvia IBAN Structure & Example")                                                 | LV           | ✔           | 21          | LV80 BANK 0000 4351 9500 1             |
| [Lebanon](https://bank-code.net/iban/structure/lebanon-international-bank-account-number "Lebanon IBAN Structure & Example")                                              | LB           |             | 28          | LB62 0999 0000 0001 0019 0122 9114     |
| [Liechtenstein](https://bank-code.net/iban/structure/liechtenstein-international-bank-account-number "Liechtenstein IBAN Structure & Example")                            | LI           | ✔           | 21          | LI21 0881 0000 2324 013A A             |
| [Lithuania](https://bank-code.net/iban/structure/lithuania-international-bank-account-number "Lithuania IBAN Structure & Example")                                        | LT           | ✔           | 20          | LT12 1000 0111 0100 1000               |
| [Luxembourg](https://bank-code.net/iban/structure/luxembourg-international-bank-account-number "Luxembourg IBAN Structure & Example")                                     | LU           | ✔           | 20          | LU28 0019 4006 4475 0000               |
| [Macedonia](https://bank-code.net/iban/structure/macedonia-international-bank-account-number "Macedonia IBAN Structure & Example")                                        | MK           |             | 19          | MK07 2501 2000 0058 984                |
| [Malta](https://bank-code.net/iban/structure/malta-international-bank-account-number "Malta IBAN Structure & Example")                                                    | MT           | ✔           | 31          | MT84 MALT 0110 0001 2345 MTLC AST0 01S |
| [Mauritania](https://bank-code.net/iban/structure/mauritania-international-bank-account-number "Mauritania IBAN Structure & Example")                                     | MR           |             | 27          | MR13 0002 0001 0100 0012 3456 753      |
| [Mauritius](https://bank-code.net/iban/structure/mauritius-international-bank-account-number "Mauritius IBAN Structure & Example")                                        | MU           |             | 30          | MU17 BOMM 0101 1010 3030 0200 000M UR  |
| [Moldova](https://bank-code.net/iban/structure/moldova-international-bank-account-number "Moldova IBAN Structure & Example")                                              | MD           |             | 24          | MD24 AG00 0225 1000 1310 4168          |
| [Monaco](https://bank-code.net/iban/structure/monaco-international-bank-account-number "Monaco IBAN Structure & Example")                                                 | MC           | ✔           | 27          | MC58 1122 2000 0101 2345 6789 030      |
| [Montenegro](https://bank-code.net/iban/structure/montenegro-international-bank-account-number "Montenegro IBAN Structure & Example")                                     | ME           |             | 22          | ME25 5050 0001 2345 6789 51            |
| [Netherlands](https://bank-code.net/iban/structure/netherlands-international-bank-account-number "Netherlands IBAN Structure & Example")                                  | NL           | ✔           | 18          | NL91 ABNA 0417 1643 00                 |
| [Norway](https://bank-code.net/iban/structure/norway-international-bank-account-number "Norway IBAN Structure & Example")                                                 | NO           | ✔           | 15          | NO93 8601 1117 947                     |
| [Pakistan](https://bank-code.net/iban/structure/pakistan-international-bank-account-number "Pakistan IBAN Structure & Example")                                           | PK           |             | 24          | PK36 SCBL 0000 0011 2345 6702          |
| [Palestine](https://bank-code.net/iban/structure/palestine-international-bank-account-number "Palestine IBAN Structure & Example")                                        | PS           |             | 29          | PS92 PALS 0000 0000 0400 1234 5670 2   |
| [Poland](https://bank-code.net/iban/structure/poland-international-bank-account-number "Poland IBAN Structure & Example")                                                 | PL           | ✔           | 28          | PL61 1090 1014 0000 0712 1981 2874     |
| [Portugal](https://bank-code.net/iban/structure/portugal-international-bank-account-number "Portugal IBAN Structure & Example")                                           | PT           | ✔           | 25          | PT50 0002 0123 1234 5678 9015 4        |
| [Qatar](https://bank-code.net/iban/structure/qatar-international-bank-account-number "Qatar IBAN Structure & Example")                                                    | QA           |             | 29          | QA58 DOHB 0000 1234 5678 90AB CDEF G   |
| [Romania](https://bank-code.net/iban/structure/romania-international-bank-account-number "Romania IBAN Structure & Example")                                              | RO           | ✔           | 24          | RO49 AAAA 1B31 0075 9384 0000          |
| [Saint Lucia](https://bank-code.net/iban/structure/saint-lucia-international-bank-account-number "Saint Lucia IBAN Structure & Example")                                  | LC           |             | 32          | LC55 HEMM 0001 0001 0012 0012 00023015 |
| [San Marino](https://bank-code.net/iban/structure/san-marino-international-bank-account-number "San Marino IBAN Structure & Example")                                     | SM           | ✔           | 27          | SM86 U032 2509 8000 0000 0270 100      |
| [Sao Tome and Principe](https://bank-code.net/iban/structure/sao-tome-and-principe-international-bank-account-number "Sao Tome and Principe IBAN Structure & Example")    | ST           |             | 25          | ST68 0002 0001 0192 1942 1011 2        |
| [Saudi Arabia](https://bank-code.net/iban/structure/saudi-arabia-international-bank-account-number "Saudi Arabia IBAN Structure & Example")                               | SA           |             | 24          | SA03 8000 0000 6080 1016 7519          |
| [Serbia](https://bank-code.net/iban/structure/serbia-international-bank-account-number "Serbia IBAN Structure & Example")                                                 | RS           |             | 22          | RS35 2600 0560 1001 6113 79            |
| [Seychelles](https://bank-code.net/iban/structure/seychelles-international-bank-account-number "Seychelles IBAN Structure & Example")                                     | SC           |             | 31          | SC18 SSCB 1101 0000 0000 0000 1497 USD |
| [Slovakia](https://bank-code.net/iban/structure/slovakia-international-bank-account-number "Slovakia IBAN Structure & Example")                                           | SK           | ✔           | 24          | SK31 1200 0000 1987 4263 7541          |
| [Slovenia](https://bank-code.net/iban/structure/slovenia-international-bank-account-number "Slovenia IBAN Structure & Example")                                           | SI           | ✔           | 19          | SI56 2633 0001 2039 086                |
| [Spain](https://bank-code.net/iban/structure/spain-international-bank-account-number "Spain IBAN Structure & Example")                                                    | ES           | ✔           | 24          | ES91 2100 0418 4502 0005 1332          |
| [Sweden](https://bank-code.net/iban/structure/sweden-international-bank-account-number "Sweden IBAN Structure & Example")                                                 | SE           | ✔           | 24          | SE45 5000 0000 0583 9825 7466          |
| [Switzerland](https://bank-code.net/iban/structure/switzerland-international-bank-account-number "Switzerland IBAN Structure & Example")                                  | CH           | ✔           | 21          | CH93 0076 2011 6238 5295 7             |
| [Timor-Leste](https://bank-code.net/iban/structure/timor_leste-international-bank-account-number "Timor-Leste IBAN Structure & Example")                                  | TL           |             | 23          | TL38 0080 0123 4567 8910 157           |
| [Tunisia](https://bank-code.net/iban/structure/tunisia-international-bank-account-number "Tunisia IBAN Structure & Example")                                              | TN           |             | 24          | TN59 1000 6035 1835 9847 8831          |
| [Turkey](https://bank-code.net/iban/structure/turkey-international-bank-account-number "Turkey IBAN Structure & Example")                                                 | TR           |             | 26          | TR33 0006 1005 1978 6457 8413 26       |
| [Ukraine](https://bank-code.net/iban/structure/ukraine-international-bank-account-number "Ukraine IBAN Structure & Example")                                              | UA           |             | 29          | UA21 3223 1300 0002 6007 2335 6600 1   |
| [United Arab Emirates](https://bank-code.net/iban/structure/united-arab-emirates-international-bank-account-number "United Arab Emirates IBAN Structure & Example")       | AE           |             | 23          | AE07 0331 2345 6789 0123 456           |
| [United Kingdom](https://bank-code.net/iban/structure/united-kingdom-international-bank-account-number "United Kingdom IBAN Structure & Example")                         | GB           | ✔           | 22          | GB29 NWBK 6016 1331 9268 19            |
| [Vatican City State](https://bank-code.net/iban/structure/vatican-city-state-international-bank-account-number "Vatican City State IBAN Structure & Example")             | VA           |             | 22          | VA59 001 1230 0001 2345 678            |
| [Virgin Islands](https://bank-code.net/iban/structure/virgin-islands-international-bank-account-number "Virgin Islands IBAN Structure & Example")                         | VG           |             | 24          | VG96 VPVG 0000 0123 4567 8901          |

</details>

#### Parameters

- `iban` (string): The IBAN to be validated.

#### Returns

- `true` if the country code in the IBAN is valid.
- `false` if the country code in the IBAN is not valid.

#### Remarks

- The method checks the first two characters of the IBAN to identify the country code.
- The IBAN's country code must match one of the valid country codes based on the ISO 3166-1 alpha-2 standard.

## Example

```csharp
using XValid;

string iban = "GB29 NWBK 6016 1331 9268 19"; // Example IBAN (United Kingdom)
bool isValid = IBANValidator.IsValidIBAN(iban);

if (isValid)
{
    Console.WriteLine("Valid IBAN!");
}
else
{
    Console.WriteLine("Invalid IBAN!");
}
```

That's it! You can use the `IBANValidator` class in your C# code to validate International Bank Account Numbers (IBANs) based on the defined checks and ISO standards. If you have any questions or need more information, feel free to explore other sections of the API reference or check out the [Get Started](/get-started) page for an overview of XValid.
