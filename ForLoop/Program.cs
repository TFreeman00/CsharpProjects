// Created a String
string[] names = {"Fizz", "Buzz, FizzBuzz"};

// Intitiating a Counter with the variable i counting to 100
for (int i = 1; i <= 101; i++)
{
  // An If Else Statement checking if (i) is devisible bny 3 and 5 if so it will print "FizzBuzz" etc...
  if((i % 3 == 0) && (i % 5 ==0))
  Console.WriteLine($"{i} - FizzBuzz");
  else if (i % 3 == 0)
  {
    Console.WriteLine($"{i} - Fizz");
  }
   else if (i % 5 == 0)
  {
    Console.WriteLine($"{i} - Buzz");
  }
  else
  Console.WriteLine($"{i}");

}
