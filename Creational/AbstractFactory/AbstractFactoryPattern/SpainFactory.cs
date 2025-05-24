namespace AbstractFactoryPattern;

// Concrete Factory 2
public class SpainFactory : IInternationalFactory
{
    public ILanguage CreateLanguage() => new Spanish();

    public ICapitalCity CreateCapitalCity() => new Madrid();
}