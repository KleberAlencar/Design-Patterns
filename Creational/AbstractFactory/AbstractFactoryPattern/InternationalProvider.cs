namespace AbstractFactoryPattern;

public class InternationalProvider
{
    public static ILanguage CreateLanguage(ECountry country)
    {
        return country switch
        {
            ECountry.England => new EnglandFactory().CreateLanguage(),
            ECountry.Spain => new SpainFactory().CreateLanguage(),
            _ => throw new InvalidOperationException($"Invalid country: {country}")
        };
    }

    public static ICapitalCity CreateCapitalCity(ECountry country)
    {
        return country switch
        {
            ECountry.England => new EnglandFactory().CreateCapitalCity(),
            ECountry.Spain => new SpainFactory().CreateCapitalCity(),
            _ => throw new InvalidOperationException($"Invalid country: {country}")
        }; 
    }
}