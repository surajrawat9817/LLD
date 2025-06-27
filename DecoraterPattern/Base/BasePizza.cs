namespace DecoraterPattern.Base;

public class BasePizza:IPizza
{
    public string GetDescription()
    {
        return "Base pizza";
    }

    public decimal Cost()
    {
        return 10;
    }
}