namespace design_patterns.patterns.Strategy;

public interface INumberProcessor
{
    void Process(IEnumerable<int> numbers);
    void SetSortStrategy(ISortStrategy strategy);
}