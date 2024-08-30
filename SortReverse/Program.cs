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

// create a separator line to visually distinguish between the sorted and
// reversed array contents
Console.WriteLine("");
Console.WriteLine("Reversed...");

// reverse the array of strings
Array.Reverse(pallets);

// loop through the array and display each string
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
