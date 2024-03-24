
var internationalPizzaDay23 = new DateTime(2023, 2, 9);

Console.WriteLine("year is " + internationalPizzaDay23.Year);
Console.WriteLine("month is " + internationalPizzaDay23.Month);
Console.WriteLine("day is " + internationalPizzaDay23.Day);
Console.WriteLine("day of week is " + internationalPizzaDay23.DayOfWeek);
Console.WriteLine(internationalPizzaDay23.ToString("yyyy MMM dd"));

var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

Console.WriteLine();
Console.WriteLine("year is " + internationalPizzaDay24.Year);
Console.WriteLine("month is " + internationalPizzaDay24.Month);
Console.WriteLine("day is " + internationalPizzaDay24.Day);
Console.WriteLine("day of week is " + internationalPizzaDay24.DayOfWeek);
Console.WriteLine(internationalPizzaDay24.ToString("yyyy MMM dd"));



Console.ReadKey();

