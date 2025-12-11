namespace design_patterns.patterns.Observer;

public class MessageProvider : IObservable<MessageInformation>
{
    // Internal list of observers
    internal readonly List<IObserver<MessageInformation>> _observers = new();
    
    public IDisposable Subscribe(IObserver<MessageInformation> observer)
    {
        if (_observers.Contains(observer))
        {
            return null!;
        }
        
        // Add the observer to our internal list of observers
        _observers.Add(observer);
        
        // Return a method which will allow aon observer to unsubscribe
        // from the provider
        return new Unsubscriber<MessageInformation>(_observers, observer);
    }

    public void MessageReceived(MessageInformation message)
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(message);
        }
    }
}

internal sealed class Unsubscriber<MessageInformation> : IDisposable
{
    private readonly List<IObserver<MessageInformation>> _observers;
    private readonly IObserver<MessageInformation> _observer;

    internal Unsubscriber(
        List<IObserver<MessageInformation>> observers,
        IObserver<MessageInformation> observer) => (_observers, _observer) = (observers, observer);

    public void Dispose() => _observers.Remove(_observer);
}