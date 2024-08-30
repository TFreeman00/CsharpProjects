///////////////////////// TARGET VALUE EXAMPLES ////////////////////////////

// This code snippet is all about finding the larger of two numbers using
// two different methods.

// The first method is using the Math.Max() method, which is a built-in
// method in the .NET framework. It takes two parameters, and returns the
// larger of the two. This is a much more concise way of doing things.

int firstValue = 500;
int secondValue = 600;
int largerValue;

// Use the Math.Max() method to get the larger of the two values
largerValue = Math.Max(firstValue, secondValue);

// The second method is using an if-else statement to compare the two
// values, and set the largerValue variable to the larger of the two.
// This is a more verbose way of doing things, but it's a good way to
// understand the logic of what's going on.

// if (firstValue > secondValue)
// {
//   largerValue = firstValue;
// } 
// else
// {
//   largerValue = secondValue;
// }

// Now that we have the larger value, let's print it out to the console
// using string interpolation.

Console.WriteLine($"The Larger value is {largerValue}");


////////////////////////// END SECTION //////////////////////////////////
