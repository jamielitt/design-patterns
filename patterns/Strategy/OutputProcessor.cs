namespace design_patterns.patterns.Strategy;

public class OutputProcessor : IOutputProcessor
{
    public void ProcessOutput(IEnumerable<int>  numbers)
    {
        string numbersString = string.Join(", ", numbers.Take(10));
        Console.WriteLine(numbersString);
    }
}