var numbers = new[] { 10, -8, 2, 12, -17 };
int countOfNonPositive;
var onlyPositive = GetOnlyPositive(numbers, out countOfNonPositive);
foreach (var number in onlyPositive)
{
    Console.WriteLine(number);
}
Console.WriteLine($"Count of non-positive numbers: {countOfNonPositive}");
Console.WriteLine();
Console.WriteLine("Press any key to exit...");



Console.ReadKey();


List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive) // out keyword
{
    var result = new List<int>();
    countOfNonPositive = 0;
    foreach (var number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
        else
        {
            countOfNonPositive++;
        }
    }
    return result;
}






