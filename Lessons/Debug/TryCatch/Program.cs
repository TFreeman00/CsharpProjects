////////////////////// TRY CATCH EXAMPLE /////////////////////////////////
///


try
{
    // Call the Process1() function, which will call the WriteMessage() function.
    // The WriteMessage() function will attempt to divide two numbers, which will throw an exception.
    // The exception will be caught by the catch block.
    Process1();
}
catch
{
    // This catch block will catch any exceptions that are thrown by the Process1() function.
    // The exception will be caught, and the message "An exception has occurred" will be printed to the console.
    Console.WriteLine("An exception has occurred");
}

// This line will be printed after the exception has been caught and handled.
Console.WriteLine("Exit program");

// This function will be called by the try block above.
static void Process1()
{
    // This function will call the WriteMessage() function, which will attempt to divide two numbers.
    // The division will throw an exception, which will be caught by the catch block above.
    WriteMessage();
}

// This function will be called by the Process1() function above.
static void WriteMessage()
{
    // Declare two double variables, float1 and float2, and set them to 3000.0 and 0.0, respectively.
    double float1 = 3000.0;
    double float2 = 0.0;

    // Declare two int variables, number1 and number2, and set them to 3000 and 0, respectively.
    int number1 = 3000;
    int number2 = 0;

    // Attempt to divide float1 by float2, which will throw an exception because float2 is zero.
    // The exception will be caught by the catch block above.
    Console.WriteLine(float1 / float2);

    // Attempt to divide number1 by number2, which will throw an exception because number2 is zero.
    // The exception will be caught by the catch block above.
    Console.WriteLine(number1 / number2);
}

///////////////////////////////// END SECTION //////////////////////////////
///
