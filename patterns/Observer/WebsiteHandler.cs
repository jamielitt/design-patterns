using static System.Console;
namespace design_patterns.patterns.Observer;

public class WebsiteHandler : IObserver<MessageInformation>
{
    private IDisposable? _cancellation;
    
    public void Subscribe(MessageProvider messageProvider)
    {
        _cancellation = messageProvider.Subscribe(this);
    }
    
    public void Unsubscribe()
    {
        _cancellation?.Dispose();
    }
    
    public void OnCompleted()
    {
        WriteLine($"WebsiteHandler has received all the messages from the Provider");
    }

    public void OnError(Exception error)
    {
        WriteLine($"WebsiteHandler has received the error {error}");
    }

    public void OnNext(MessageInformation value)
    {
        WriteLine($"WebsiteHandler has received the message: {value.Message}");
    }
}