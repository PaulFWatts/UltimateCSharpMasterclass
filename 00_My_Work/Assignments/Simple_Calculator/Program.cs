Console.Write(@"Hello!
Input the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(@"What do you want to do with those numbers?
[A]dd
[S]ubtract
[M]ultiply
 ");
char operation = Convert.ToChar(Console.ReadLine().ToUpper());
Console.WriteLine();

int result = 0;
string operatorName = "";
string errorFlag = "";

switch (operation)
{
    case 'A':
        result = number1 + number2;
        operatorName = "+";
        break;
    case 'S':
        result = number1 - number2;
        operatorName = "-";
        break;
    case 'M':
        result = number1 * number2;
        operatorName = "*";
        break;
    default:
        Console.WriteLine("Invalid choice!");
        errorFlag = "error";
        break;
}
if (errorFlag != "error")
{
    Console.WriteLine();
    Console.WriteLine($"{number1} {operatorName} {number2} = {result}");

}

Console.WriteLine();
Console.WriteLine("Press any key to close...");

Console.ReadKey();
