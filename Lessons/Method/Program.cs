/////////////////////// CALLING A METHOD //////////////////////////

// This code creates an array of integers and calls a method
// to print out the contents of the array.

// The array is created with the values 1, 2, 3, 4, and 5.
int[] a = {1,2,3,4,5};

// The code then prints out the contents of the array.
// The string "Contents of Array:" is printed out first
// to indicate what the following output is.
// Then the PrintArray() method is called, which prints out
// the contents of the array.
Console.WriteLine("Contents of Array:");
PrintArray();

// The PrintArray() method is defined below.
// It takes no parameters and simply prints out the
// contents of the array a.
void PrintArray()
{
    // This loop iterates over each element in the array.
    foreach (int x in a)
    {
        // For each element in the array, print out the value
        // followed by a space. The string interpolation syntax
        // is used to insert the value of x into the string.
        Console.Write($"{x} ");
    }
    // After all the elements have been printed out, print out
    // a newline to separate the output from any subsequent
    // output.
    Console.WriteLine();
}

////////////////////////////// END SECTION ///////////////////////////////////////


/////////////////////////////// METHOD EXECUTION ////////////////////////////////

// This code shows the order in which methods are called. The
// following code first prints out "Before calling a method" to
// the console, then calls the SayHello() method, and then prints
// out "After calling a method" to the console.

// Print out "Before calling a method" to the console.
Console.WriteLine("Before calling a method");

// Call the SayHello() method. This method is defined below.
// When it is called, it will print out "Hello World!" to the
// console.
SayHello();

// Print out "After calling a method" to the console.
Console.WriteLine("After calling a method");

// This is the definition of the SayHello() method. It takes no
// parameters and simply prints out "Hello World!" to the
// console.
void SayHello() 
{
    // Print out "Hello World!" to the console.
    Console.WriteLine("Hello World!");
}


////////////////////////// END SECTION //////////////////////////////////


//////////////// METHOD TO DISPLAY RANDOM NUMBERS //////////////////////////


// This code snippet prints out 5 random numbers between 1 and 100 inclusive
// It does this by calling the DisplayRandomNumbers() method, which is defined below
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

// This is the definition of the DisplayRandomNumbers() method
// It takes no parameters and simply prints out 5 random numbers
// between 1 and 100 inclusive to the console
void DisplayRandomNumbers() 
{
    // Create an instance of the Random class
    // This class is used to generate random numbers
    Random random = new Random();

    // Use a for loop to generate 5 random numbers
    // The loop will run 5 times
    for (int i = 0; i < 5; i++) 
    {
        // Generate a random number between 1 and 100 inclusive
        // The Next() method takes two parameters: the lower bound and the upper bound
        // The upper bound is exclusive, so we pass 101 to generate a number between 1 and 100
        int randomNumber = random.Next(1, 101);

        // Print out the random number to the console
        // The {randomNumber} is a placeholder that will be replaced by the actual random number
        Console.Write($"{randomNumber} ");
    }

    // After the loop is done, print a newline to the console
    // This is so that the output of the next code is on a new line
    Console.WriteLine();
}

////////////////////////////// END SECTION //////////////////////////////////
///

//////////////////////////// REUSABLE METHODS ///////////////////////////////


// This code is a program that takes two GMT values from the user and 
// then displays the current medicine schedule and then the new medicine
// schedule after adjusting it based on the difference between the two GMT
// values entered by the user.

// The times array stores the current medicine schedule
// with the times in 24-hour format (e.g. 800 for 8am, 1200 for 12pm, etc.)
int[] times = {800, 1200, 1600, 2000};

// The diff variable stores the difference between the two GMT values
// entered by the user. It will be used to adjust the times in the times
// array.
int diff = 0;

// The following code asks the user to enter the current GMT value
// and stores it in the currentGMT variable.
Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

// The following code displays the current medicine schedule by calling
// the DisplayTimes() method.
Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

// The following code asks the user to enter the new GMT value
// and stores it in the newGMT variable.
Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

// The following code checks if the absolute value of either the currentGMT
// or newGMT values are greater than 12. If so, it prints out an error
// message and exits the program.
if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else
{
    // The following code calculates the difference between the two GMT values
    // and stores it in the diff variable. It then calls the AdjustTimes()
    // method to adjust the times in the times array based on the difference.
    if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
        AdjustTimes();
    } 
    else 
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
        AdjustTimes();
    }

    // The following code displays the new medicine schedule by calling
    // the DisplayTimes() method.
    Console.WriteLine("New Medicine Schedule:");
    DisplayTimes();
}

// The DisplayTimes() method formats and displays the medicine times
// stored in the times array.
void DisplayTimes()
{
    // Loop through each element in the times array and format it
    // to display as a time of day (e.g. 800 becomes 8:00, 1200 becomes 12:00, etc.)
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        // If the length of the time is 3 or greater, insert a ":"
        // two positions from the end of the string to format it as a time.
        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        // If the length of the time is 2, insert a "0:" at the beginning
        // of the string to format it as a time.
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        // If the length of the time is less than 2, insert a "0:0" at the beginning
        // of the string to format it as a time.
        else
        {
            time = time.Insert(0, "0:0");
        }

        // Print out the formatted time string with a space at the end
        // (to separate it from the next time in the array).
        Console.Write($"{time} ");
    }
    // Print out a newline to separate the output from any subsequent
    // output.
    Console.WriteLine();
}

// The AdjustTimes() method takes the difference between the two GMT values
// and adjusts the times in the times array accordingly. It does this by
// adding the difference to each element in the array and then taking the
// modulus of 2400 to keep the values within 24 hours.
void AdjustTimes() 
{
    // Loop through each element in the times array and adjust it
    // by adding the difference and taking the modulus of 2400.
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
/////////////////////////// END SECTION //////////////////////////////////


