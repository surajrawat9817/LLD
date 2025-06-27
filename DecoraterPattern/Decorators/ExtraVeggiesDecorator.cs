using DecoraterPattern.Base;

namespace DecoraterPattern.Decorators;

public class ExtraVeggiesDecorator : IPizzaDecorators
{
    public readonly IPizza _basePizza;

    public ExtraVeggiesDecorator(IPizza pizza)
    {
        _basePizza = pizza;
    }
    
    public string GetDescription()
    {
        return _basePizza.GetDescription() + ", with ExtraVeggies";
    }

    public decimal Cost()
    {
        return _basePizza.Cost() + 30;
    }
}