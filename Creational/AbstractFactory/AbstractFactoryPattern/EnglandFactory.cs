namespace AbstractFactoryPattern;

// Concrete Factory 1
public class EnglandFactory : IInternationalFactory
{
    public ILanguage CreateLanguage() => new English();

    public ICapitalCity CreateCapitalCity() => new London();
}