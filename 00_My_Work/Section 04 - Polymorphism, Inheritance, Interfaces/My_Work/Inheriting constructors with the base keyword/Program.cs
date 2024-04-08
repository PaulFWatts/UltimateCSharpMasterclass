//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new TomatoSauce());
//pizza.AddIngredient(new Mozzarella());

//Console.WriteLine(pizza);

var ingredient = new Ingredient(1);

var cheddar = new Cheddar(2, 12); // Constructor from the base class is called first, then the constructor from the derived class is called.
Console.WriteLine(cheddar);

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingedients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient)
    {
        _ingedients.Add(ingredient);
    }
    public override string ToString() => $"Pizza with {string.Join(", ", _ingedients)}";

}

public class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor in the Ingredient class.");
        PriceIfExtraTopping = priceIfExtraTopping;
    }
    public int PriceIfExtraTopping { get; }
    public override string ToString() => Name;
    public virtual string Name { get; } = "Some Ingredient";
    public string PublicMethod() => "Public method in the Ingredient class.";
}

public class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
}
public class Cheddar : Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine("Constructor from the Cheddar class");
    }
    public override string Name =>
        $"{base.Name}, more specifically, " +
        $"a Cheddar cheese aged for {AgedForMonths} months";
    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }
}

public class Mozzarella : Ingredient
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Mozzarella";
    public bool IsLight { get; }
}







