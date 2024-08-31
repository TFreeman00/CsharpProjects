//////////////////////// CHECK FOR VALID IP //////////////////////////////////

/// <summary>
/// This is the main program that will check if the IPv4 addresses
/// in the ipv4Input array are valid or not.
/// </summary>
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};

// Create an array of strings to store the results of splitting
// the IPv4 address into its component parts.
string[] address;

// Create boolean variables to store the results of the three
// validation checks that we'll perform on the IPv4 address.
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

// Loop through each IPv4 address in the ipv4Input array.
foreach (string ip in ipv4Input) 
{
    // Split the IPv4 address into its component parts, using the
    // period character as the separator.
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    // Call the ValidateLength() method to check if the length of the
    // address array is 4. This is a required length for an IPv4 address.
    ValidateLength(); 

    // Call the ValidateZeroes() method to check if there are any leading
    // zeroes in the address array. Leading zeroes are not allowed in an
    // IPv4 address.
    ValidateZeroes(); 

    // Call the ValidateRange() method to check if all the numbers in the
    // address array are within the valid range of 0 to 255. This is a
    // required range for an IPv4 address.
    ValidateRange();

    // If all the validation checks pass, print out a message indicating
    // that the IPv4 address is valid.
    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        // If any of the validation checks fail, print out a message
        // indicating that the IPv4 address is invalid.
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

/// <summary>
/// This method checks if the length of the address array is 4. This
/// is a required length for an IPv4 address.
/// </summary>
void ValidateLength() 
{
    validLength = address.Length == 4;
};

/// <summary>
/// This method checks if there are any leading zeroes in the address
/// array. Leading zeroes are not allowed in an IPv4 address.
/// </summary>
void ValidateZeroes() 
{
    foreach (string number in address) 
    {
        // Check if the length of the current number is greater than 1
        // character, and if the first character is a zero.
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            // If there is a leading zero, set validZeroes to false and
            // exit the method.
            validZeroes = false;
            return;
        }
    }

    // If there were no leading zeroes, set validZeroes to true.
    validZeroes = true;
}

/// <summary>
/// This method checks if all the numbers in the address array are
/// within the valid range of 0 to 255. This is a required range for
/// an IPv4 address.
/// </summary>
void ValidateRange() 
{
    foreach (string number in address) 
    {
        // Parse the current number into an integer.
        int value = int.Parse(number);

        // Check if the current number is within the valid range of 0 to
        // 255. If it's not, set validRange to false and exit the method.
        if (value < 0 || value > 255) 
        {
            validRange = false;
            return;
        }
    }

    // If all the numbers in the address array were within the valid
    // range, set validRange to true.
    validRange = true;
}


/////////////////////////// END SECTION //////////////////////////////////