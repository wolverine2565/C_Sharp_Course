/*Задача 1: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную степень B. 
Без модуля Math, используем цикл for.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double MethodPow (int num, int pow)
{
    double n_pow = 1;
    int pow_abs = Math.Abs(pow);

    for(int i = 1; i <= pow_abs; i++)
    {
        if (pow > 0)
            n_pow *= num;
        else
        n_pow /= num;
    }
    return n_pow;
}
Console.WriteLine("Введите число");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень");
int pow_2 = int.Parse(Console.ReadLine());

Console.WriteLine(MethodPow(num_1, pow_2));