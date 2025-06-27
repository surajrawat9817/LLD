using DecoraterPattern.Base;
using DecoraterPattern.Decorators;

// The Decorator pattern lets you add extra features to an object without changing its core nature.  
//     It's like wrapping a gift: 
// you can add layers of decorations (new features) without changing the gift itself.
public class Program
{
    public static void Main(string[] args)
    {
        IPizza pizza = new BasePizza();
        Console.WriteLine($"basePizza Cost {pizza.Cost()}");
        Console.WriteLine(pizza.GetDescription());

        var extraChesse = new ExtraChessDecorator(pizza);
        Console.WriteLine($"basePizza Cost {extraChesse.Cost()}");
        Console.WriteLine(extraChesse.GetDescription());

        var extraVeggies = new ExtraVeggiesDecorator(pizza);
        Console.WriteLine($"ExtraVeggies Cost {extraVeggies.Cost()}");
        Console.WriteLine(extraVeggies.GetDescription());
        
        var extraVeggiesWithChesse = new ExtraVeggiesDecorator(extraChesse);
        Console.WriteLine($"extraVeggiesWithChesse Cost {extraVeggiesWithChesse.Cost()}");
        Console.WriteLine(extraVeggiesWithChesse.GetDescription());

    }
}