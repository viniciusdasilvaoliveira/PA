using System;

namespace Aula_26_10_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("TABUADA DO 2");
            Console.WriteLine("==================");

            int contador = 1;

            do
            {
                Console.WriteLine($"2 X {contador} = {2 * contador}");
                //contador = contador + 1;
                contador++;
            } while (contador <= 10); 
        }
    }
}
