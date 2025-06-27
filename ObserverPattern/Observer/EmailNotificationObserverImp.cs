using ObserverPattern.Observerable;

namespace ObserverPattern.Observer;

public class EmailNotificationObserverImp : INotificationAlertObserver
{
    private readonly string _emailId;
    private readonly IStocksObservable _stocksObservable;

    public EmailNotificationObserverImp(string emailId, IStocksObservable stocksObservable)
    {
        _emailId = emailId;
        _stocksObservable = stocksObservable;
    }
    public void Update()
    {
       var stockData = _stocksObservable.GetStockData();
       Console.WriteLine($"Notifying Email {_emailId} Stock Count is {stockData}");
    }
}