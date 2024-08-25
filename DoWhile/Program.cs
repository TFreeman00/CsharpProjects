/*The do-while statement iterates through a code block at least once, and might continue to iterate based on a Boolean expression. The evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block.
The while statement evaluates a Boolean expression first, and continues to iterate through the code block as long as the Boolean expression evaluates to true.
The continue keyword to step immediately to the Boolean expression. */ 

// DO WHILE EXAMPLES
/*
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");*/

// END SECTION

// HERO VS MONSTER

/*
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
int roll = dice.Next(1,11);
monster -= roll;
Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

if (monster <= 0) continue;

roll = dice.Next(1,11);
hero -= roll;
Console.WriteLine($"Hero was damaged and lost {roll} health and now had {hero} health.");
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/

// END SECTION

// READLINE EXAMPLES

// capture user input in a string variable named readResult
/*
// If ReadLine needs to read an Int use try parse.

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
*/
/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter Your name please:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 2)
        {
            validEntry = true;
            Console.Write($"Welcome{result}");
        }
        
        else
        {
            Console.WriteLine("Your name needs to be more than 2 letters please try again.");
        }
    }
} while (validEntry == false);
*/

// END SECTION

// PROJECT 1 ENTER A NUMBER BETWEEN 5 AND 10

/*
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/

// END SECTION

// PROJECT 2 WRITE CODE THAT VALIDATES STRING INPUT
/*
string? readResult;
string roleName = "";
bool validEntry = false;

do{
    Console.WriteLine("Enter your role name (administrator, manager, user)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
       roleName = readResult.Trim();
    }

    if (roleName == "administrator" || roleName == "manager" || roleName == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"Role name you entered, \"{roleName}\" is not valid. Try again.");
    }
} while (validEntry == false);

Console.WriteLine($"Your role name, \"{roleName}\", has been accepted.");
readResult = Console.ReadLine();
*/

// END SECTION

// PROJECT 3 PIZZA

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}

// END SECTION





