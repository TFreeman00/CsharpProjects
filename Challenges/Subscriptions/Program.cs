////////////////////////// SUBSCRIPTION CHALLENGE ////////////////////////////////

// Simulate a subscription expiring in a random number of days
Random random = new Random();
int daysUntilExpiration = random.Next(12);

// Set the discount percentage to 0 by default
int discountPercentage = 0;

// Print a message based on the number of days until expiration
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days. Renew now!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
    // Set the discount percentage to 10
    discountPercentage = 10;
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} day. Renew now and save 20%!");
    // Set the discount percentage to 20
    discountPercentage = 20;
}

// If a discount percentage was set, print a message about it
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}


/////////////////////END SUBSCRIPTION CHALLENGE////////////////////////////////

