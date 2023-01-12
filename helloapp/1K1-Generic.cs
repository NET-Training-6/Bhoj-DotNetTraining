using System;

internal class NewBaseType
{
    public void Print<T>(T message)
    {
        Console.WriteLine(message);
    }
    public void Print1<T>(T message)
    {
        Console.WriteLine(message);
    }

    void Test()
    {
        Print<string>("Nepal is beautiful country.");
        Print<byte>(34);
        Print<double>(2334.434);
        Print<bool>(true);
        Print<DateTime>(DateTime.Now);
    }


    void Test1()
    {
        Print<string>("Nepal is beautiful.");
        Print<byte>(23);
        Print<double>(4545.56);
        Print<bool>(true);
        Print<DateTime>(DateTime.Now);
        Print<animal1>(new animal1());
    }
}

class Generic : NewBaseType
{
}