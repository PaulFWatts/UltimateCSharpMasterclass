

bool isParsingSuccessfu1;
do
{
    Console.WriteLine("Enter a number:");
    var userInput = Console.ReadLine();
    isParsingSuccessfu1 = int.TryParse(userInput, out var number);
    if (isParsingSuccessfu1)
    {
        Console.WriteLine($"You entered: {number}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again:");
    }
} while (!isParsingSuccessfu1);

Console.ReadKey();
