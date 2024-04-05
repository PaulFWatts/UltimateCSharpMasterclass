// Inheritance enables us to create new classes that resuse, extend, and modify the behavior of
// existing classes.

// The class whose members are inherited is called the base class, and the class that inherits
// those members is called the derived class.

var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozzarella());

Console.WriteLine(pizza.Describe());

Console.ReadKey();

public class Pizza
{
    private List<Ingedient> _ingedients = new List<Ingedient>();
    public void AddIngredient(Ingedient ingredient)
    {
        _ingedients.Add(ingredient);
    }
    public string Describe() => $"Pizza with {string.Join(", ", _ingedients)}";

}

public class Ingedient
{
    public string Name { get; }
}

public class Cheddar : Ingedient
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingedient
{
    public string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }
}

public class Mozzarella : Ingedient
{
    public string Name => "Mozzarella";
    public bool isLight { get; }
}

