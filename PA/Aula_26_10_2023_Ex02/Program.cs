using System;

namespace Aula_26_10_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorFinanciado, valorParcela;
            int qtParcela;
            int contador = 1;

            Console.Write("Informe o valor financiado: R$");
            valorFinanciado = float.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de parcelas: ");
            qtParcela = int.Parse(Console.ReadLine());

            valorParcela = valorFinanciado / qtParcela;

            DateTime data = DateTime.Now.Date;

            while (contador <= qtParcela)
            {
                //Console.Write($"O valor da {contador} é de: R$ {valorFinanciado / qtParcela}");
                Console.WriteLine($"{contador}° parcela: {valorParcela:0.00}");
                Console.WriteLine("");
                //Console.WriteLine($"{contador}° parcela: ({data}): {valorFinanciado / qtParcela:0.00}");
                contador++;
                data = data.AddMonths(1);
            }
        }
    }
}
