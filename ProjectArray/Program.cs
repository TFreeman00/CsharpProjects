

//////////////////////////// ARRAY OF STRINGS //////////////////////////////////

// Declare an array of strings to hold the fraudulent order IDs
string[] fraudulentOrdersIDs = new string[3];

// Initialize the array with some sample values
fraudulentOrdersIDs[0] = "A123";
fraudulentOrdersIDs[1] = "B456";
fraudulentOrdersIDs[2] = "C789";

// The following line will throw an exception because the array is only 3 elements long and we're trying to access the 4th element
//fraudulentOrdersIDs[3] = "D000";

// Alternatively, we can create an array of strings and initialize it with the same values all at once
string[] fraudulentOrdersIDs2 = {"A123", "B456", "C789"};

// Now we can print out the values of the array to see what's inside
Console.WriteLine($"First: {fraudulentOrdersIDs2[0]}");
Console.WriteLine($"Second: {fraudulentOrdersIDs2[1]}");
Console.WriteLine($"Third: {fraudulentOrdersIDs2[2]}");

// We can also reassign a value in the array
fraudulentOrdersIDs2[0] = "F000";

// And print out the new value to see that it's been reassigned
Console.WriteLine($"Reassign First: {fraudulentOrdersIDs2[0]}");

// Finally, we can print out the length of the array to see how many elements are in it
Console.WriteLine($"There are {fraudulentOrdersIDs2.Length} fraudulent orders to process.");


// Looping through an array using foreach

// Here, we're declaring an array of strings and initializing it with four strings representing the names of the Beatles
string[] names = {"John", "Paul", "George", "Ringo"};

// Next, we're looping through the array using a foreach, and printing out each name
foreach (string name in names)
{
    // Simply print the name to the console
    Console.WriteLine(name);
}

// Now, we're declaring an array of integers and initializing it with five integers representing the number of items in inventory
int[] inventory = {200, 450, 700, 175, 250};

// We're declaring a variable to keep track of the running total of items in inventory
int sum = 0;

// We're declaring a variable to keep track of which bin we're currently processing
int bin = 0;

// Next, we're looping through the array using a foreach, and performing some operations on each element
foreach (int items in inventory)
{
    // Add the current number of items to the running total
    sum += items;

    // Increment the bin number
    bin++;

    // Print out the current bin number, the number of items in the current bin, and the running total
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum}");
}

// Finally, we're printing out the total number of items in inventory
Console.WriteLine($"We have {sum} items in inventory.");

////////////////////////// END SECTION //////////////////////////////////

