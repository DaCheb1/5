<Query Kind="Program">
  <AutoDumpHeading>true</AutoDumpHeading>
</Query>

public class Country
{
    public int CountryId { get; set; }
    public string Name { get; set; }
    public int Population { get; set; } // Общее количество жителей в стране
}

public class Capital
{
    public int CapitalId { get; set; }
    public string Name { get; set; }
    public int Population { get; set; } // Количество жителей в столице
    public int CountryId { get; set; } // Внешний ключ к Country
}

public class City
{
    public int CityId { get; set; }
    public string Name { get; set; }
    public int Population { get; set; } // Количество жителей в городе
    public int CountryId { get; set; } // Внешний ключ к Country
}
