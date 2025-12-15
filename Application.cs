using design_patterns.patterns.Command;
using design_patterns.patterns.Observer;
using static System.Console;
namespace design_patterns;
public class Application(IObserver observer, ICommandExample commandExample)
{
    private readonly List<string> _options = ["1 - Observer", "2 - Command", "q - Quit application"];
    
    public void Run()
    {
        WriteLine("Design Patterns example application");
        WriteLine("Please select which design pattern to execute:");
        
        foreach (var option in _options)
        {  
            WriteLine(option);
        }
        
        var keyboardInput = string.Empty;
        while (keyboardInput != "q")
        {
            Write("> ");
            keyboardInput = ReadLine();
            switch (keyboardInput)
            {
                case "1":
                    observer.Run();
                    break;
                case "2":
                    commandExample.Run();
                    break;
                case "q":
                    WriteLine("Exiting application ...");
                    break;
                default:
                    WriteLine("Invalid input");
                    break;
            }
        }
    }
}