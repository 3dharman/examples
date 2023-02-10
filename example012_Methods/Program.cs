//.................Type 1.................

void Method1()
{
     Console.WriteLine("Author: ");
}
// Method1(); (delete // to start programm)

//.................Type 2.................

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Message text: "); (delete // to start programm)

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Message", count: 4); (delete // to start programm)
// Method21(count: 4, msg: "New message"); (delete // to start programm)

//.................Type 3.................

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year); (delete // to start programm)

//.................Type 4.................

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "qwerty");
// Console.WriteLine(res); (delete // to start programm)

string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "qwerty");
// Console.WriteLine(res); (delete // to start programm)

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine ($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}