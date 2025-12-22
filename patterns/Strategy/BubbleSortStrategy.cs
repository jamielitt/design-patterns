namespace design_patterns.patterns.Strategy;

public class BubbleSortStrategy : ISortStrategy
{
    public IEnumerable<int> Sort(IEnumerable<int> numbers)
    {
        Console.WriteLine("Executing Bubble Sort Strategy");
        var array = numbers.ToArray();
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // swap
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }

        return array;
    }
}