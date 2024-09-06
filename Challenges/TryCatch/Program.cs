////////////////////////// TRY CATCH CHALLENGE //////////////////////////
///
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}

///////////////////////////////// END SECTION //////////////////////////////

////////////////////// EXEMTION PROPERTIES /////////////////////////////
///
/*
Data: The Data property stores arbitrary data as key-value pairs.

HelpLink: The HelpLink property holds the URL or URN of a help file that provides more information about the exception.

HResult: The HResult property returns a coded numerical value for the exception.

InnerException: The InnerException property preserves the exception that caused the current exception.

Message: The Message property provides details about the exception.

Source: The Source property holds the name of the application or object that caused the exception.

StackTrace: The StackTrace property contains the stack trace of the exception.

TargetSite: The TargetSite property returns the method that threw the exception.

*/


/*
 * This program is a demonstration of how to use try-catch blocks
 * to catch and handle exceptions in C#.
 *
 * The program first calls the Process1() method, which calls the
 * WriteMessage() method. WriteMessage() attempts to divide two
 * numbers, but since the second number is zero, a DivideByZeroException
 * is thrown. This exception is then caught by the try-catch block
 * in Process1() and the message is written to the console.
 *
 * The outer try-catch block then catches the exception again, and
 * writes a message to the console saying that an exception has occurred.
 *
 * Finally, the program writes "Exit program" to the console.
 */

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

/*
 * Process1() is a method that calls WriteMessage().
 *
 * It has a try-catch block to catch any exceptions that are thrown
 * by WriteMessage().
 */
static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

/*
 * WriteMessage() is a method that attempts to divide two numbers.
 *
 * If the second number is zero, a DivideByZeroException is thrown.
 */
static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    Console.WriteLine(float1 / float2);
    // Console.WriteLine(number1 / number2);
    checked
    {
        smallNumber = (byte)number1;
    }
}

////////////////// CATCH SPECIFIC EXCEPTIONS ///////////////////////////
///

/// <summary>
/// This code block demonstrates how to catch and handle exceptions in C#.
/// </summary>
checked
{
    try
    {
        // Attempt to add two large integers together, which will cause an OverflowException.
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        // Catch the OverflowException and print out a message indicating that the number is too large
        // to be represented as an integer.
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}

try
{
    // Attempt to get the length of a null string, which will cause a NullReferenceException.
    string? str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    // Catch the NullReferenceException and print out a message indicating that the reference is null.
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
    // Attempt to access an element of an array that is out of range, which will cause an IndexOutOfRangeException.
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    // Catch the IndexOutOfRangeException and print out a message indicating that the index is out of range.
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try
{
    // Attempt to divide by zero, which will cause a DivideByZeroException.
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    // Catch the DivideByZeroException and print out a message indicating that you cannot divide by zero.
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");

///////////////////// END SECTION //////////////////////////////////////