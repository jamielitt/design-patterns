using static System.Console;
namespace design_patterns;
public class Application(IObserver observer)
{
    private List<string> options = new List<string>()
    {
        "1 - Observer"
    };
    
    public void Run()
    {
        WriteLine("Design Patterns example application");
        WriteLine("Please select which design pattern to execute:");
        
        foreach (var option in options)
        {  
            WriteLine(option);
        }
        
        Write("> ");
        var keyboardInput = ReadLine();
        switch (keyboardInput)
        {
            case "1":
                observer.Run();
                break;
            default:
                WriteLine("Invalid input");
                break;
        }
    }
}