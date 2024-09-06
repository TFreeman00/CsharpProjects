////////////////////// THROW CHALLENGE ////////////////////////
try
{
    // Call the OperatingProcedure1() method, which will call the BusinessProcess1() method.
    // The BusinessProcess1() method will attempt to parse the user's input as integers and perform a calculation.
    // If the user's input is invalid, a FormatException will be thrown.
    // If the calculation would result in a divide by zero, a DivideByZeroException will be thrown.
    OperatingProcedure1();
}
catch (Exception ex)
{
    // If an exception is thrown, catch it and print out a message indicating that an error occurred.
    Console.WriteLine(ex.Message);
    Console.WriteLine("Exiting application.");
}

static void OperatingProcedure1()
{
    // Declare an array of arrays of strings, userEnteredValues.
    // This array will hold the user's input values.
    string[][] userEnteredValues = new string[][]
    {
        // The first array will hold three strings: "1", "two", and "3".
        new string[] { "1", "two", "3"},
        // The second array will hold three strings: "0", "1", and "2".
        new string[] { "0", "1", "2"}
    };

    // Loop through each array in the userEnteredValues array.
    foreach(string[] userEntries in userEnteredValues)
    {
        try
        {
            // Call the BusinessProcess1() method, passing in the userEntries array.
            BusinessProcess1(userEntries);
        }
        catch (Exception ex)
        {
            // If an exception is thrown by BusinessProcess1(), catch it and check if it is a FormatException or a DivideByZeroException.
            if (ex.StackTrace.Contains("BusinessProcess1"))
            {
                if (ex is FormatException)
                {
                    // If the exception is a FormatException, print out a message indicating that the user's input was invalid.
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Corrective action taken in OperatingProcedure1");
                }
                else if (ex is DivideByZeroException)
                {
                    // If the exception is a DivideByZeroException, print out a message indicating that a division by zero was encountered.
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                    // Re-throw the original exception, so that it can be caught by the outer try-catch block.
                    throw;
                }
                else
                {
                    // If the exception is neither a FormatException nor a DivideByZeroException, create a new ApplicationException that wraps the original exception.
                    throw new ApplicationException("An error occurred - ", ex);
                }
            }
        }

    }
}

static void BusinessProcess1(string[] userEntries)
{
    int valueEntered;

    // Loop through each string in the userEntries array.
    foreach (string userValue in userEntries)
    {
        try
        {
            // Attempt to parse the userValue string as an integer.
            valueEntered = int.Parse(userValue);

            // Perform a calculation that would result in a divide by zero if the user's input is "0".
            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (FormatException)
        {
            // If the user's input is invalid, throw a FormatException.
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
            // If the calculation would result in a divide by zero, throw a DivideByZeroException.
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            throw unexpectedDivideByZeroException;

        }
    }
}

//////////////////////// END SECTION //////////////////////////////

//////////////////////// CHALLENGE /////////////////////////////////////
///

string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"}, // This array contains three strings: "1", "2", and "3".
            new string[] { "1", "two", "3"}, // This array contains three strings: "1", "two", and "3".
            new string[] { "0", "1", "2"} // This array contains three strings: "0", "1", and "2".
};

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
}

catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    // This method takes an array of arrays of strings, userEnteredValues, and processes each array in the collection.
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    // This method takes an array of strings, userEntries, and processes each string in the collection.
    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
}


//////////////////////// END SECTION //////////////////////////////