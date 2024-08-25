string[] OrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string IDs in OrderIDs)
{
  if (IDs.StartsWith("B"))
  {
    Console.WriteLine("Order ID starts with: " + IDs);
  }
  
}

