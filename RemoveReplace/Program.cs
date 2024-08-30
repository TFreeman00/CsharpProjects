
// Use the Remove() method

// Use the Remove() method to delete a sequence of characters from the string.
// The Remove() method takes two parameters: the starting index and the number of characters to remove.
// In this example, the starting index is 5 and the number of characters to remove is 20.
// This will delete the substring from the 5th character to the 25th character (5 + 20 - 1).
// The resulting string is assigned to the updatedData variable and then output to the console.
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

//////////////////////////////////////////////////////////////////////////////


// Use the Replace() method

// The Replace() method is used to replace all occurrences of a specified string with another string. 
// In this example, we start with a string that has a bunch of extra hyphens and underscores in it. 
// We then use Replace() to replace all occurrences of "--" with a single space, and all occurrences of "-" with an empty string. 
// This effectively removes all the extra hyphens and underscores from the string. 
// The resulting string is then output to the console.
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
