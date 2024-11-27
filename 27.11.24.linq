<Query Kind="Statements" />

var query = countries
    .Select(country => new
    {
        CountryName = country.Name,
        Capital = capitals.FirstOrDefault(c => c.CountryId == country.CountryId),
        MajorCities = cities.Where(c => c.CountryId == country.CountryId)
    });

foreach (var result in query)
{
    Console.WriteLine($"Страна: {result.CountryName}");
    Console.WriteLine($"Столица: {result.Capital?.Name}, Население: {result.Capital?.Population}");
    Console.WriteLine("Крупные города:");
    foreach (var city in result.MajorCities)
    {
        Console.WriteLine($" - {city.Name}, Население: {city.Population}");
    }
    Console.WriteLine();
}