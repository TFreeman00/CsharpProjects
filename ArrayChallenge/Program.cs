// We have an array of strings, each representing an Order ID
string[] OrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

// We want to loop through each Order ID in the array
foreach (string IDs in OrderIDs)
{
  // If the Order ID starts with the letter "B", then we should print it out
  if (IDs.StartsWith("B"))
  {
    // Here we are printing out the Order ID if it starts with "B"
    Console.WriteLine("Order ID starts with: " + IDs);
  }
  
}

