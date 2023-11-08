using System;

namespace Aula_07_11_2023_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
           
                Console.WriteLine($"O número {numero} é PAR!");
            else
                Console.WriteLine($"O número {numero} é IMPAR!");
        }
    }
}
