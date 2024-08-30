
// Here, we're showing that if you try to add an integer to a string, it
// will be converted to a string automatically. This is because the +
// operator is overloaded for strings to mean concatenation. So
// "first" is converted to a string and then appended to "second",
// and the result is a new string that is then assigned to "result".

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);


// Next, we're explicitly converting an integer to a string using the
// ToString() method. This is a more explicit way of converting an
// integer to a string. The idea is that if you want to concatenate two
// strings, you should use the + operator. But if you want to convert an
// integer to a string, you should use the ToString() method.

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

// Now, we're converting a string to an integer using the Parse() method.
// This is a more explicit way of converting a string to an integer. The
// idea is that if you want to convert a string to an integer, you should
// use the Parse() method.

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

// Next, we're converting a string to an integer using the Convert class.
// This is another way of converting a string to an integer. The idea is
// that if you want to convert a string to an integer, you should use the
// Convert class.

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// Finally, we're using the TryParse() method to convert a string to an
// integer. This is a more explicit way of converting a string to an
// integer. The idea is that if you want to convert a string to an integer
// and you're not sure if it will succeed, you should use the TryParse()
// method.

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");


 //////////////////////////////////////////////////////////////////////////
 
// Set up an array of strings. This array contains a mix of decimal strings and
// strings that cannot be converted to decimals.
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// Declare a variable to store the total of all the decimal values in the
// values array. Initialize it to zero.
decimal total = 0m;

// Declare a variable to store a string of all the values that failed to
// convert to a decimal. Initialize it to an empty string.
string message = string.Empty;

// Iterate through each value in the values array.
foreach (var value in values)
{
    // Declare a variable to store the value that we're trying to convert to
    // decimal. The out keyword allows us to store a value in a variable and
    // pass it to a method that takes an out parameter.
    decimal number;

    // Attempt to convert the current value to a decimal using the
    // TryParse() method. If the conversion is successful, the method
    // returns true and the converted value is stored in the number
    // variable. If the conversion fails, the method returns false and
    // the number variable is set to zero.
    if (decimal.TryParse(value, out number))
    {
        // If the conversion was successful, add the converted value to
        // the total.
        total += number;
    }
    else
    {
        // If the conversion failed, add the original string to the
        // message.
        message += value;
    }
}

// Print out the message and the total. The message will contain all the
// strings that failed to convert to a decimal. The total will contain the
// sum of all the decimal values in the values array.
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total:C}");

///////////////////////////////////////////////////////////////


// We're going to do some division and casting
// The first example uses the Convert class to convert a decimal to an int
// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.

// The first division is going to divide an int by a decimal
// The result of this division is a decimal
// The Convert class is used to convert this decimal to an int
int result1 = Convert.ToInt32(value1 / value2);
// The result is then output to the console as an int
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Next, we're going to divide a decimal by a float
// The result of this division is a decimal
decimal result2 = value2 / (decimal)value3;
// The result is then output to the console as a decimal
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Finally, we're going to divide a float by an int
// The result of this division is a float
float result3 = value3 / value1;
// The result is then output to the console as a float
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
//////////////////////////////////////////////////////////////////

