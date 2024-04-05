var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozzarella());

Console.WriteLine(pizza);

//var cheddar = new Cheddar();

//Console.WriteLine(cheddar);

//Console.WriteLine(new TomatoSauce());
//Console.WriteLine(new List<int>());

//Console.WriteLine(123);
//Console.WriteLine(new DateTime(2024, 4, 5));
//Console.WriteLine("hello");

Console.ReadKey();

public class Pizza
{
    private List<Ingedient> _ingedients = new List<Ingedient>();
    public void AddIngredient(Ingedient ingredient)
    {
        _ingedients.Add(ingredient);
    }
    public override string ToString() => $"Pizza with {string.Join(", ", _ingedients)}";

}

public class Ingedient
{
    public override string ToString() => Name;
    public virtual string Name { get; } = "Ingredient";
    public string PublicMethod() => "Public method in the Ingredient class.";
}

public class Cheese : Ingedient
{

}
public class Cheddar : Cheese
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
}

public class TomatoSauce : Ingedient
{
    public override string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }
}

public class Mozzarella : Ingedient
{
    public override string Name => "Mozzarella";
    public bool IsLight { get; }
}






