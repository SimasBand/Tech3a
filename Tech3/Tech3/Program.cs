using System;

namespace Tech3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello What is your name?: ");
            String name = Console.ReadLine();
            Console.Write("Hello, ");
            Console.Write(name);
            Console.WriteLine("!");
        }
    }
}
