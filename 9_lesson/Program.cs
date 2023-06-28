// // Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от N до 1. 
// // Выполнить с помощью рекурсии.

// void EvenNums(int a)
// {
//     if (a == 0) return;
//     if (a % 2 == 0)
//     {
//         System.Console.Write($"{a} ");
//         EvenNums(a - 2);
//     }
//     else
//     {
//         a = a - 1;
//         System.Console.Write($"{a} ");
//         EvenNums(a - 2);
//     }
// }

// EvenNums(int.Parse(Console.ReadLine()));


// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummElems(int a, int b)
{
    if (a > b) return 0;
    return SummElems(a + 1, b) + a;
}

System.Console.WriteLine(SummElems(int.Parse(Console.ReadLine()),
                              int.Parse(Console.ReadLine())));