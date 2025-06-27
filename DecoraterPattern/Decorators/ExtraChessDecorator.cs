using DecoraterPattern.Base;

namespace DecoraterPattern.Decorators;

public class ExtraChessDecorator : IPizzaDecorators
{
    public readonly IPizza _basePizza;

    public ExtraChessDecorator(IPizza pizza)
    {
        _basePizza = pizza;
    }
    
    public string GetDescription()
    {
        return _basePizza.GetDescription() + ", with ExtraChess";
    }

    public decimal Cost()
    {
        return _basePizza.Cost() + 20;
    }
}