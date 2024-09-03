/*
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00
*/

// Output a letter to the user, using string interpolation to insert the customer's name,
// the name of the current product, the number of shares the customer owns, the percentage
// return of the current product, the name of the new product, the percentage return of the
// new product, and the profit the customer could make by switching to the new product.

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 63000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Output the greeting, using string interpolation to insert the customer's name.
Console.WriteLine($"Dear {customerName},");

// Output the introduction, using string interpolation to insert the name of the current
// product.
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

// Output the current product information, using string interpolation to insert the number
// of shares, the percentage return, and the profit.
Console.WriteLine($"Currently, you own {currentShares} shares at a return of {currentReturn:P}%.");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be {newProfit:C}.\n");

// Output the comparison header.
Console.WriteLine("Here's a quick comparison:\n");

// Create a string to hold the comparison message.
string comparisonMessage = "";

// Output the current product information, padded to a width of 20, and the return and profit
// padded to a width of 10 and 20, respectively.
comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += string.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += string.Format("{0:C}", currentProfit).PadRight(20);

// Output a newline.
comparisonMessage += "\n";

// Output the new product information, padded to a width of 20, and the return and profit
// padded to a width of 10 and 20, respectively.
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += string.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += string.Format("{0:C}", newProfit).PadRight(20);

// Output the comparison message.
Console.WriteLine(comparisonMessage);

