//Console.WriteLine("Provide a number:");
//int number = int.Parse(Console.ReadLine());

//Console.WriteLine("You provided: " + number);

//Console.WriteLine("Hello!");
//Console.WriteLine("What do you want to do?");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");
//
//string userChoice = Console.ReadLine();
//Console.WriteLine("User input: " + userChoice);


//var result = Add(10, 5);
//Console.WriteLine("Result: " + result);
string word;

do
{
    Console.WriteLine("Enter a word longer than 10 letters:");
    word = Console.ReadLine();
    Console.WriteLine("You entered: " + word);
} while (word.Length <= 10);


Console.WriteLine("Thank you for playing!");
Console.ReadKey();

//int Add(int a, int b)
//{
//    return a + b;
//}
