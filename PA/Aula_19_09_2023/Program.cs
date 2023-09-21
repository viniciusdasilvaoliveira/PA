using System;

namespace Aula_19_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
             float nota1, nota2, nota3, nota4, soma, media;

             Console.Write("Informe a 1° nota: ");
             nota1 = float.Parse(Console.ReadLine());

             Console.Write("Informe a 2° nota: ");
             nota2 = float.Parse(Console.ReadLine());

             Console.Write("Informe a 3° nota: ");
             nota3 = float.Parse(Console.ReadLine());

             Console.Write("Informe a 4° nota: ");
             nota4 = float.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3 + nota4;
            media = soma / 4;

            if (media < 5)
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Poxa que pena!!!");
            }
            
            else if (media < 7)
            {
                Console.WriteLine("Recuperação!");
                Console.WriteLine("Coragem!!!");
            }
            else
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Parabens!!!");
            }

        }
    }
}
