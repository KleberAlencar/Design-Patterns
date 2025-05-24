using AbstractFactoryPattern;

ECountry country = ECountry.Spain;
ILanguage language = InternationalProvider.CreateLanguage(country);
ICapitalCity capital = InternationalProvider.CreateCapitalCity(country);

Console.WriteLine($"Country: {country}");
Console.WriteLine($"Capital: {capital.GetType().Name}");
language.Greet();
Console.WriteLine($"Total Population: {capital.GetPopulation()}");
Console.WriteLine($"Top Attractions: {string.Join(",", capital.ListTopAttractions())}");