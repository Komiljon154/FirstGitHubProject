using System;

namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("4 xonali son kiriting : ");
            var number = Convert.ToInt32(Console.ReadLine());
            var ones = number % 10;
            var tens = number % 1000 % 100 / 10;
            var haundreds = number % 1000 / 100;
            var saunthens = number / 1000;
            var result = ones + tens + haundreds + saunthens;
            Console.WriteLine(result);
        }
    }
}

