// 3. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

if ( a % 7 == 0)
{
    if ( a % 23 == 0)
    Console.WriteLine("Число кратно 7 и 23");
}
else
    Console.WriteLine("Число не кратно 7 и 23");