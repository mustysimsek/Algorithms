int[] numbers = { 5, 2, 7, 9, 1, 6, 3, 4, 10, 0 };
Console.WriteLine(string.Join(',', numbers));
InsertionSort(numbers);
Console.WriteLine(string.Join(',', numbers));

void InsertionSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        var currentValue = array[i];
        int j = i - 1;
        while (j>= 0 && array[j] > currentValue)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = currentValue;
    }
}