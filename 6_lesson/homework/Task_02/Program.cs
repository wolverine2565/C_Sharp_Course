/*Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void Method1(double k1, double b1, double k2, double b2)
{
    double k_sub = k1 - k2; 
    double x = (b2 - b1)/ (k1 - k2);
    double y = k1 * x + b1;

    if (k_sub != 0)
    {
        Console.WriteLine($"{x}; {y}");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine(" Существует бесконечное множество точек пересечения");
    else
        Console.WriteLine(" Эти линии не пересекаются");
}
Method1(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));