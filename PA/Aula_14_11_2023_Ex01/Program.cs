using System;

namespace Aula_14_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=========");
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("=========");

            Console.ForegroundColor = ConsoleColor.White;

            for (int contador = 1; contador <= 3; contador++)
            {
                Console.Write("Informe o primeiro número: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o segundo número: ");
                n2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"{n1} - {n2} = {n1 - n2 }");
            }
        }
    }
}
