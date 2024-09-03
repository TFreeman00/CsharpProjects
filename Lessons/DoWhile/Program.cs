/*The do-while statement iterates through a code block at least once, and might continue to iterate based on a Boolean expression. The evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block.
The while statement evaluates a Boolean expression first, and continues to iterate through the code block as long as the Boolean expression evaluates to true.
The continue keyword to step immediately to the Boolean expression. */ 

///////////////////////////////// DO WHILE EXAMPLES ///////////////////////////

// Simulate rolling a die until it lands on 7.
// When the die lands on 7, print the number and exit the loop.
// The loop will always execute at least once because the condition
// is evaluated after the loop body.
Random random = new Random();
int current = random.Next(1, 11);

do
{
    // Roll the die and store the result in current.
    current = random.Next(1, 11);
    // Print the result.
    Console.WriteLine(current);
} while (current != 7);

// Simulate rolling a die until it lands on 3 or less.
// When the die lands on 3 or less, print the number and exit the loop.
// The loop will only execute if the condition is true.
while (current >= 3)
{
    // Print the result.
    Console.WriteLine(current);
    // Roll the die and store the result in current.
    current = random.Next(1, 11);
}
// Print the last number that was rolled.
Console.WriteLine($"Last number: {current}");

//////////////////////////////// END SECTION ///////////////////////////////////

///////////////////////////////// HERO VS MONSTER ///////////////////////////////


// Hero vs Monster game
// The hero and monster will take turns
// rolling a die to attack each other
// until one of them reaches 0 health.

// Hero starts with 10 health
int hero = 10;

// Monster starts with 10 health
int monster = 10;

// Create a Random object to generate random numbers
Random dice = new Random();

// Continue the game until either the hero or monster reaches 0 health
do
{
    // Hero's turn
    int roll = dice.Next(1,11);
    Console.WriteLine($"Hero rolled a {roll}.");
    // Subtract the roll from the monster's health
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    // If the monster reaches 0 health, the hero wins and the game is over
    if (monster <= 0) continue;

    // Monster's turn
    roll = dice.Next(1,11);
    Console.WriteLine($"Monster rolled a {roll}.");
    // Subtract the roll from the hero's health
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now had {hero} health.");
} while (hero > 0 && monster > 0);

// Print out the winner
Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


/////////////////////////////// END SECTION ////////////////////////////////////

///////////////////////////////// READLINE EXAMPLES ////////////////////////////

// capture user input in a string variable named readResult

// If ReadLine needs to read an Int use try parse.

// Here, we're going to try to parse a user's input into an integer using
// the int.TryParse() method. The method takes two arguments: the first is
// the string to be parsed, and the second is the variable into which the
// parsed value will be stored. The return value of the method is a boolean
// indicating whether the parse was successful.
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);

// The code below is a loop that will continue to prompt the user for input
// until they enter a string that is at least two characters long. If the
// user enters a string with less than two characters, the loop will repeat.
// The variable validEntry is used to keep track of whether the user's input
// is valid or not.
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter Your name please:");
do
{
    // Read the user's input into the readResult variable
    readResult = Console.ReadLine();
    
    // If the user entered something (i.e., readResult is not null)
    if (readResult != null)
    {
        // If the length of the user's input is greater than or equal to 2
        if (readResult.Length >= 2)
        {
            // Set validEntry to true, indicating that the user's input is valid
            validEntry = true;
            // Print out a welcome message with the user's name
            Console.Write($"Welcome{result}");
        }
        
        // If the user's input is not valid (i.e., its length is less than 2)
        else
        {
            // Print out an error message asking the user to try again
            Console.WriteLine("Your name needs to be more than 2 letters please try again.");
        }
    }
}
// The loop will continue until the user enters valid input
while (validEntry == false);


////////////////////////////////// END SECTION //////////////////////////////

///////////////// PROJECT 1 ENTER A NUMBER BETWEEN 5 AND 10 ////////////////

// This loop will continue until the user enters a valid number between 5 and 10
do
{
    // Read the user's input into the readResult variable
    readResult = Console.ReadLine();

    // If the user entered something (i.e., readResult is not null)
    if (readResult != null) 
    {
        // Store the user's input in the valueEntered variable
        valueEntered = readResult;
    }

    // Try to convert the user's input to an integer using the int.TryParse() method
    validNumber = int.TryParse(valueEntered, out numValue);

    // If the conversion was successful, check if the number is within the valid range
    if (validNumber == true)
    {
        // If the number is not within the valid range, print an error message and set validNumber to false
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    // If the conversion failed, print an error message and set validNumber to false
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

// Once the user has entered a valid number, print out a message indicating that the input has been accepted
Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// Read the user's input again, but this time don't do anything with it
readResult = Console.ReadLine();


///////////////////////////////// END SECTION ///////////////////////////////

/////////// PROJECT 2 WRITE CODE THAT VALIDATES STRING INPUT/////////////////

// This loop will continue until the user enters a valid role name.
// The valid role names are: administrator, manager, and user.
do
{
    // Prompt the user to enter their role name
    Console.WriteLine("Enter your role name (administrator, manager, user)");
    // Read the user's input into the readResult variable
    readResult = Console.ReadLine();

    // If the user entered something (i.e., readResult is not null)
    if (readResult != null)
    {
        // Store the user's input in the roleName variable, 
        // after removing any leading or trailing whitespace
        roleName = readResult.Trim();
    }

    // Check if the user entered a valid role name
    if (roleName == "administrator" || roleName == "manager" || roleName == "user")
    {
        // If the user entered a valid role name, set validEntry to true
        validEntry = true;
    }
    else
    {
        // If the user entered an invalid role name, print an error message
        Console.WriteLine($"Role name you entered, \"{roleName}\" is not valid. Try again.");
    }
} while (validEntry == false);

// Once the user has entered a valid role name, print out a message indicating that the input has been accepted
Console.WriteLine($"Your role name, \"{roleName}\", has been accepted.");
// Read the user's input again, but this time don't do anything with it
readResult = Console.ReadLine();


////////////////////////////// END SECTION ///////////////////////////////////

///////////////////////// PROJECT 3 PIZZA ////////////////////////////////////

// Step through each string in the myStrings array
for (int i = 0; i < stringsCount; i++)
{
    // Store the current string in the myString variable
    myString = myStrings[i];

    // Find the position of the first period in the string
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // Step through each sentence in the string, one at a time
    while (periodLocation != -1)
    {
        // Extract the sentence that comes before the period
        mySentence = myString.Remove(periodLocation);

        // Remove the sentence that was just extracted from the string
        myString = myString.Substring(periodLocation + 1);

        // Remove leading whitespace from the remaining string
        myString = myString.TrimStart();

        // Find the position of the next period in the string
        periodLocation = myString.IndexOf(".");

        // Print the sentence that was just extracted
        Console.WriteLine(mySentence);
    }

    // Print the sentence that was left over, after all the other sentences were extracted
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

///////////////////////////////// END SECTION //////////////////////////////





