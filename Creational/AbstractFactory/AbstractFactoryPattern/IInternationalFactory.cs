namespace AbstractFactoryPattern;

// Abstract Factory
public interface IInternationalFactory
{
    ILanguage CreateLanguage();
    
    ICapitalCity CreateCapitalCity();
}