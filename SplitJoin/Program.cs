/*
// The following code takes a string, reverses it, and then joins each
// character into a new string separated by commas. The resulting string
// is then split back into an array of strings, and each string is written
// to the console.

string value = "abc123";

// Convert the string to a character array
char[] valueArray = value.ToCharArray();

// Reverse the order of the characters in the array
Array.Reverse(valueArray);

// Join each character in the array into a new string, using a comma as
// the separator. This produces a string like "3,2,1,c,b,a".
string result = String.Join(",", valueArray);

// Write the resulting string to the console
Console.WriteLine(result);

// Split the resulting string back into an array of strings, using a
// comma as the separator. This produces an array of strings like
// ["3", "2", "1", "c", "b", "a"].
string[] items = result.Split(',');

// Loop through the array of strings and write each one to the console
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

/*
string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);
*/
