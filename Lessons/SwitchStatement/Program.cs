///////////////////////// SWITCH STATEMENT /////////////////////////////////

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

// Split the SKU into an array of strings, using the '-' character as the separator
string[] product = sku.Split('-');

// Declare variables to hold the type, color, and size of the product
string type = "";
string color = "";
string size = "";

// Use a switch statement to determine the type of product based on the first element of the array
switch (product[0])
{
  // If the first element is "01", the product is a Sweat Shirt
  case "01":
      type = "Sweat Shirt";
      break;
  // If the first element is "02", the product is a T-Shirt
  case "02":
      type = "T-Shirt";
      break;
  // If the first element is "03", the product is Sweat Pants
  case "03":
      type = "Sweat Pants";
      break;
  // If the first element is anything else, the product is "Other"
  default:
      type = "Other";
      break;

}

// Use a switch statement to determine the color of the product based on the second element of the array
switch (product[1])
{
  // If the second element is "BL", the product is Black
  case "BL":
      color = "Black";
      break;
  // If the second element is "MN", the product is Maroon
  case "MN":
      color = "Maroon";
      break;
  // If the second element is anything else, the product is White
  default:
      color = "White";
      break;

}

// Use a switch statement to determine the size of the product based on the third element of the array
switch (product[2])
{
  // If the third element is "S", the product is Small
  case "S":
      size = "Small";
      break;
  // If the third element is "M", the product is Medium
  case "M":
      size = "Medium";
      break;
  // If the third element is "L", the product is Large
  case "L":
      size = "Large";
      break;
  // If the third element is anything else, the product is One size Fits All
  default:
      size = "One size Fits All";
      break;

}

// Print out the product information to the console
Console.WriteLine($"Product: {size} {color} {type}");


//////////////////////////// END SECTION //////////////////////////////////
