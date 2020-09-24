using System;


namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age;
            Console.ForegroundColor = ConsoleColor.Red;

            //Console.WriteLine("Hola soy Marta");
            Console.WriteLine("Lun 22 jun, 20:00");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hola Dennis");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hola " + name);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("...");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("me encantas " + name);
            age = 16;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("no seas tonto, solo tengo " + age + " años");
            Console.ReadLine();
        }
    }
}
