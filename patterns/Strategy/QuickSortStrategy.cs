namespace design_patterns.patterns.Strategy;

public class QuickSortStrategy : ISortStrategy
{
    public IEnumerable<int> Sort(IEnumerable<int> numbers)
    {
        Console.WriteLine("Quick Sort Strategy selected");
        var array = numbers.ToArray();
        QuickSort(array, 0, array.Length - 1);
        return array;
    }
    
    void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    int Partition(int[] array, int low, int high)
    {
        int pivot = array[high]; // choose last element as pivot
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    void Swap(int[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}