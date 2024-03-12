// List<string> words = new List<string> { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
var words = new List<string> { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
Console.WriteLine("Count of elements is " + words.Count);

words.Add("!");
Console.WriteLine("Count of elements is " + words.Count);

foreach (var word in words)
{
    Console.Write(word + " ");
}

Console.WriteLine();
Console.WriteLine("Removing an item");
words.Remove("!");
Console.WriteLine();
Console.WriteLine("Count of elements is " + words.Count);
Console.WriteLine();

Console.ReadKey();
