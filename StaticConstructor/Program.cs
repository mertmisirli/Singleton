// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class MyClass
{
    static MyClass()
    {
        Console.WriteLine("Static Constructor");
    }

    public MyClass()
    {
        Console.WriteLine("Instance Created");
    }
}