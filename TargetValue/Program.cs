

int firstValue = 500;
int secondValue = 600;
int largerValue;
// quicker method via Math.Max
largerValue = Math.Max(firstValue, secondValue);

// longer method via if else
// if (firstValue > secondValue)
// {
//   largerValue = firstValue;
// } 
// else
// {
//   largerValue = secondValue;
// }




Console.WriteLine($"The Larger value is {largerValue}");