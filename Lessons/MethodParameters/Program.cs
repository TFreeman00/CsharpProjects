
////////////////////////////// METHOD PARAMETERS ////////////////////////////

int[] schedule = {800, 1200, 1600, 2000};

// This function takes an array of times in 24-hour format and two GMT values
// and prints out the times adjusted for the difference between the two GMT values
//
// The times array is an array of integers, where each integer is a time in 24-hour
// format (e.g. 800 for 8am, 1200 for 12pm, etc.)
//
// The currentGMT and newGMT parameters are integers that represent the GMT (Greenwich Mean Time)
// values that we want to adjust the times for. The GMT values are in hours, but they can be positive
// or negative. A positive GMT value means that the time is ahead of GMT, while a negative GMT value
// means that the time is behind GMT.
//
// For example, if currentGMT is 6 and newGMT is -6, this means that the current times are 6 hours
// ahead of GMT, and we want to adjust them to be 6 hours behind GMT.
void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
{
    int diff = 0;

    // Check if either the currentGMT or newGMT are invalid (greater than 12)
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else
    {
        // Calculate the difference between the two GMT values in minutes
        if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
        {
            // If both GMT values are positive or both are negative, subtract the absolute values
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
        } 
        else 
        {
            // If the GMT values have different signs, add the absolute values
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
        }

        // Adjust the times in the times array by adding the difference to each element
        for (int i = 0; i < times.Length; i++) 
        {
            int newTime = ((times[i] + diff)) % 2400;
            Console.WriteLine($"{times[i]} -> {newTime}");
        }
    }
}

// Example usage: adjust the times in the schedule array from GMT 6 to GMT -6
DisplayAdjustedTimes(schedule, 6, -6);


////////////////////////////// END SECTION //////////////////////////////////


/////////////////////////// METHOD SCOPE //////////////////////////////////

// This code takes an array of strings, where each string is a student name.
// It then loops through each element in the array and prints out the value
// of the element to the console.
// After all the elements have been printed out, it prints out a newline to
// separate the output from any subsequent output.
string[] students = {"Jenna", "Sarah", "Samantha", "Choy"};

// Call the DisplayStudents() method with the students array as an argument.
// This will print out each student name in the array to the console.
DisplayStudents(students);

// Create a new string array containing the names "Robert" and "Katie".
// Call the DisplayStudents() method with this new array as an argument.
// This will print out each of the names in the new array to the console.
DisplayStudents(new string[] {"Robert", "Katie"});

// This is the method definition for the DisplayStudents() method.
// It takes an array of strings as its argument.
// The method loops through each element in the array and prints out the
// value of the element to the console.
// After all the elements have been printed out, it prints out a newline to
// separate the output from any subsequent output.
void DisplayStudents(string[] students)
{
    // Loop through each element in the array.
    foreach (string student in students)
    {
        // For each element in the array, print out the value of the element
        // to the console. The string interpolation syntax is used to insert
        // the value of the element into the string.
        Console.WriteLine($"{student}");
    }
    // After all the elements have been printed out, print out a newline to
    // separate the output from any subsequent output.
    Console.WriteLine();
}


////////////////////////////// END SECTION //////////////////////////////////

////////////////////////////// CERCUMFERENCE //////////////////////////////////

// This code is used to calculate the area and circumference of a circle with a given radius. It makes use of the constant pi, which is a mathematical constant that is used to calculate the ratio of a circle's circumference to its diameter.

// The first line of the code sets the value of pi to 3.14159, which is an approximation of the mathematical constant pi.

// The second and third lines of the code call the PrintCircleInfo function with the arguments 12 and 24, respectively. This function prints out information about a circle with the given radius.

// The PrintCircleInfo function takes an integer argument representing the radius of the circle, and prints out the area and circumference of the circle with that radius. The function calls two other functions, PrintCircleArea and PrintCircleCircumference, to calculate the area and circumference of the circle, respectively.

// The PrintCircleArea function takes an integer argument representing the radius of the circle, and calculates the area of the circle using the formula pi * (radius * radius). The function then prints out the calculated area.

// The PrintCircleCircumference function takes an integer argument representing the radius of the circle, and calculates the circumference of the circle using the formula 2 * pi * radius. The function then prints out the calculated circumference.

double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

////////////////////////////// END SECTION //////////////////////////////////

///////////////////////////// TEST BY VALUE //////////////////////////////////

// We're going to call a method named Multiply, which takes three integer
// parameters: a, b, and c. The method will multiply a and b, and store the
// result in c.

int a = 3;
int b = 4;
int c = 0;

// We're going to call the Multiply method, but we're going to pass in the
// values of a, b, and c as arguments. Note that we're not assigning the
// result of the method to anything, because the method is going to modify
// the value of c directly.

Multiply(a, b, c);

// After the method call, we're going to print out the values of a, b, and
// c, to see what the method did.

Console.WriteLine($"global statement: {a} x {b} = {c}");

// Here is the definition of the Multiply method. It takes three integer
// parameters, and it multiplies the first two together and stores the
// result in the third.

void Multiply(int a, int b, int c) 
{
    // We're going to multiply a and b, and store the result in c.

    c = a * b;

    // We're going to print out the values of a, b, and c, to show what
    // happened inside the method.

    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

////////////////////////////// END SECTION //////////////////////////////////

////////////////////////////// TEST BY REFERENCE //////////////////////////////////

// We're going to create an array of integers and pass it to a method that will
// print out the contents of the array. We're also going to call a method that
// will clear the array, and then print out the array again to show that it's
// been cleared.

// Here is the array of integers we're going to use. It has 5 elements, with
// values of 1, 2, 3, 4, and 5.

int[] array = {1, 2, 3, 4, 5};

// We're going to call the PrintArray method, which takes an array of integers
// as a parameter. The method is going to print out the contents of the array.

PrintArray(array);

// Next, we're going to call the Clear method, which takes an array of integers
// as a parameter. The method is going to loop through the array and set each
// element to 0.

Clear(array);

// Finally, we're going to call the PrintArray method again, to show that the
// array has been cleared.

PrintArray(array);

// Here is the definition of the PrintArray method. It takes an array of integers
// as a parameter. It loops through the array using a foreach loop, and prints
// out each element in the array.

void PrintArray(int[] array) 
{
    // Loop through the array using a foreach loop, and print out each element
    foreach (int a in array) 
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

// Here is the definition of the Clear method. It takes an array of integers
// as a parameter. It loops through the array using a for loop, and sets each
// element to 0.

void Clear(int[] array) 
{
    // Loop through the array using a for loop, and set each element to 0.
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = 0;
    }
}

////////////////////////////// END SECTION //////////////////////////////////

///////////////////////////// TEST WITH STRINGS //////////////////////////////////

// In this example, we're demonstrating how variables are passed to methods.
//
// The `status` variable is declared and initialized to "Healthy".
string status = "Healthy";

// We print out the value of `status` here, which is "Healthy".
Console.WriteLine($"Start: {status}");

// Now, we call the `SetHealth` method, passing in `false` as an argument.
SetHealth(false);

// After the method call, we print out the value of `status` again. At this
// point, `status` should be "Unhealthy".
Console.WriteLine($"End: {status}");

// This is the definition of the `SetHealth` method. It takes a bool as a
// parameter, and sets the value of `status` to either "Healthy" or
// "Unhealthy" depending on the value of the parameter.
void SetHealth(bool isHealthy) 
{
    // This line of code sets the value of `status` to either "Healthy" or
    // "Unhealthy", depending on the value of the parameter.
    status = (isHealthy ? "Healthy" : "Unhealthy");
    // This line of code prints out the value of `status` at this point in the
    // code. We can see that the value of `status` has changed, even though the
    // `SetHealth` method has already returned.
    Console.WriteLine($"Middle: {status}");
}

/////////////////////////////// END SECTION //////////////////////////////////

////////////////////////////// RSVP APP //////////////////////////////////

// This array contains the names of guests who are invited to the party.
string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};

// This array will store the RSVPs as strings.
string[] rsvps = new string[10];

// This variable will keep track of how many RSVPs we have received.
int count = 0;

// Call the RSVP method with different parameters to see how it works.
RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);

// Call the ShowRSVPs method to print out all the RSVPs that we have received.
ShowRSVPs();

// This is the definition of the RSVP method. It takes four parameters: a required string for the name of the guest,
// an optional int for the size of the party (default is 1), an optional string for any allergies (default is "none"),
// and an optional bool for whether the guest is invited or not (default is true).
void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) 
{
    // If the inviteOnly parameter is true, then we need to check if the guest is on the guest list.
    if (inviteOnly)
    {
        // Initialize a boolean variable to false. We will set it to true if we find the guest on the guest list.
        bool found = false;

        // Loop through the guest list and check if the guest is on the list.
        foreach (string guest in guestList)
        {
            // If we find the guest on the list, set the found variable to true and break out of the loop.
            if (guest.Equals(name)) {
                found = true;
                break;
            }
        }

        // If the guest is not on the list, print out an error message and return from the method.
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    // Set the current index of the rsvps array to the current count, and set the value of the array at that index
    // to a string that contains the name, party size, and allergies of the guest.
    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    // Increment the count variable so that we don't overwrite the same index in the array the next time we call this method.
    count++;
}

// This method simply loops through the rsvps array and prints out all the RSVPs that we have received.
void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

//////////////////////////////// END SECTION //////////////////////////////////