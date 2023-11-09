using System;

namespace Aula_09_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "S";
           

            while (resposta.ToUpper() == "S")
            {
                Console.Clear();

                CalcularTabuada();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Deseja continuar? (S/N)");
                resposta = Console.ReadLine();
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***FIM***");
        }
        static void CalcularTabuada()
        {
            int fator;

            Console.WriteLine("Digite o fator desejado: ");
            fator = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                if (contador % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine($"{fator} X {contador} = {fator * contador}");
            }

        }

    }
}
