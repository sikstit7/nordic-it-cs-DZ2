using System;

namespace ДЗ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("сложение");
            var resultat = a + b;
            Console.WriteLine("ответ равен:" + resultat);
            Console.WriteLine("разница");
            var resultat1 = a - b;
            Console.WriteLine("ответ равен:" + resultat1);
            Console.WriteLine("произведение");
            var resultat2 = a * b;
            Console.WriteLine("ответ равен:" + resultat2);
            Console.ReadKey();

        }
    }
}
