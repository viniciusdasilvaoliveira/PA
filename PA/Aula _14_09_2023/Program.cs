﻿using System;

namespace Aula__14_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1, n2, n3, n4, media;

            Console.Write("Informe a nota 01: ");
            n1 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a nota 02: ");
            n2 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a nota 03: ");
            n3 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a nota 04: ");
            n4 = decimal.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("A média final é: "+ media);
            Console.WriteLine("A média final é: " + (n1 + n2 + n3 + n4) / 4);
           
        }
    }
}