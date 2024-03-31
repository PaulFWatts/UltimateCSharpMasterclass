// var person = new Person("John", 1981); // Using constructor

var person = new Person
{
    Name = "John",
    YearOfBirth = 1981
}; // Using object initializer

Console.ReadKey();

class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; init; } // init is used to make sure that the value is not changed after the object is created

    //public Person(string name, int yearOfBirth)
    //{
    //    Name = name;
    //    YearOfBirth = yearOfBirth;
    //}

}
