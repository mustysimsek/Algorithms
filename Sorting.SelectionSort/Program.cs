int[] numbers = { 5, 2, 7, 9, 1, 6, 3, 4, 10, 0 };

Console.WriteLine(string.Join(',', numbers));

SelectionSort(numbers);
Console.WriteLine(string.Join(',', numbers));


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minIndex = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j;
            }
        }

        var temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;
    }
}