using System;

namespace Aula_05_10_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("VERIFICANDO SE O NÚMERO É MAIOR QUE 10");
            Console.WriteLine("--------------------------------------");

            Console.Write("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 10)
                Console.Write($"O NÚMERO {numero} É MAIOR QUE  10");

            else
                Console.Write($"O NÚMERO {numero} NÃO É  MAIOR QUE 10");
        }
    }
}
