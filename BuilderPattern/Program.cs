namespace BuilderPattern;
// The Builder pattern is a way to construct complex objects step by step,
// separating the construction process from the object's representation.
// This allows you to create different versions of the object using the same building steps.

public class Pizza
{
    public string Crust { get; set; }
    public string Sauce { get; set; }
    public List<string> Toppings { get; set; }
    public string Size { get; set; }

    public override string ToString()
    {
        return $"Pizza: {Size} with {Crust} crust, {Sauce} sauce, and toppings: {string.Join(", ", Toppings)}";
    }
}

// Builder Interface
public interface IPizzaBuilder
{
    void ChooseCrust(string crust);
    void AddSauce(string sauce);
    void AddToppings(List<string> toppings);
    void SetSize(string size);
    Pizza GetPizza();
}

// Concrete Builder: VeggiePizzaBuilder
public class VeggiePizzaBuilder : IPizzaBuilder
{
    private Pizza pizza = new Pizza();

    public void ChooseCrust(string crust)
    {
        pizza.Crust = crust;
    }

    public void AddSauce(string sauce)
    {
        pizza.Sauce = sauce;
    }

    public void AddToppings(List<string> toppings)
    {
        pizza.Toppings = toppings;
    }

    public void SetSize(string size)
    {
        pizza.Size = size;
    }

    public Pizza GetPizza()
    {
        return pizza;
    }
}

// Director (Optional, but helpful)
public class PizzaOrder
{
    public Pizza MakePizza(IPizzaBuilder builder)
    {
        builder.ChooseCrust("Thin"); // Default crust
        builder.AddSauce("Tomato"); // Default sauce

        // Example toppings (can be customized)
        List<string> toppings = new List<string> { "Mushrooms", "Onions", "Peppers" };
        builder.AddToppings(toppings);

        builder.SetSize("Large"); // Default size

        return builder.GetPizza();
    }


    public Pizza MakeCustomPizza(IPizzaBuilder builder, string crust, string sauce, List<string> toppings, string size)
    {
        builder.ChooseCrust(crust);
        builder.AddSauce(sauce);
        builder.AddToppings(toppings);
        builder.SetSize(size);
        return builder.GetPizza();
    }
}

class Program
{
    static void Main(string[] args)
    {
        PizzaOrder orderTaker = new PizzaOrder();

        // Using the default settings in the director
        IPizzaBuilder veggieBuilder = new VeggiePizzaBuilder();
        Pizza myPizza = orderTaker.MakePizza(veggieBuilder);
        Console.WriteLine(myPizza);


        // Creating a custom pizza
        IPizzaBuilder customBuilder = new VeggiePizzaBuilder();
        List<string> customToppings = new List<string> { "Spinach", "Olives", "Artichoke Hearts" };
        Pizza anotherPizza = orderTaker.MakeCustomPizza(customBuilder, "Thick", "Pesto", customToppings, "Medium");
        Console.WriteLine(anotherPizza);

        Console.ReadKey();
    }
}