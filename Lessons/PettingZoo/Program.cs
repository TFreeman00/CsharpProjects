using System;

// This program assigns a set of animals to groups for a school visit. 
// For example, if there are 8 animals and 3 groups, the first group will get 3 animals, 
// the second group will get 2 animals, and the third group will get 3 animals.

// This string array contains the names of the animals in the petting zoo.
string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

// This function assigns the animals to groups for a school visit.
void PlanSchoolVisit(string schoolName, int groups = 6) 
{
    // Randomize the order of the animals before assigning them to groups.
    RandomizeAnimals(); 

    // Assign the animals to groups.
    string[,] group1 = AssignGroup(groups);

    // Print the name of the school.
    Console.WriteLine(schoolName);

    // Print the animals assigned to each group.
    PrintGroup(group1);
}

// This function randomizes the order of the animals in the petting zoo.
void RandomizeAnimals() 
{
    // Create a random number generator.
    Random random = new Random();

    // Loop through the petting zoo array and swap each element with a random element from the array.
    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length);

        // Swap the current element with a random element from the array.
        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

// This function assigns the animals to groups.
string[,] AssignGroup(int groups = 6) 
{
    // Create a 2D array to store the groups of animals.
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;

    // Loop through the groups and assign animals to each group.
    for (int i = 0; i < groups; i++) 
    {
        for (int j = 0; j < result.GetLength(1); j++) 
        {
            // Assign an animal to the current group.
            result[i,j] = pettingZoo[start++];
        }
    }

    // Return the 2D array of groups.
    return result;
}

// This function prints the animals assigned to each group.
void PrintGroup(string[,] groups) 
{
    // Loop through the groups and print the animals assigned to each group.
    for (int i = 0; i < groups.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < groups.GetLength(1); j++) 
        {
            Console.Write($"{groups[i,j]}  ");
        }
        Console.WriteLine();
    }
}

//////////////////////////// END LESSON ////////////////////////////////