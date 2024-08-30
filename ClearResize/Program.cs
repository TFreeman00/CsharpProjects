// create an array of strings, which will be used to demonstrate the
// Array.Clear(), Array.Resize() methods
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

// clear the first 2 elements of the array
Array.Clear(pallets, 0, 2);
// this will set the first 2 elements of the array to the default value for the type, which is null for strings
// the Array.Clear() method does not change the length of the array
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// print the contents of the array to show the effect of Array.Clear()
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
// resize the array to have a length of 6
Array.Resize(ref pallets, 6);
// this will change the length of the array, and the new elements will be set to the default value for the type, which is null for strings
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// set the last 2 elements of the array to a value
pallets[4] = "C01";
pallets[5] = "C02";

// print the contents of the array to show the effect of Array.Resize() and setting values
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
// resize the array to have a length of 3
Array.Resize(ref pallets, 3);
// this will change the length of the array, and the elements that were beyond the new length will be lost
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// print the contents of the array to show the effect of Array.Resize()
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
