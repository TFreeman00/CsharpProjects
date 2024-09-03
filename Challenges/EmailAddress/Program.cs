// Corporate emails are stored in a 2D array, with the first column containing
// first names and the second column containing last names.
string[,] corporate = 
	{
		{"Robert", "Bavin"}, {"Simon", "Bright"},
		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}
	};

// External emails are stored in a 2D array, with the first column containing
// first names and the second column containing last names.
string[,] external = 
	{
		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
	};

// The external domain is a string that will be used to construct the email
// addresses for the external emails.
string externalDomain = "hayworth.com";

// Loop through the corporate emails and display each one.
for (int i = 0; i < corporate.GetLength(0); i++) 
{
	DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
}

// Loop through the external emails and display each one.
for (int i = 0; i < external.GetLength(0); i++) 
{
	DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
}

// This is a helper method that takes in a first name, last name, and optionally
// a domain, and constructs an email address from them.
void DisplayEmail(string first, string last, string domain = "contoso.com") 
{
	// Take the first two characters of the first name and concatenate them with
	// the last name.
	string email = first.Substring(0, 2) + last;

	// Convert the email address to lower case.
	email = email.ToLower();

	// Print out the email address to the console, using the domain that was passed
	// in or the default domain if none was passed in.
	Console.WriteLine($"{email}@{domain}");
}
