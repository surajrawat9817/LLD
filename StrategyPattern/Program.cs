// The Strategy pattern lets you choose an algorithm (a way of doing something) at runtime, without changing the code that uses it.
// It's like having different tools for the same job, and you can pick the right tool when you need it.


// Strategy Interface (or abstract class)
// This interface defines the contract for all payment strategies.
// It declares the Pay() method, which all concrete strategy classes must implement.

namespace StretegyPattern;

public interface IPaymentStrategy
{
    void Pay(double amount);
}

// Concrete Strategies
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using Credit Card");
        // ... credit card payment logic ...
    }
}

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using PayPal");
        // ... PayPal payment logic ...
    }
}

// Context
public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy) //To change strategy at runtime
    {
        _paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(double amount)
    {
        _paymentStrategy.Pay(amount);
    }
}

// Client Code (in Main or another class)
public class Example
{
    public static void Main(string[] args)
    {
        // Initially using Credit Card
        PaymentContext context = new PaymentContext(new CreditCardPayment());
        context.ProcessPayment(100.00); // Output: Paying 100 using Credit Card

        // Now switching to PayPal
        context.SetPaymentStrategy(new PayPalPayment());
        context.ProcessPayment(50.00);  // Output: Paying 50 using PayPal


        //Demonstrating polymorphism
        IPaymentStrategy strategy = new CreditCardPayment();
        context.SetPaymentStrategy(strategy); //setting strategy using interface type.
        context.ProcessPayment(25); // Output: Paying 25 using Credit Card

    }
}