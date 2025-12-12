using static System.Console;
namespace design_patterns;
public class Application(IObserver observer)
{
    public void Run()
    {
        WriteLine("Design Patterns example application");
        observer.Run();
    }
}