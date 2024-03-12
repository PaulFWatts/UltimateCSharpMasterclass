// See https://aka.ms/new-console-template for more information
Console.WriteLine("2D Array");

char[,] letters = new char[3, 3] // 3x3 array of characters (3 rows, 3 columns). Type is explicitly specified
{
    { 'a', 'b', 'c' },
    { 'd', 'e', 'f' },
    { 'g', 'h', 'i' }
};

var letters2 = new char[3, 3] // 3x3 array of characters (3 rows, 3 columns). Type is inferred
{
    { 'a', 'b', 'c' },
    { 'd', 'e', 'f' },
    { 'g', 'h', 'i' }
};

// Call function to print both arrays
Print2DArray(letters);
Console.WriteLine();
Print2DArray(letters2);
Console.WriteLine();

Console.ReadKey();

// Function to print the 2D array
void Print2DArray(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


