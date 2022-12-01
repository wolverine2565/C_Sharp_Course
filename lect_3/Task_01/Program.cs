// See https://aka.ms/new-console-template for more information
int[] arr = { 1, 5, 6, 6, 4, 7, 1, 9, 3, 2 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length ; i++)
    {
        int minPosition = 1;
        for (int j = 0; j < array.Length ; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    Console.WriteLine();
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);