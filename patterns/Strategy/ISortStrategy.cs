namespace design_patterns.patterns.Strategy;

public interface ISortStrategy : IStrategy
{
    IEnumerable<int> Sort(IEnumerable<int> numbers);
}