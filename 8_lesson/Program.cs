
// // Задача 1:  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// int[,] arr = {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4}
// };




// static int[,] SortArray(int[,] arr)
// {
//   for(int i=0; i<arr.GetLength(0); i++)
//   {
//       for(int j=0; j<arr.GetLength(1); j++)
//       {
//           for(int k=0; k<j; k++)
//           {
//               if(arr[i,j] > arr[i,k])
//               {
//                   int temp = arr[i,j];
//                   arr[i,j] = arr[i,k];
//                   arr[i,k] = temp;
//               }
//           }
//       }
//   }

//   return arr;
// }
// int [,] new_arr = SortArray(arr);

// Console.WriteLine(new_arr);

// // Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] CollMass(int row, int column)
// {
//     int[,] arr = new int[row, column];
//     var rand = new Random();
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             arr[i, j] = rand.Next(-20, 20);
//         }
//     }
//     return arr;
// }

// void PrintMass(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write($"{arr[i, j]}  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void PrintMass1(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         System.Console.WriteLine($"{arr[i]}  ");
// }

// int[] MinSumm(int[,] arr)
// {
//     int[] arr2 = new int[arr.GetLength(0)];
//     int summ;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         summ = 0;
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {

//             summ += arr[i, j];
//         }
//         arr2[i] = summ;
//     }
//     return arr2;
// }

// void MinLine(int[] arr)
// {
//     int min = arr[0];
//     int minline = 1;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] < min)
//         {
//             min = arr[i];
//             minline = i + 1;
//         }
//     }
//     System.Console.WriteLine(minline);
//     System.Console.WriteLine();
// }

// int[,] arr1 = CollMass(int.Parse(Console.ReadLine()),
//                         int.Parse(Console.ReadLine()));
// System.Console.WriteLine();
// PrintMass(arr1);
// System.Console.WriteLine();
// int[] arr2 = MinSumm(arr1);
// PrintMass1(arr2);
// System.Console.WriteLine();
// MinLine(arr2);


// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CollMass(int row, int column)
{
    int[,] arr = new int[row, column];
    var rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = rand.Next(1, 10);
        }
    }
    return arr;
}

void PrintMass(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}   ");
        }
        System.Console.WriteLine();
    }
}


int[,] Matrix2(int[,] arr1, int[,] arr2)
{
    int rowSize = arr1.GetLength(0);
    int columnSize = arr1.GetLength(1);
    int[,] multMatrix = new int[rowSize, columnSize];

    if (rowSize != arr2.GetLength(0) || columnSize != arr2.GetLength(1)) return multMatrix;

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            multMatrix[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
    return multMatrix;
}

int[,] arr1 = CollMass(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
int[,] arr2 = CollMass(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
System.Console.WriteLine();
PrintMass(arr1);
System.Console.WriteLine();
PrintMass(arr2);
System.Console.WriteLine();
PrintMass(Matrix2(arr1, arr2));