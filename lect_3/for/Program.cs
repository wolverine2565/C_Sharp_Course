// See https://aka.ms/new-console-template for more information

/*for цикл со счетчиком, собирает все в кучу*/ 
string Method4(int count, string text) 
{    
    string result = String.Empty;

    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "25 ");
Console.WriteLine(res);

//цикл в цикле
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j<= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
