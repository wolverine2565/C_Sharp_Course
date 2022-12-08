/*Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

/*void Massiv(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
    Console.WriteLine();
}

int EightMass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

int[] arr_1 = EightMass(int.Parse(Console.ReadLine()));
Massiv(arr_1);
int[] arr_2 = EightMass(int.Parse(Console.ReadLine()));
Massiv(arr_2);*/

void FillArray(int[] collection)
{
    int index = 0;
    int length = collection.Length;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

int [] collection2 = new int[8];

void PrintArray(int[] collection2)
{
    int ind = 0;
    int count = collection2.Length;
    while (ind < count)
    {
        Console.Write(collection2[ind] + " ");
        ind++;
    }
    Console.WriteLine();
}
FillArray(collection2);
PrintArray(collection2);