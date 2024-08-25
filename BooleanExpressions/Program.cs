
// Heads or Tails boolean logic
/*Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");*/

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
  if (level > 55)
  {
  Console.WriteLine("Welcome, Super Admin.");
  }
  else
  {
  Console.WriteLine("Welcome, Admin User.");
  }
}
else if (permission.Contains("Manager"))
{
  if (level > 20)
  {
    Console.WriteLine("Contact an Admin for access.");
  }
  else
  {
    Console.WriteLine("You do not have sufficient priveleges.");
  }
}
else 
{
  Console.WriteLine("You do not have sufficient privledges.");
}







