
////////////////////////// RANDOM DICE GAME /////////////////////////////

// Using methods to make the game playable

Random random = new Random();

// Ask the user if they want to play the game
Console.WriteLine("Would you like to play? (Y/N)");

// Call the ShouldPlay() method to see if the user wants to play
if (ShouldPlay()) 
{
    // Call the PlayGame() method to start the game
    PlayGame();
}

// ShouldPlay() method returns true or false based on user input
bool ShouldPlay() 
{
    // Get the user's response to the question of whether they want to play
    string response = Console.ReadLine();

    // If the user typed 'y', return true, otherwise return false
    return response.ToLower().Equals("y");
}

// PlayGame() method contains the main loop of the game
void PlayGame() 
{
    // Variable to keep track of whether the user wants to keep playing
    var play = true;

    // Loop until the user wants to stop playing
    while (play) {
        // Get a random number between 1 and 6 to use as the target number
        var target = GetTarget();

        // Roll a dice and get a random number between 1 and 6
        var roll = RollDice();

        // Print out the target number and the roll
        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");

        // Print out the result of the roll: win or lose
        Console.WriteLine(WinOrLose(roll, target));

        // Ask the user if they want to play again
        Console.WriteLine("\nPlay again? (Y/N)");

        // Call the ShouldPlay() method to see if the user wants to keep playing
        play = ShouldPlay();
    }
}

// GetTarget() method returns a random number between 1 and 6
int GetTarget() 
{
    return random.Next(1, 6);
}

// RollDice() method returns a random number between 1 and 6
int RollDice() 
{
    return random.Next(1, 7);
}

// WinOrLose() method returns a string saying whether the user won or lost based on the roll and target
string WinOrLose(int roll, int target) 
{
    // If the roll is greater than the target, return a string saying the user won
    if (roll > target) 
    {
        return "You win!";
    }

    // If the roll is not greater than the target, return a string saying the user lost
    return "You lose!";
}

////////////////////////// END GAME //////////////////////////////

