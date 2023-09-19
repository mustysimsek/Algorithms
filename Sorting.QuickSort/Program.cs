using System;

class Program
{
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(ref arr[i], ref arr[j]);
            }
        }

        Swap(ref arr[i + 1], ref arr[high]);
        return i + 1;
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int[] arr = { 10, 7, 8, 9, 1, 5 };
        int n = arr.Length;
        Console.WriteLine("Orijinal dizi:");
        PrintArray(arr);

        QuickSort(arr, 0, n - 1);

        Console.WriteLine("Sıralanmış dizi:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
