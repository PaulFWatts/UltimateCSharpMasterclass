int seasonNumber = 0;
Season spring = (Season)(seasonNumber); // cast int to Season

int integer = 10;
decimal b = integer; // implicit conversion from int to decimal

decimal c = 10.01m;
// int d = c; // This will not compile as it's not safe and will result in data loss
int d = (int)c; // explicit conversion from decimal to int

// decimal e = 1000000000000000000.01m;
// int f = (int)e; // This will compile but will result in a runtime error

// string s = (string)integer; // This will not compile as there is no implicit conversion from int to string
string s = integer.ToString(); // This is the correct way to convert int to string

//int secondSeasonNumber = 1;
//Season summer = (Season)(secondSeasonNumber); // cast int to Season
//Console.WriteLine(summer); // Output: Summer

int secondSeasonNumber = 11;
Season summer = (Season)(secondSeasonNumber); // cast int to Season
Console.WriteLine(summer); // Output: 11 (which is not a valid Season)

Console.ReadKey();

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

