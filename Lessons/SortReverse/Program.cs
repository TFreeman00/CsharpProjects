// create an array of strings, which will be used to demonstrate the
// Array.Sort() and Array.Reverse() methods
string[] pallets = { "B14", "A11", "B12", "A13" };

// display the contents of the array before it is sorted
Console.WriteLine("Sorted...");

// sort the array of strings in ascending order
Array.Sort(pallets);

// loop through the array and display each string
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Create a separator line to visually distinguish between the sorted
// and reversed array contents. This is just a visual aid to help
// us understand the output of our program.
Console.WriteLine("");
Console.WriteLine("Reversed...");

// Reverse the array of strings. This is a destructive operation, meaning
// that it changes the array in place. It does not return a new array, but
// rather modifies the original array. We can see the effects of this
// by looping through the array after the Array.Reverse() call.
Array.Reverse(pallets);

// Loop through the array and display each string. We're using a foreach
// loop here to iterate over the elements of the array. The variable
// "pallet" is a temporary variable that is assigned the value of each
// element of the array in turn.
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
