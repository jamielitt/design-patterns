using System.Diagnostics;

namespace design_patterns.patterns.Strategy;

public class NumberProcessor(IOutputProcessor processor) : INumberProcessor
{
    private ISortStrategy _sortStrategy;

    public void SetSortStrategy(ISortStrategy strategy)
    {
        if (strategy == null)
            throw new ArgumentNullException(nameof(strategy));
        
        _sortStrategy = strategy;
    }

    public void Process(IEnumerable<int> numbers)
    {
        if (numbers == null)
            throw new ArgumentNullException(nameof(numbers));
        
        Stopwatch sw = Stopwatch.StartNew();
        var sortedNumbers = _sortStrategy.Sort(numbers);
        sw.Stop();
        
        Console.WriteLine($"Elapsed time is {sw.ElapsedMilliseconds} ms");
        processor.ProcessOutput(sortedNumbers);
    }
}