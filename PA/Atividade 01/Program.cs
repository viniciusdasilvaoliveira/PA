using System;

namespace Atividade_01
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            string operador;

            Console.Write("Informe o 1° Número: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Informe o 2° Número: ");
            num2 = float.Parse(Console.ReadLine());

            Console.Write("Informe o operador: ");
            operador = Console.ReadLine();

            if (operador == "+")
                Console.Write($"ADIÇÃO: {num1 + num2}");

            else if (operador == "-")
                Console.Write($"SUBTRAÇÃO: {num1 - num2}");

            else if (operador == "*")
                Console.Write($"MULTIPLICAÇÃO: {num1 * num2}");

            else if (operador == "/")
                Console.Write($"DIVISÃO: {num1 / num2}");
        }
    }
}
