var rectangle1 = new Rectangle(7, 10);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.Height);
Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine();

var rectangle2 = new Rectangle(2, 3);
Console.WriteLine("Width is " + rectangle2.Width);
Console.WriteLine("Height is " + rectangle2.Height);
Console.WriteLine("Circumference is " + rectangle2.CalculateCircumference());
Console.WriteLine("Area is " + rectangle2.CalculateArea());
Console.ReadKey();

class Rectangle
{
    const int NumberOfSides = 4; // const is used to define a constant value that cannot be changed
    public readonly int Width; // readonly is used to make sure that the value is not changed after the object is created
    public readonly int Height;

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(width)); // nameof is used to get the name of the variable in case we change it in the future
        Height = GetLengthOrDefault(height, nameof(height)); // this is better than hardcoding the name of the variable as a string literal
    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int DefaultValueIfNonPositive = 1; // const is used to define a constant value that cannot be changed

        if (length <= 0)
        {
            Console.WriteLine($"{name} is not positive. Default value is used.");
            return DefaultValueIfNonPositive;
        }
        else
        {
            return length;
        }
    }

    public int CalculateCircumference()
    {
        return 2 * (Width + Height);
    }

    public int CalculateArea()
    {
        return Width * Height;
    }
}
