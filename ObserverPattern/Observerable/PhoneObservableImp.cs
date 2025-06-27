using ObserverPattern.Observerable;

namespace ObserverPattern.Observer;

public class PhoneObservableImp : IStocksObservable
{
    public readonly List<INotificationAlertObserver> NotificationAlertObserver =new();
    public int StockCount { get; set; }
    
    public void Add(INotificationAlertObserver notificationAlertObserver)
    {
        NotificationAlertObserver.Add(notificationAlertObserver);
    }

    public void Remove(INotificationAlertObserver notificationAlertObserver)
    {
        NotificationAlertObserver.Remove(notificationAlertObserver);
    }

    public void NotifySubscriber()
    {
        foreach (var  observer in NotificationAlertObserver)
        {
            observer.Update();
            
        }
    }

    public void SetStock(int stock)
    {
        if (stock == 0)
        {
            NotifySubscriber();
        }
        StockCount += stock;
    }

    public int GetStockData()
    {
        return StockCount;
    }
}