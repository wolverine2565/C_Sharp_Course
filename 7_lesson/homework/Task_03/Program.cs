/*Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

void PrintArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int [,] arr = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void ArifmeticMid(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double res;

    for (int i = 0; i < column; i++)
    {
        res = 0;
        for (int j = 0; j < row; j++) res += arr [j, i];
        Console.Write($" {Math.Round(res / row, 2)}; ");
    }
}

Console.Write("Введи количество строк ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введи количество столбцов ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введи минимальное значение ");
int from = int.Parse(Console.ReadLine());
Console.Write("Введи максимальное значение ");
int to = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, from, to);
PrintArray(arr_1);

ArifmeticMid(arr[i,j]);
