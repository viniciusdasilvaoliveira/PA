using System;

namespace _23_11_2023_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto= -1;
            int totalVotoCand01 = 0;
            int totalVotoCand02 = 0;
            int totalVotoCand03 = 0;
            int totalVotoCand04 = 0;
            int totalVotoBranco = 0;
            int totalVotoNulo = 0;
            int totalVotos = 0;

            while (voto != 0)  
            {
                Console.Clear();
                Console.WriteLine("*****Opcões*****");
                Console.WriteLine("-----------------");
                Console.WriteLine("Candidato 01: ");
                Console.WriteLine("Candidato 02: ");
                Console.WriteLine("Candidato 03: ");
                Console.WriteLine("Candidato 04: ");
                Console.WriteLine("Voto Nulo: ");
                Console.WriteLine("Voto Branco: ");
                Console.WriteLine("-----------------");
                Console.Write("Informe o seu voto: ");
                voto = int.Parse(Console.ReadLine());

                //if (voto == 1)
                    //Console.WriteLine("Você votou no 1° candidato ");
                //else if (voto == 2)
                    //Console.WriteLine("Você votou no 2° candidato ");
                //else if (voto == 3)
                    //Console.WriteLine("Você votou no 3° candidato ");
                //else if (voto == 4)
                   // Console.WriteLine("Você votou no 4° candidato ");
                //else if (voto == 5)
                   // Console.WriteLine("VOTO NULO");
                //else if (voto == 6)
                   // Console.WriteLine("VOTO EM BRANCO");//

                switch (voto)
                {
                    case 1:
                        totalVotoCand01 += 1;
                        break;
                    case 2:
                        totalVotoCand02 += 1;
                        break;
                    case 3:
                        totalVotoCand03 += 1;
                        break;
                    case 4:
                        totalVotoCand04 += 1;
                        break;
                    case 5:
                        totalVotoNulo += 1;
                        break;
                    case 6:
                        totalVotoBranco += 1;
                        break;
                    default:
                     if (voto != 0)
                        {
                            Console.WriteLine("VOTO NÃO COMPUTADO ");
                            Console.ReadLine();
                        }
                        break;
                }
            }
                    totalVotos = totalVotoCand01 + totalVotoCand02 + totalVotoCand03 + totalVotoCand04 + totalVotoNulo + totalVotoBranco;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("**********Apuração**********");
                    Console.WriteLine("****************************");
                    Console.WriteLine($"Total de votos Candidato 01: {totalVotoCand01}");
                    Console.WriteLine($"Total de votos Candidato 02: {totalVotoCand02}");
                    Console.WriteLine($"Total de votos Candidato 03: {totalVotoCand03}");
                    Console.WriteLine($"Total de votos Candidato 04: {totalVotoCand04}");
                    Console.WriteLine($"Total votos Nulos: {totalVotoNulo}");
                    Console.WriteLine($"Total votos Brancos: {totalVotoBranco}");
                    Console.WriteLine($"% de Nulos: {(totalVotoNulo / totalVotos) * 100}");
                    Console.WriteLine($"% de Brancos: {(totalVotoBranco / totalVotos) * 100}");

        }
    }
}
