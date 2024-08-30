/*You'll use the Random.Next() method to simulate rolling three six-sided dice. You'll evaluate the rolled values to calculate the score. If the score is greater than an arbitrary total, then you'll display a winning message to the user. If the score is below the cutoff, you'll display a losing message to the user.

If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
If all three dice you roll result in the same value, you get six bonus points for rolling triples.
If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.
*/


// Roll three dice and calculate the score
Random dice = new Random();
int roll1 = dice.Next(1, 7); // roll a dice between 1 and 6 inclusive
int roll2 = dice.Next(1, 7); // roll a dice between 1 and 6 inclusive
int roll3 = dice.Next(1, 7); // roll a dice between 1 and 6 inclusive

int score = roll1 + roll2 + roll3; // calculate the score

// print the dice rolls and total score
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {score}");

// check if two or three dice have the same value
if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    // check if all three dice have the same value
    if (roll1 == roll2 && roll2 == roll3)
    {
        // if yes, add 6 points as a bonus
        Console.WriteLine("You rolled triples! +6 points!");
        score += 6;
    }
    else
    {
        // if no, add 2 points as a bonus
        Console.WriteLine("You rolled doubles! +2 points!");
        score += 2;
    }
    // print the total score including the bonus
    Console.WriteLine($"Your total includes the bonus: {score}");
}

// check the total score and announce the winner
if (score >= 16)
{
    Console.WriteLine("You win a playstation 5!");
}
else if (score >= 10)
{
    Console.WriteLine("You win an Xbox Series X!");
}
else if (score >= 7)
{
    Console.WriteLine("You win a Nintendo Switch!");
}
else
{
    Console.WriteLine("You lose!");
}



