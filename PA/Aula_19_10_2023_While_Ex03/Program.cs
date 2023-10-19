using System;

namespace Aula_19_10_2023_While_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, fator, numFinal;

            Console.Write("Informe o fator: ");
            fator = int.Parse(Console.ReadLine());

            Console.Write("Informe o número final: ");
            numFinal = int.Parse(Console.ReadLine());


            while (contador <= numFinal)
            {
                Console.WriteLine($"{fator} X {contador} = {fator * contador}");
                //contador = contador + 1;
                contador++;
            }
            Console.WriteLine("*** Fim da Tabuada ***");
        }
    }
}
