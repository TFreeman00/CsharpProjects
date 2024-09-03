using System;

// Generate a random number
Random random = new Random();

// Set the cursor to be invisible
Console.CursorVisible = false;

// Get the height and width of the console window
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;

// Flag to track if the game should exit
bool shouldExit = false;

// Initialize the starting position of the player
int playerX = 0;
int playerY = 0;

// Initialize the starting position of the food
int foodX = 0;
int foodY = 0;

// Array of strings that can be used to represent the player
string[] states = {"('-')", "(^-^)", "(X_X)"};

// Array of strings that can be used to represent the food
string[] foods = {"@@@@@", "$$$$$", "#####"};

// The current player string that is being displayed in the console
string player = states[0];

// The index of the current food that is being displayed
int foodIndex = 0;

// Call the initialize game function
InitializeGame();

// Loop until the game should exit
while (!shouldExit) 
{
    // Check if the terminal was resized
    if (TerminalResized())
    {
      // Clear the console and write a message saying that the game is exiting
      Console.Clear();
      Console.Write("Console was resized. Exiting");

      // Set the flag to exit the game
      shouldExit = true;
    }
    else
    {
      // Check if the player is faster
      if (PlayerIsFaster())
      {
        // Move the player faster
        Move(1, false);
      }
      // Check if the player is sick
      else if (PlayerIsSick())
      {
        // Freeze the player
        FreezePlayer();
      }
      else
      {
        // Move the player
        Move(otherKeysExit: false);
      }

      // Check if the player got food
      if (GotFood())
      {
        // Change the player to match the food
        ChangePlayer();

        // Show the food again
        ShowFood();
      }
    }
}

// Function to check if the terminal was resized
bool TerminalResized() 
{
    // Check if the height or width of the console has changed
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Function to show the food at a random location
void ShowFood() 
{
    // Update the food index to a random number
    foodIndex = random.Next(0, foods.Length);

    // Update the food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Print the food at the new location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[foodIndex]);
}

// Function to check if the player got food
bool GotFood()
{
  // Check if the player location matches the food location
  return playerY == foodY && playerX == foodX;
}

// Function to check if the player is sick
bool PlayerIsSick()
{
  // Check if the player string matches the sick state
  return playerX.Equals(states[2]);
}

// Function to check if the player is faster
bool PlayerIsFaster()
{
  // Check if the player string matches the fast state
  return playerX.Equals(states[1]);
}

// Function to change the player to match the food consumed
void ChangePlayer() 
{
    // Update the player string to match the food consumed
    player = states[foodIndex];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Function to freeze the player
void FreezePlayer() 
{
    // Pause the game for 1 second
    System.Threading.Thread.Sleep(1000);

    // Change the player back to the default state
    player = states[0];
}

// Function to move the player based on user input
void Move(int speed = 1, bool otherKeysExit = false) 
{
    // Store the current position of the player
    int lastX = playerX;
    int lastY = playerY;
    
    // Get the key that was pressed
    switch (Console.ReadKey(true).Key) 
    {
        case ConsoleKey.UpArrow:
            // Move the player up
            playerY--; 
            break;
		case ConsoleKey.DownArrow: 
            // Move the player down
            playerY++; 
            break;
		case ConsoleKey.LeftArrow:  
            // Move the player left
            playerX--; 
            break;
		case ConsoleKey.RightArrow: 
            // Move the player right
            playerX++; 
            break;
		case ConsoleKey.Escape:     
            // Set the flag to exit the game
            shouldExit = true; 
            break;
    default:
            // Set the flag to exit the game if the other key was pressed
            shouldExit = otherKeysExit;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Function to clear the console and display the food and player
void InitializeGame() 
{
    // Clear the console
    Console.Clear();

    // Show the food
    ShowFood();

    // Set the starting position of the player
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}
