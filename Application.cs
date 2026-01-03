using design_patterns.patterns;
using design_patterns.patterns.builder;
using design_patterns.patterns.Command;
using design_patterns.patterns.Decorator;
using design_patterns.patterns.Observer;
using design_patterns.patterns.Options;
using design_patterns.patterns.Strategy;
using static System.Console;
namespace design_patterns;

// TODO: Wonder if there is a nice way of optimising this?
public class Application(IObserver observer, 
    ICommandExample commandExample, 
    IOptionsExample optionsExample, 
    IDecoratorExample decoratorExample, 
    IStrategyPatternExample strategyPatternExample, 
    IBuilderExample builderExample)
{
    private class PatternExample(string patternName, IPatternExample patternExample)
    {
        public string Name { get; } = patternName;
        public IPatternExample Pattern { get; } = patternExample;
    }

    private Dictionary<string, PatternExample> _options = new()
    {
        ["1"] = new("Observer", observer),
        ["2"] = new("Command", commandExample),
        ["3"] = new("Options Example", optionsExample),
        ["4"] = new("Decorator Example", decoratorExample),
        ["5"] = new("Strategy Pattern", strategyPatternExample),
        ["6"] = new("Builder Pattern", builderExample)
    };

    public void Run()
    {
        WriteLine("Design Patterns example application");
        
        var keyboardInput = string.Empty;
        while (keyboardInput != "q")
        {
            DisplayMenu();

            keyboardInput = ReadLine();
            bool result = _options.TryGetValue(keyboardInput!, out var patternExample);
            
            if (keyboardInput == "q")
            {
                WriteLine("Exiting...");
                break;
            }
            
            if (!result)
            {
                WriteLine("Invalid input");
                continue;
            }
            
            patternExample.Pattern.Run();
        }

        void DisplayMenu()
        {
            WriteLine("Please select which design pattern to execute:");
        
            foreach (var option in _options)
            {  
                WriteLine($"{option.Key} - {option.Value.Name}");
            }
            
            WriteLine("q - Quit Application");
            Write("> ");
        }
    }
}