//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new TomatoSauce());
//pizza.AddIngredient(new Mozzarella());

//Console.WriteLine(pizza.Describe());

//Console.WriteLine("Variable of type Cheddar");
//Cheddar cheddar = new Cheddar();
//Console.WriteLine(cheddar.Name);

//Console.WriteLine("Variable of type Ingredient");
//Ingedient ingredient = new Cheddar();
//Console.WriteLine(ingredient.Name);

var ingredient = new List<Ingedient>
{
    new Cheddar(),
    new TomatoSauce(),
    new Mozzarella()
};

foreach (var item in ingredient)
{
    Console.WriteLine(item.Name);
}

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
    public virtual string Name { get; } = "Ingredient";
    public string PublicMethod() => "Public method in the Ingredient class.";
}

public class Cheddar : Ingedient
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



