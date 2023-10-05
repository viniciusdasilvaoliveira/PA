using System;

namespace Aula_05_10_2023_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;

            Console.Write("Informe o Salário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario <= 3000)
            {
                Console.Write($"O Salário reajustado a 50% é {salario * 0.5 + salario}");
            }

            else if (salario <= 7000)
            {
                Console.Write($"O Salário reajustado a 20% é {salario * 0.2 + salario}");
            }

            else if (salario <= 10000)
            {
                Console.Write($"O Salário reajustado a 15% é {salario * 0.15 + salario}");
            }

            else
            {
                Console.Write($"O Salário reajustado a 10% {salario * 0.10 + salario}");
            }
                
           
        }
    }
}
