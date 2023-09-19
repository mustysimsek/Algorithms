Console.WriteLine("Dizi elemanlarını araya virgül koyarak yaz:");
var givenValues = Console.ReadLine().Replace(" ", "").Split(',');

int[] values = Array.ConvertAll(givenValues, int.Parse);

BubbleSort(values);

Console.WriteLine(string.Join(',', values));
Console.WriteLine(string.Join(',', givenValues));


void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j].CompareTo(array[j+1])>0)
            {
            var temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;

            //(array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
    }
}