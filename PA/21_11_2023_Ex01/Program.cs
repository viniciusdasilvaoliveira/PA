using System;

namespace _21_11_2023_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura, maiorAltura = 0, menorAltura = 0;

            for (int contador = 1; contador <=15; contador++)
            {
                Console.Write($"Informe a Altura da {contador}° Pessoa: ");
                altura = float.Parse(Console.ReadLine());


                if (altura >= maiorAltura)
                    maiorAltura = altura;

                if (altura <= menorAltura || menorAltura == 0)
                    menorAltura = altura;

            }
                Console.WriteLine($"MAIOR ALTURA: {maiorAltura}");
                Console.WriteLine($"MENOR ALTURA: {menorAltura}");
        }
    }
}
