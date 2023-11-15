using System;

namespace Aula_14_11_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------");
            Console.WriteLine("NÚMEROS IMPARES");
            Console.WriteLine("---------------");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Informe a quantidade de números: ");
            numero = int.Parse(Console.ReadLine());

            for (int contador = 1; contador  <= numero; contador ++)
            {
                if (contador % 2 == 1)
                    Console.WriteLine($"Numeros Impares: {contador}");
            }
        }
    }
}
