

//////////////////////////////// INDEXOF //////////////////////////////////
// Get the string to parse
string message = "Find what is (inside the parentheses)";

// Find the position of the opening parenthesis in the message
int openingPosition = message.IndexOf('(');

// Find the position of the closing parenthesis in the message
int closingPosition = message.IndexOf(')');

// We don't want to include the opening parenthesis in the result, so we add 1 to the opening position
openingPosition += 1;

// Calculate the length of the string between the parentheses by subtracting the opening position from the closing position
int length = closingPosition - openingPosition;

// Use the Substring method to extract the text between the parentheses, using the calculated length and position as arguments
Console.WriteLine(message.Substring(openingPosition, length));


// Set the message to be parsed
string message = "What is the value <span>between the tags</span>?";
 
// Define the opening and closing tags to be searched for
const string openSpan = "<span>";
const string closeSpan = "</span>";
 
// Find the position of the opening tag in the message
int openingPosition = message.IndexOf(openSpan);
 
// Find the position of the closing tag in the message
int closingPosition = message.IndexOf(closeSpan);
 
// Calculate the length of the string between the tags by subtracting the opening
// position from the closing position, and then subtracting the length of the
// opening tag itself (since we don't want to include it in the result)
int length = closingPosition - (openingPosition + openSpan.Length);
 
// Use the Substring method to extract the text between the tags, using the
// calculated length and position as arguments
string result = message.Substring(openingPosition + openSpan.Length, length);
 
// Print the result to the console
Console.WriteLine(result);

////////////////////////////// END SECTION ///////////////////////////////////////

////////////////////// INDEXOF() and LASTINDEXOF() ////////////////////////////////
// LastIndexOf() is used to find the position of the last occurrence of a substring within a string.
// In this case, we want to find the last occurrence of an opening parenthesis.
string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

// Now that we have the position of the last occurrence of an opening parenthesis,
// we add 1 to it so that we start at the character after the opening parenthesis.
openingPosition += 1;

// Now we use LastIndexOf() again to find the position of the last occurrence of a closing parenthesis.
int closingPosition = message.LastIndexOf(')');

// Now we calculate the length of the text between the last occurrence of an opening parenthesis
// and the last occurrence of a closing parenthesis. We do this by subtracting the opening position
// from the closing position.
int length = closingPosition - openingPosition;

// Finally, we use the Substring() method to extract the text between the last occurrence of an opening
// parenthesis and the last occurrence of a closing parenthesis.
Console.WriteLine(message.Substring(openingPosition, length));

///////////////////////////////////////////////////////////////////////////////                      
// Retrieve all instances of substrings inside parentheses
// Retrieve all instances of substrings inside parentheses
// We will loop through the message and pull out all the substrings between the
// parentheses. We will do this until there are no more opening parentheses left
// in the message.
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    // Find the position of the next opening parenthesis in the message
    int openingPosition = message.IndexOf('(');

    // If there are no more opening parentheses left, then we can exit the loop.
    if (openingPosition == -1) break;

    // Move the opening position one character to the right so that we don't
    // include the opening parenthesis itself in the substring.
    openingPosition += 1;

    // Find the position of the next closing parenthesis in the message
    int closingPosition = message.IndexOf(')');

    // Calculate the length of the substring between the opening parenthesis and
    // the closing parenthesis.
    int length = closingPosition - openingPosition;

    // Print the substring between the parentheses to the console.
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message. This is how we move the "window" of the substring
    // to the right one substring at a time. We do this by starting the
    // substring at the position after the closing parenthesis we just
    // processed.
    message = message.Substring(closingPosition + 1);
}
////////////////////////////// END SECTION //////////////////////////////////////

//////////////////////// WORK WITH DIFFERENT SYMBOLS ///////////////////////////


string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}


//////////////////////////////// END SECTION /////////////////////////////////////