var totalCount = 0;

for (int i = 0; i < 4; ++i)

{
    for(int j = 0; j < 3; ++j)
    {
        for(int k = 0; k < 5; ++k)
        {
            totalCount++;
            Console.WriteLine($"i is {i}, j is {j}, k is {k}");
        }   
    }
}   
Console.WriteLine($"Total count is {totalCount}");
Console.WriteLine("The loop is finished");


Console.ReadKey();
