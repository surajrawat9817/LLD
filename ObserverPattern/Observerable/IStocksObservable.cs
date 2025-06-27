using ObserverPattern.Observer;

namespace ObserverPattern.Observerable;

public interface IStocksObservable
{
    public void Add(INotificationAlertObserver notificationAlertObserver);
    public void Remove(INotificationAlertObserver notificationAlertObserver);
    public void NotifySubscriber();
    public void SetStock(int stock);

    int GetStockData();
}