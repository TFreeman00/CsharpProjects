////////////////////////// REVERSE AND SPLIT //////////////////////////////

// The following code takes a string, reverses it, and then joins each
// character into a new string separated by commas. The resulting string
// is then split back into an array of strings, and each string is written
// to the console.

// Step 1: Convert the string to a character array
// The ToCharArray() method is used to convert the string to a character
// array. This is necessary because the Array.Reverse() method (which is
// used in the next step) requires an array as its parameter.
char[] valueArray = value.ToCharArray();

// Step 2: Reverse the order of the characters in the array
// The Array.Reverse() method is used to reverse the order of the
// characters in the array. This effectively reverses the string.
Array.Reverse(valueArray);

// Step 3: Join each character in the array into a new string, using a
// comma as the separator. This produces a string like "3,2,1,c,b,a".
// The String.Join() method is used to join each character in the array
// into a new string. The first parameter of the method is the separator
// character (in this case, a comma), and the second parameter is the
// array of characters to be joined.
string result = String.Join(",", valueArray);

// Step 4: Write the resulting string to the console
// The resulting string is then written to the console using the
// Console.WriteLine() method.
Console.WriteLine(result);

// Step 5: Split the resulting string back into an array of strings, using
// a comma as the separator. This produces an array of strings like
// ["3", "2", "1", "c", "b", "a"].
// The Split() method is used to split the resulting string back into an
// array of strings. The parameter to the method is the separator
// character (in this case, a comma).
string[] items = result.Split(',');

// Step 6: Loop through the array of strings and write each one to the console
// The foreach loop is used to loop through the array of strings and write
// each one to the console using the Console.WriteLine() method.
foreach (string item in items)
{
    Console.WriteLine(item);
}
 //////////////////////////// END SECTION //////////////////////////////////

/////////////////////////// SPLIT AND REVERSE //////////////////////////////
// Step 1: Split the pangram string into an array of strings, using a
// space as the separator. This produces an array of strings like
// ["The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"].
string[] message = pangram.Split(' ');

// Step 2: Create a new array of strings that will hold the reversed
// strings. The length of the new array is the same as the length of
// the message array.
string[] newMessage = new string[message.Length];

// Step 3: Loop through the message array and reverse each string. The
// reversed string is then added to the newMessage array.
for (int i = 0; i < message.Length; i++)
{
    // Reverse the string by converting it to a character array and
    // using the Array.Reverse() method.
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);

    // Convert the reversed character array back into a string and
    // add it to the newMessage array.
    newMessage[i] = new string(letters);
}

// Step 4: Join each string in the newMessage array into a new string,
// using a space as the separator. This produces a string like
// "The reverse quick brown fox jumps over the lazy dog".
string result = String.Join(" ", newMessage);

// Write the resulting string to the console.
Console.WriteLine(result);

////////////////////////// END SECTION //////////////////////////////////
