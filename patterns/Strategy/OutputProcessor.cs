using Microsoft.Extensions.Options;

namespace design_patterns.patterns.Strategy;

public class OutputProcessor(IOptions<StrategyOptions> options) : IOutputProcessor
{
    public void ProcessOutput(IEnumerable<int>  numbers)
    {
        string numbersString = string.Join(", ", numbers.Take(options.Value.NumbersToOutput));
        Console.WriteLine(numbersString);
    }
}