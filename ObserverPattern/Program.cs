using ObserverPattern.Observer;
using ObserverPattern.Observerable;

namespace ObserverPattern;

// The Observer pattern is a design pattern where a subject (an object whose state is of interest)
// maintains a list of dependents,called observers,
// and automatically notifies them of any state changes, typically by calling one of their methods.
// This establishes a one-to-many dependency between the subject and its observers,
// ensuring that all interested parties are kept informed without tight coupling.
public class Program
{
    public static void Main(string[] args)
    {
        IStocksObservable phoneObservableImp = new PhoneObservableImp();
        INotificationAlertObserver notificationAlertObserver1 =
            new EmailNotificationObserverImp("abc@gmail.com", phoneObservableImp);
        INotificationAlertObserver notificationAlertObserver2 =
            new MobileNotificationObserverImp("9827343423",phoneObservableImp);
        INotificationAlertObserver notificationAlertObserver3 =
            new EmailNotificationObserverImp("xyz@gmail.com",phoneObservableImp);
        phoneObservableImp.Add(notificationAlertObserver1);
        phoneObservableImp.Add(notificationAlertObserver2);
        phoneObservableImp.Add(notificationAlertObserver3);
        phoneObservableImp.SetStock(0);
    }
}