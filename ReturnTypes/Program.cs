
//////////////////////////// CALCULATE TOTAL PURCHASES ////////////////////////////

/////////////////////////////// CALCULATE TOTAL PURCHASES //////////////////////////
//
// This code calculates the total cost of a purchase by looping through an array of items
// and applying a discount to each one. The total is then compared to a minimum spend, and
// if the total is greater than or equal to the minimum, a $5.00 discount is applied.
//
// The total is then formatted and printed to the console.

// The total cost of the purchase, including discounts and any additional discount for meeting the minimum spend.
double total = 0;

// The minimum amount that must be spent to qualify for a $5.00 discount.
double minimumSpend = 30.00;

// An array of the prices of the items being purchased.
double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };

// An array of the discounts to apply to each item.
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

// Loop through each item in the items array and apply the corresponding discount to the total.
for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

// If the total meets or exceeds the minimum spend, subtract $5.00.
total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Print the total, formatted to two decimal places.
Console.WriteLine($"Total: ${FormatDecimal(total)}");

// A method to calculate the discounted price of an item.
double GetDiscountedPrice(int itemIndex)
{
    // The discounted price is the price of the item multiplied by (1 - the discount percentage).
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

// A method to determine if the total meets the minimum spend.
bool TotalMeetsMinimum()
{
    // The total meets the minimum if it is greater than or equal to the minimum spend.
    return total >= minimumSpend;
}

// A method to format a double to a string with two decimal places.
string FormatDecimal(double input)
{
    // The Substring method returns a subset of the string, starting at the first character and continuing for the specified number of characters.
    // In this case, we want to return the first 5 characters of the string, which will be the number with two decimal places.
    return input.ToString().Substring(0, 5);
}


///////////////////////////// END SECTION /////////////////////////////////////////

//////////////////////////// CONVERT USD TO VND //////////////////////////////////

// This code is used to convert US Dollars to Vietnamese Dong and vice versa
// The exchange rate is fixed at 1 USD = 23,500 VND

// First, we define a variable to hold the amount of USD we want to convert
double usd = 23.73;

// Then, we call the UsdToVnd() method to convert the USD to VND
// The UsdToVnd() method takes a double as an argument, which is the amount of USD to convert
// The UsdToVnd() method returns an int, which is the amount of VND that the USD is worth
int vnd = UsdToVnd(usd);

// We then print out the result of the conversion to the console
// The first part of the output is the amount of USD we started with, and the amount of VND it is worth
// The second part of the output is the amount of VND we got from the conversion, and the amount of USD it is worth
Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// The UsdToVnd() method is defined below
// It takes a double as an argument, which is the amount of USD to convert
// It returns an int, which is the amount of VND that the USD is worth
int UsdToVnd(double usd) 
{
    // The exchange rate is fixed at 1 USD = 23,500 VND
    int rate = 23500;

    // We convert the USD to VND by multiplying the USD by the exchange rate
    // We cast the result to an int because the exchange rate is an int
    return (int) (rate * usd);
}

// The VndToUsd() method is defined below
// It takes an int as an argument, which is the amount of VND to convert
// It returns a double, which is the amount of USD that the VND is worth
double VndToUsd(int vnd) 
{
    // The exchange rate is fixed at 1 USD = 23,500 VND
    double rate = 23500;

    // We convert the VND to USD by dividing the VND by the exchange rate
    // We cast the result to a double because the exchange rate is a double
    return vnd / rate;
}

///////////////////////////// END SECTION /////////////////////////////////////////

////////////////////////////// TEST WITH STRINGS ///////////////////////////////

// This code takes a string, splits it into words, reverses each word, and puts it back together into a sentence.
// The output is a string that is the input string, but with each word reversed.

// The input is the string "there are snakes at the zoo"
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

// The ReverseSentence function takes a string as an argument, and returns a string that is the input string, but with each word reversed.
// It does this by splitting the string into words, reversing each word, and then putting all the words back together into a sentence.
string ReverseSentence(string input) 
{
    // The variable result is an empty string that will be used to build up the output string
    string result = "";
    // The variable words is an array of strings that will be used to hold the individual words from the input string
    string[] words = input.Split(" ");
    // The foreach loop iterates over each word in the words array, and for each word it reverses the word and adds it to the result string.
    foreach(string word in words) 
    {
        // The ReverseWord function takes a string as an argument, and returns a string that is the input string, but with the characters reversed.
        // It does this by creating an empty string, and then iterating over the characters of the input string in reverse order, adding each character to the result string.
        result += ReverseWord(word) + " ";
    }
    // After the foreach loop has finished, the result string is returned, but with any trailing spaces removed using the Trim() method.
    return result.Trim();
}

// The ReverseWord function takes a string as an argument, and returns a string that is the input string, but with the characters reversed.
// It does this by creating an empty string, and then iterating over the characters of the input string in reverse order, adding each character to the result string.
string ReverseWord(string word) 
{
    // The variable result is an empty string that will be used to build up the output string
    string result = "";
    // The for loop iterates over the characters of the input string in reverse order, starting from the last character and moving backwards to the first character.
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        // The result string is built up by adding the current character from the input string to the end of the result string.
        result += word[i];
    }
    // After the for loop has finished, the result string is returned.
    return result;
}

////////////////////////////// END SECTION /////////////////////////////////////////

/////////////////////// RETURN IS PALINDROME(BOOLEAN) ///////////////////////////////

// This code will take an array of strings, and loop through each string to
// determine if it is a palindrome. A palindrome is a word, phrase, or sequence
// that reads the same backward as it does forward.

// The array of strings is hard-coded, but it could be passed in as an argument
// instead.
string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

// This loop will iterate over each string in the array, and print out
// whether or not it is a palindrome.
Console.WriteLine("Is it a palindrome?");

foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

// This function takes a string as an argument, and returns a boolean value
// indicating whether or not the string is a palindrome.
bool IsPalindrome(string word) 
{
    // The start variable is an integer that keeps track of the current position
    // in the string that we are checking. It starts at the beginning of the
    // string (index 0).
    int start = 0;

    // The end variable is an integer that keeps track of the current position
    // in the string that we are checking. It starts at the last character in
    // the string (index word.Length - 1).
    int end = word.Length - 1;

    // This while loop will continue to run until the start and end indices meet
    // in the middle of the string.
    while (start < end) 
    {
        // If the character at the start index is not equal to the character at
        // the end index, then the string is not a palindrome, and we can return
        // false.
        if (word[start] != word[end]) 
        {
            return false;
        }

        // If the characters at the start and end indices are equal, then we
        // can move the start index one position to the right, and the end index
        // one position to the left.
        start++;
        end--;
    }

    // If the loop finishes without finding any characters that are not equal,
    // then the string is a palindrome, and we can return true.
    return true;
}

///////////////////////// END SECTION //////////////////////////////////////////

/////////////////// FIND COINS TO MAKE CHANGE /////////////////////////////////////


// This program will find two coins in the coins array that add up to the target amount.
// If no two coins add up to the target, the program will print "No two coins make change".
// Otherwise, it will print out the positions of the two coins in the array that make up the target amount.
//
// The coins array is a list of coin values, and the target is the amount of money we want to make change for.
int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};

// The result array is a two-dimensional array that will hold the positions of the two coins that make up the target amount.
// The first element of each row is the position of the first coin, and the second element of each row is the position of the second coin.
// If no two coins make up the target amount, the result array will be empty.
int[,] result = TwoCoins(coins, target);

// If the result array is empty, print "No two coins make change".
// Otherwise, print out the positions of the two coins that make up the target amount.
if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        // If the first element of the row is -1, then there are no more valid combinations of coins that make up the target amount.
        if (result[i,0] == -1) 
        {
            break;
        }
        // Print out the positions of the two coins that make up the target amount.
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

// This function takes the coins array and the target amount, and returns the result array.
int[,] TwoCoins(int[] coins, int target) 
{
    // The result array is a two-dimensional array that will hold the positions of the two coins that make up the target amount.
    int[,] result = new int[coins.Length, 2];
    int count = 0;

    // This loop will iterate over the coins array and find all combinations of two coins that add up to the target amount.
    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {    
            // If the current coin and the next coin add up to the target amount, then add the positions of the two coins to the result array.
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            // If the result array is full, then we have found all the combinations of two coins that add up to the target amount.
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    // If we haven't found any combinations of two coins that add up to the target amount, then return an empty array.
    return (count == 0) ? new int[0,0] : result;
}

//////////////////////// END SECTION //////////////////////////////////////////


