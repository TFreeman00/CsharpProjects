
// We start with this input string, which contains a trademark symbol (&trade;)
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";


// We want to extract the "quantity" from the input string, which is the
// text between the <span> and </span> tags.
string quantity = "";
const string openSpan = "<span>";
const string closeSpan = "</span>";


// Find the position of the opening <span> tag in the input string
int quantityStart = input.IndexOf(openSpan) + openSpan.Length;
// Find the position of the closing </span> tag in the input string
int quantityEnd = input.IndexOf(closeSpan);
// Calculate the length of the substring between the opening and closing tags
int quantityLength = quantityEnd - quantityStart;
// Extract the substring from the input string and store it in the quantity variable
quantity = input.Substring(quantityStart, quantityLength);
// Add "Quantity: " to the beginning of the extracted substring
quantity = $"Quantity: {quantity}";


// We want to create a new string, output, which is the input string with
// the trademark symbol replaced with the registered trademark symbol (&reg;)
string output = input;
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
// Replace the trademark symbol with the registered trademark symbol
output = output.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag from the output string
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag from the output string and add "Output: " to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

// Print the extracted quantity and the modified output string to the console
Console.WriteLine(quantity);
Console.WriteLine(output);
