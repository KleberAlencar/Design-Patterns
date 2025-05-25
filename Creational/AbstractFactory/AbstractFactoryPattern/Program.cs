using AbstractFactoryPattern;
using AbstractFactoryPattern.Enums;

var country = ECountry.Spain;
var language = InternationalProvider.CreateLanguage(country);
var capital = InternationalProvider.CreateCapitalCity(country);

Console.WriteLine($"Country: {country}");
Console.WriteLine($"Capital: {capital.GetType().Name}");
language.Greet();
Console.WriteLine($"Total Population: {capital.GetPopulation()}");
Console.WriteLine($"Top Attractions: {string.Join(",", capital.ListTopAttractions())}");