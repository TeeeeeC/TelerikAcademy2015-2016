using System;
class SayHello
{
    static void Main()
    {
        /*
         Problem 1. Say Hello
            Write a method that asks the user for his name and prints “Hello, <name>”
            Write a program to test this method.
         */
        ReadName();
    }

    static void ReadName ()
    {
        Console.Write("Inser name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
    }
}
