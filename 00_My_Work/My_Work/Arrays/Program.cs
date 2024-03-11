//int[] numbers = new int[5];

//Console.WriteLine("Element 0: " + numbers[0]);
//Console.WriteLine("Element 1: " + numbers[1]);
//Console.WriteLine("Element 2: " + numbers[2]);
//Console.WriteLine("Element 3: " + numbers[3]);
//Console.WriteLine("Element 4: " + numbers[4]);
//Console.WriteLine();

var numbers = new [] { 2, 6, 1, 6, 19 }; // This is an array initializer and type is inferred

var sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine("Sum of all elements: " + sum);

//Console.WriteLine();
//Console.WriteLine("Element 0: " + numbers[0]);
//Console.WriteLine("Element 1: " + numbers[1]);
//Console.WriteLine("Element 2: " + numbers[2]);
//Console.WriteLine("Element 3: " + numbers[3]);
//Console.WriteLine("Element 4: " + numbers[4]);
//Console.WriteLine();

//var firstFromEnd = numbers[^1]; // ^1 is the same as numbers[numbers.Length - 1]
//var secondFromEnd = numbers[^2]; // ^2 is the same as numbers[numbers.Length - 2]
//Console.WriteLine("First from end: " + firstFromEnd);
//Console.WriteLine("Second from end: " + secondFromEnd);

Console.ReadKey();