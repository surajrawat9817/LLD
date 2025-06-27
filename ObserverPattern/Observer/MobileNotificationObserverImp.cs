using ObserverPattern.Observerable;

namespace ObserverPattern.Observer;

public class MobileNotificationObserverImp: INotificationAlertObserver
{
    private readonly string _mobileNumber;
    private readonly IStocksObservable _stocksObservable;

    public MobileNotificationObserverImp(string mobileNumber, IStocksObservable stocksObservable)
    {
        _mobileNumber = mobileNumber;
        _stocksObservable = stocksObservable;
    }
    public void Update()
    {
        var stockData = _stocksObservable.GetStockData();
        Console.WriteLine($"Notifying on Mobile {_mobileNumber} Stock Count is {stockData}");
    }
}