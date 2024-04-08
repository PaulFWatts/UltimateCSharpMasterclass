int seasonNumber = 0;
Season spring = (Season)(seasonNumber); // cast int to Season

int integer = 10;
decimal b = integer; // implicit conversion from int to decimal

Console.ReadKey();

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}