string firstName;
firstName = "Bob";
Console.WriteLine(firstName);  // Bob


string firstName = "Bob";
Console.WriteLine(firstName);  // Bob


string firstName;
Console.WriteLine(firstName) // (2,19): error CS0165: Use of unassigned local variable 'firstName'


int firstName;
firstName = "Bob"; // (2,9): error CS0029: Cannot implicitly convert type 'string' to 'int'


string firstName;
"Bob" = firstName // (2,1): error CS0131: The left-hand side of an assignment must be a variable, property or indexer
