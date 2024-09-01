
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

string[] students = {"Jenna", "Sarah", "Samantha", "Choy"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert", "Katie"});

void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.WriteLine($"{student}");
    }
    Console.WriteLine();
}


////////////////////////////// END SECTION //////////////////////////////////

////////////////////////////// CERCUMFERENCE //////////////////////////////////

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



