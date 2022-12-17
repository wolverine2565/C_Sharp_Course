/*
Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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

string FindElement(int[,] arr, int f, int s)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (f > row || f <= 0 || s > column || s <= 0)
        return $" {f} {s} -> Такого числа в массиве нет";
    return $"arr[{f}, {s}] = {arr[f - 1, s - 1]} -> в массиве";
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

Console.Write("Введи позицию в строке ");
int row_position = int.Parse(Console.ReadLine());
Console.Write("Введи позицию в столбце ");
int column_position = int.Parse(Console.ReadLine());

Console.WriteLine(FindElement(arr_1, row_position, column_position));