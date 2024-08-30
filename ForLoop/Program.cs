// Created an array of strings
string[] names = {"Fizz", "Buzz, FizzBuzz"};

// Intitiating a Counter with the variable i counting to 100
for (int i = 1; i <= 101; i++)
{
  // An If Else Statement checking if the current number (i) is divisible by 3 and 5
  if((i % 3 == 0) && (i % 5 ==0))
  {
    // If the number is divisible by both 3 and 5, print the number and append " - FizzBuzz"
    Console.WriteLine($"{i} - FizzBuzz");
  }
  else if (i % 3 == 0)
  {
    // If the number is only divisible by 3, print the number and append " - Fizz"
    Console.WriteLine($"{i} - Fizz");
  }
   else if (i % 5 == 0)
  {
    // If the number is only divisible by 5, print the number and append " - Buzz"
    Console.WriteLine($"{i} - Buzz");
  }
  else
  {
    // If the number is not divisible by either 3 or 5, just print the number
    Console.WriteLine($"{i}");
  }

}
