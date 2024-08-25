/*You'll use the Random.Next() method to simulate rolling three six-sided dice. You'll evaluate the rolled values to calculate the score. If the score is greater than an arbitrary total, then you'll display a winning message to the user. If the score is below the cutoff, you'll display a losing message to the user.

If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
If all three dice you roll result in the same value, you get six bonus points for rolling triples.
If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.
*/


Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int score = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {score}");

if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    if (roll1 == roll2 && roll2 == roll3)
    {
        
    Console.WriteLine("You rolled triples! +6 points!");
    score += 6;
    }
    else
    {
  Console.WriteLine("You rolled doubles! +2 points!");
    score += 2;
    }
    Console.WriteLine($"Your total includes the bonus: {score}");
}

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



