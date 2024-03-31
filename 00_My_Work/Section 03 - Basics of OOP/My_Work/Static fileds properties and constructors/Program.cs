var rectangle1 = new Rectangle(7, 10);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.GetHeight());
Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine();

var rectangle2 = new Rectangle(2, 3);
Console.WriteLine(Rectangle.DescribeGenrally());
Console.WriteLine(Rectangle.NumberOfSides); // this is how we access a constant field because it is implicitly static
Console.WriteLine("Width is " + rectangle2.Width);
Console.WriteLine("Height is " + rectangle2.GetHeight());
Console.WriteLine("Circumference is " + rectangle2.CalculateCircumference());
Console.WriteLine("Area is " + rectangle2.CalculateArea());

// We don't need to create an instance of the Calculator class to use its methods because they are static
//Console.WriteLine("Sum is " + Calculator.Add(5, 3));
//Console.WriteLine("Difference is " + Calculator.Subtract(5, 3));
//Console.WriteLine("Product is " + Calculator.Multiply(5, 3));

Console.WriteLine();
Console.WriteLine("Number of instances of Rectangle is " + Rectangle.CountofInstances);

Console.ReadKey();

static class Calculator // this is a static class that contains static methods and is stateless
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}
class Rectangle
{

    public static int CountofInstances { get; private set; } // this is a property that has a getter and a private setter
    private static DateTime _firstused = DateTime.Now; // Record the 1st usage of the class


    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width)); // nameof is used to get the name of the variable in case we change it in the future
        _height = GetLengthOrDefault(height, nameof(height)); // this is better than hardcoding the name of the variable as a string literal
        ++CountofInstances; // this is how we increment the value of a static field
    }

    public int Width { get; private set; } // this is a property that has a getter and a private setter


    private int _height;

    public int GetHeight() => _height; // this is a getter method that returns the value of the private field _height

    public void SetHeight(int height) // this is a setter method that sets the value of the private field _height
    {
        _height = GetLengthOrDefault(height, nameof(height));
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
        return 2 * (Width + _height);
    }

    public int CalculateArea()
    {
        return Width * _height;
    }

    public string Description => $"A rectabgle with width: {Width} " + $"and height {_height}"; // this is a computed property that returns a string with the description of the rectangle

    public static string DescribeGenrally() => "A rectangle is a four-sided figure with opposite sides that are equal and parallel."; // this is a static method in a non-static class

    public static string NotusingAnyState() => "This method does not use any state of the class";

    public const int NumberOfSides = 4; // this is a constant field that cannot be changed. All const fields are implicitly static
}

