// See https://aka.ms/new-console-template for more information

// ничего не возвращают и не принимают
void Method1()
{
    Console.WriteLine("Автор...");

}
Method1(); //вызов метода


// ничего не возвращают, но могут принимать

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "текст сообщения");
Method2("текст");
Method2(msg: "сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "Текст", count: 4);

int Method3() //не принимает, но может возвращать
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

string Method4(int count, string text) //может принимать и возвращать
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "25 ");
Console.WriteLine(res);