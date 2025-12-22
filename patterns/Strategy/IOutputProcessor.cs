namespace design_patterns.patterns.Strategy;

public interface IOutputProcessor
{
    void ProcessOutput(IEnumerable<int> numbers);
}