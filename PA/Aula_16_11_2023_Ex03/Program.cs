using System;

namespace Aula_16_11_2023_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, contador = 0, somaIdade = 0;

            do
            {
                Console.Write("Informe as idades para obter a media:");
                idade = int.Parse(Console.ReadLine());
                contador++;
                if (idade == 0)
                    break;
                somaIdade += idade;

            } while (idade != 0);
            {
                Console.Write($"A media das idades: {somaIdade / contador}");
            }

        }
    }
}
