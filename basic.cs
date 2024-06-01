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




var message = "Hello world!"; 
Console.WriteLine(message) // Hello world!

var message = "Hello World!";
message = 10.703m;  // (2,11): error CS0029: Cannot implicitly convert type 'decimal' to 'string'



// It's important to understand that the var keyword is dependent on the value you use to initialize the variable.
// If you try to use the var keyword without initializing the variable, you'll receive an error when you attempt to compile your code.


var message; // (1,5): error CS0818: Implicitly-typed variables must be initialized



// The var keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.


// Practice Problem  
// Bob
// 3
// 34.4
// Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.

string firstName = "Bob";
int messages = 3;
double temperature = 34.4;

Console.Write("Hello, ");
Console.Write(firstName);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius");
// Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.








  
