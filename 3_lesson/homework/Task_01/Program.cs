/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int a = int.Parse(Console.ReadLine());
string s = a.ToString();
char[] ar = s.ToCharArray();
Array.Reverse(ar);
s = new String(ar);
int an = Convert.ToInt32(s);
int digitCount = (int)Math.Log10(a) + 1;
    if (digitCount != 5)
        Console.WriteLine("Число не является 5-значным");
        else    
            if (a == an)
            Console.WriteLine("да");  
            else
            Console.WriteLine("нет");


