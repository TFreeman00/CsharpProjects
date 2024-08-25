

// Array of strings

string[] fraudulentOrdersIDs = new string[3];

fraudulentOrdersIDs[0] = "A123";
fraudulentOrdersIDs[1] = "B456";
fraudulentOrdersIDs[2] = "C789";
fraudulentOrdersIDs[3] = "D000";

string[] fraudulentOrdersIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrdersIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrdersIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrdersIDs[2]}");

fraudulentOrdersIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrdersIDs[0]}");

Console.WriteLine($"There are {fraudulentOrdersIDs.Length} fraudulent orders to process.");


// Looping through an array using foreach

string[] names = {"John", "Paul", "George", "Ringo"};
foreach (string name in names)

Console.WriteLine(name);

// Array of int
int[] inventory = {200, 450, 700,
175, 250};
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum}");
}
Console.WriteLine($"We have {sum} items in inventory.");


