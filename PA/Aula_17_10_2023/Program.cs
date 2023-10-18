using System;

namespace Aula_17_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, resultado;
            string operador;

            Console.Write("Informe o 1° Número: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Informe o 2° Número: ");
            num2 = float.Parse(Console.ReadLine());

            Console.Write("Informe o operador: ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado é: " + resultado);
                    break;
                case "/":
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado é:" + resultado);
                    break;
                default:
                    Console.WriteLine("Operador Invalido");
                    break;
            }
        }
    }
}
