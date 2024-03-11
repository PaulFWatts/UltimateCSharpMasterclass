// See https://aka.ms/new-console-template for more information
var words = new[] { "one", "two", "three", "four" }; // Array of strings. Type is inferred

//for(int i = 0; i < words.Length; i++)
//{
//    Console.WriteLine(words[i]);
//}

foreach (var word in words)
{
    Console.WriteLine(word);
}


Console.ReadKey();
