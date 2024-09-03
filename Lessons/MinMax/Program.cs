////////////////////// Min and Max //////////////////////////////////////
// This code will print out the minimum and maximum values for the following signed integral types:
//    * sbyte
//    * short
//    * int
//    * long
//
// The MinValue and MaxValue properties are used to get these values.
//
// The values are printed out in the format:
//            <type name> : <minimum value> to <maximum value>
//
// The string interpolation syntax is used to insert the type name and the minimum and maximum values
// into the format string.
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//////////////////////// END SECTION //////////////////////////////////////

//////////////////////// UNSIGNED INTERGERAL TYPES ////////////////////////

// Print a blank line to separate the output for signed and unsigned integral types
Console.WriteLine("");

// Print out the minimum and maximum values for the following unsigned integral types:
//    * byte
//    * ushort
//    * uint
//    * ulong
//
// The MinValue and MaxValue properties are used to get these values.
//
// The values are printed out in the format:
//            <type name> : <minimum value> to <maximum value>
//
// The string interpolation syntax is used to insert the type name and the minimum and maximum values
// into the format string.
Console.WriteLine("Unsigned integral types:");

// Print out the minimum and maximum values for the byte type
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Print out the minimum and maximum values for the ushort type
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Print out the minimum and maximum values for the uint type
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Print out the minimum and maximum values for the ulong type
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

//////////////////////// END SECTION //////////////////////////////////////

/////////////////////// FLOATING-POINT TYPES /////////////////////////////

// Print a blank line to separate the output for signed and unsigned integral types
// and the floating-point types.
Console.WriteLine("");

// Print out the minimum and maximum values for the following floating-point types:
//    * float
//    * double
//    * decimal
//
// The MinValue and MaxValue properties are used to get these values.
//
// The values are printed out in the format:
//            <type name> : <minimum value> to <maximum value>
//
// The string interpolation syntax is used to insert the type name and the minimum and maximum values
// into the format string.
Console.WriteLine("Floating point types:");

// Print out the minimum and maximum values for the float type
// The float type has a minimum value of -3.402823e38 and a maximum value of 3.402823e38
// The float type has a precision of approximately 6-9 digits.
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");

// Print out the minimum and maximum values for the double type
// The double type has a minimum value of -1.7976931348623157E+308 and a maximum value of 1.7976931348623157E+308
// The double type has a precision of approximately 15-17 digits.
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");

// Print out the minimum and maximum values for the decimal type
// The decimal type has a minimum value of -79228162514264337593543950335 and a maximum value of 79228162514264337593543950335
// The decimal type has a precision of approximately 28-29 digits.
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

///////////////////////// END SECTION //////////////////////////////////////
