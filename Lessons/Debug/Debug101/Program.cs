/*
Compiler-generated exceptions are thrown by the .NET runtime when basic operations fail. 

Here's a short list of runtime exceptions and their error conditions:

ArrayTypeMismatchException: This exception is thrown when an array can't store a given element because the actual type of the element is incompatible with the actual type of the array. This can happen when you have an array of type A and you try to store an element of type B in it, where A and B are not the same type.

DivideByZeroException: This exception is thrown when an attempt is made to divide an integral value by zero. This is a special case of the OverflowException, but it's so common that it has its own exception type.

FormatException: This exception is thrown when the format of an argument is invalid. This can happen when you pass a string to a method that expects the string to be in a specific format, like a date or a number in a specific format.

IndexOutOfRangeException: This exception is thrown when an attempt is made to index an array when the index is less than zero or outside the bounds of the array. This can happen when you have an array of 10 elements and you try to access the 11th element.

InvalidCastException: This exception is thrown when an explicit conversion from a base type to an interface or to a derived type fails at runtime. This can happen when you have a base class and a derived class, and you try to cast an instance of the base class to the derived class.

NullReferenceException: This exception is thrown when an attempt is made to reference an object whose value is null. This can happen when you have a variable that is supposed to hold a reference to an object, but the object hasn't been created yet.

OverflowException: This exception is thrown when an arithmetic operation in a checked context overflows. This can happen when you have a variable of type int and you try to add a number to it that is larger than the maximum value of an int.
*/

//////////////////// ARRAY TYPE MISMATCH EXCEPTION /////////////////////////
///
// Create an array of strings
string[] names = { "Dog", "Cat", "Fish" };

// Cast the array of strings to an array of objects
Object[] objs = (Object[])names;

// Create an object that is an integer
Object obj = (Object)13;

// Try to put the integer object into the array of objects
// this will throw an ArrayTypeMismatchException because
// the array was originally created as an array of strings
objs[2] = obj; // ArrayTypeMismatchException

//////////////////////////////// END SECTION //////////////////////////////
///
/////////////////// DIVIDE BY ZERO EXCEPTION /////////////////////////////

// This code is going to throw a DivideByZeroException because
// we're trying to divide the number 3000 by zero.
//
// The DivideByZeroException is thrown when an attempt is made to
// divide an integral or decimal value by zero.
//
// In this case, we have an integer variable (number2) that is set to
// zero, and we're trying to divide another integer variable (number1)
// by it. This will throw a DivideByZeroException because dividing
// by zero is undefined in mathematics.
//
// The output of this code will be an error message that says
// "DivideByZeroException: Attempted to divide by zero."

int number1 = 3000;
int number2 = 0;
try
{
    Console.WriteLine(number1 / number2); // DivideByZeroException occurs
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("DivideByZeroException: Attempted to divide by zero.");
}

///////////////////////////////// END SECTION //////////////////////////////
///
///////////////////// FORMAT EXCEPTION /////////////////////////////////

// This code is going to throw a FormatException because we're trying
// to use the int.Parse() method to convert a string to an integer.
//
// The int.Parse() method takes a string argument, which is the string
// that we want to convert to an integer. In this case, we're passing
// the string "two", which is not a valid integer.
//
// When we try to convert the string "two" to an integer using the
// int.Parse() method, the method will throw a FormatException because
// the string "two" is not a valid integer format.
//
// The FormatException is thrown when the format of a string is
// invalid, or does not match the expected format. In this case, the
// string "two" does not match the expected format of an integer, so
// the FormatException is thrown.
//
// The output of this code will be an error message that says
// "FormatException: Input string was not in a correct format."

int valueEntered;
string userValue = "two";
try
{
    valueEntered = int.Parse(userValue); // FormatException occurs
}
catch (FormatException ex)
{
    Console.WriteLine("FormatException: Input string was not in a correct format.");
}

///////////////////////////////// END SECTION //////////////////////////////
///
/////////////////// INDEX OUT OF RANGE EXCEPTION /////////////////////////

// This code is going to throw an IndexOutOfRangeException when it is run.
// The IndexOutOfRangeException is thrown when an array is accessed with an index that is outside the bounds of the array.
// In this case, we're trying to access the seventh element of the values2 array, which is out of bounds because the array only has six elements.
// The values2 array is declared with a length of 6, so it has elements at indices 0 through 5. When we try to access the element at index 6, the IndexOutOfRangeException is thrown.

int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

// The values1 array has 7 elements, and we're trying to access the seventh element here.
// The values2 array, on the other hand, only has 6 elements, so this will throw an IndexOutOfRangeException.
values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs

///////////////////////////////// END SECTION //////////////////////////////
///
/////////////////// INVALID CAST EXCEPTION //////////////////////////////

// This code is going to throw an InvalidCastException when it is run.
// The InvalidCastException is thrown when you try to cast an object to a type that it is not compatible with.
// In this case, we are trying to cast a string to an integer, which is not allowed.
// The (int) cast will attempt to convert the value of obj to an integer, but since the value of obj is a string, this will throw an exception.

object obj = "This is a string"; // obj is a string
int num = (int)obj; // This will throw an InvalidCastException because you can't cast a string to an int.

///////////////////////////////// END SECTION //////////////////////////////
///
/////////////////// NULL REFERENCE EXCEPTION /////////////////////////////

// This code will throw a NullReferenceException when it is run.
// The NullReferenceException is thrown when a null object reference is used in a way that requires it to have a value.
// In this case, we're trying to access the elements of the values array, but we haven't initialized the array yet.
int[] values = null;
for (int i = 0; i <= 9; i++)
{
    // When we try to access the element at index i, the NullReferenceException will be thrown.
    // This is because the values array is null, and we can't access an element of a null array.
    values[i] = i * 2;
}

// This code will also throw a NullReferenceException when it is run.
// The NullReferenceException is thrown when a null object reference is used in a way that requires it to have a value.
// In this case, we're trying to call the ToUpper() method on the lowCaseString variable, but we haven't initialized the variable yet.
string? lowCaseString = null;
try
{
    Console.WriteLine(lowCaseString.ToUpper());
}
catch (NullReferenceException ex)
{
    Console.WriteLine("NullReferenceException: " + ex.Message);
}

///////////////////////////////// END SECTION //////////////////////////////
///
/////////////////// OVERFLOW EXCEPTION /////////////////////////////////

// In this example, we're going to assign a decimal value to a byte variable.
// The decimal value is 400, and the byte variable is i.
// The cast will cause an OverflowException because the value of 400 is too large to fit in a byte.
// The maximum value that a byte can hold is 255, so trying to assign a value larger than that will cause an exception.
decimal x = 400;
byte i;

try
{
    i = (byte)x; // This line will cause an OverflowException
    Console.WriteLine(i); // This line will never be reached because the exception will be thrown on the line above
}
catch (OverflowException ex)
{
    Console.WriteLine("OverflowException: " + ex.Message);
}

///////////////////////////////// END SECTION //////////////////////////////