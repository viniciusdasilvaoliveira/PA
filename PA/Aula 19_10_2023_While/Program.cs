using System;

namespace Aula_19_10_2023_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            

            while (contador <= 10)
            {
                Console.WriteLine($"2 X {contador} = {2 * contador}");
                //contador = contador + 1;
                contador++;
            }
            Console.WriteLine("*** Fim da Tabuada ***");
        }
    }
}
