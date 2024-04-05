Console.ReadKey();

// What type can we use for the _ingedients list in the Pizza class?
// What type can we use for the ingredient parameter in the AddIngredient method?
// We can use a type of polymorphism to make the Pizza class more flexible.
// We can use an interface to make the Pizza class more flexible.
// Specifically, "Inheritance"

public class Pizza
{
    private List<???> _ingedients = new List<???>();
    public void AddIngredient(?? ingredient)
    {
        _ingedients.Add(ingredient);
    }
    public string Describe() => $"Pizza with {string.Join(", ", _ingedients)}";

}

public class Cheddar
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce
{
    public string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }
}

public class Mozzarella
{
    public string Name => "Mozzarella";
    public bool isLight { get; }
}
