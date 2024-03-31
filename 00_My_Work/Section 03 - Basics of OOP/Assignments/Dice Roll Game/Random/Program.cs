var random = new Random();
var diceRollResult = random.Next(1, 7);


Console.ReadKey();

class Dice
{
    private readonly Random _random;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll()
    {
        return _random.Next(1, 7);
    }
}
