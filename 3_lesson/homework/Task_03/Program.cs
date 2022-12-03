/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void count(int N)
{
   int i = 0;
   double result;
   while (i < N )
   {
        i += 1;
        if (i == (N))
        {
            result = Math.Pow(i,3);
            Console.Write($"{result}");
        }
        else
        {
        
        result = Math.Pow(i,3);
        Console.Write($"{result},");
        }
   }
    
   
}
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
count(n);