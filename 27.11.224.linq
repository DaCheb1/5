<Query Kind="Statements" />

var countries = new List<Country>
{
    new Country { CountryId = 1, Name = "Россия", Population = 146599183 },
    new Country { CountryId = 2, Name = "США", Population = 331002651 },
    new Country { CountryId = 3, Name = "Китай", Population = 1439323776 }
};

var capitals = new List<Capital>
{
    new Capital { CapitalId = 1, Name = "Москва", Population = 11920000, CountryId = 1 },
    new Capital { CapitalId = 2, Name = "Вашингтон", Population = 705749, CountryId = 2 },
    new Capital { CapitalId = 3, Name = "Пекин", Population = 21540000, CountryId = 3 }
};

var cities = new List<City>
{
    new City { CityId = 1, Name = "Санкт-Петербург", Population = 5384000, CountryId = 1 },
    new City { CityId = 2, Name = "Нью-Йорк", Population = 8419600, CountryId = 2 },
    new City { CityId = 3, Name = "Шанхай", Population = 24183300, CountryId = 3 }
};