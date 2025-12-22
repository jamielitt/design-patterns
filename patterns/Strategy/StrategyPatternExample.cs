using Microsoft.Extensions.Options;
using static System.Console;

namespace design_patterns.patterns.Strategy;

public class StrategyPatternExample(INumberProcessor numberProcessor, IOptions<StrategyOptions> options) : IStrategyPatternExample
{
    public void Run()
    {
        WriteLine("Strategy Pattern Example");
        
        Random random = new();
        List<int> numbers = new();

        for (int i = 0; i < 100000; i++)
        {
            numbers.Add(random.Next(1, 100)); // 1 to 100 inclusive
        }

        WriteLine("Random numbers generated to sort:");
        WriteLine(string.Join(", ", numbers.Take(options.Value.NumbersToOutput)));
        WriteLine();
        var selection = string.Empty;

        while (!string.Equals(selection, "q", StringComparison.Ordinal))
        {
            WriteLine("Please select from one of the sort strategies below:");
            WriteLine("1 - Bubble Sort");
            WriteLine("2 - Quick Sort");
            WriteLine("q - Quick back to main menu");
            Write("> ");
            selection = ReadLine();
            switch (selection)
            {
                case "1":
                    numberProcessor.SetSortStrategy(new BubbleSortStrategy());
                    numberProcessor.Process(numbers);
                    break;
                case "2":
                    numberProcessor.SetSortStrategy(new QuickSortStrategy());
                    numberProcessor.Process(numbers);
                    break;
            }
        }
    }
}