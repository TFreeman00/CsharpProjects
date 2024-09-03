
// Heads or Tails boolean logic
/*Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");*/

// permission is a string that contains either "Admin" or "Manager" or both separated by a pipe.
// level is an integer that represents the level of the user.
//
// If the user is an Admin (i.e. permission contains "Admin"), then...

if (permission.Contains("Admin"))
{
  // If the user's level is greater than 55, then they are a Super Admin.
  if (level > 55)
  {
    Console.WriteLine("Welcome, Super Admin.");
  }
  // Otherwise, they are just an Admin User.
  else
  {
    Console.WriteLine("Welcome, Admin User.");
  }
}
// If the user is a Manager (i.e. permission contains "Manager"), then...
else if (permission.Contains("Manager"))
{
  // If the user's level is greater than 20, then they need to contact an Admin for access.
  if (level > 20)
  {
    Console.WriteLine("Contact an Admin for access.");
  }
  // Otherwise, they do not have sufficient privledges.
  else
  {
    Console.WriteLine("You do not have sufficient privledges.");
  }
}
// If the user is neither an Admin nor a Manager, then they do not have sufficient privledges.
else 
{
  Console.WriteLine("You do not have sufficient privledges.");
}






