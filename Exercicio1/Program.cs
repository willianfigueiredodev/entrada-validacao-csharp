using System;

namespace CalculoExceptions
{
    class Calculo
    {
        static void Main()
        {
            bool validaDecisao = false;
            string decisao = "S";
            float numeroA, numeroB, media;

            Console.WriteLine("Calculo de média com dois valores.\n-------------------------------\n");


            while (decisao == "S")
            {
                validaDecisao = false;

                Console.Write("Digite o valor 1: ");
                while (!float.TryParse(Console.ReadLine(), out numeroA))
                {
                    Console.Write("Digite um valor valido: ");
                }

                Console.Write("Digite o valor 2: ");
                while (!float.TryParse(Console.ReadLine(), out numeroB))
                {
                    Console.Write("Digite um valor valido: ");
                }

                media = (numeroA + numeroB) / 2;
                Console.WriteLine("\nA média é: " + media);

                while (!validaDecisao)
                {
                    Console.Write("\n-------------------------------\nDeseja refazer o calculo? S/N: ");
                    decisao = Console.ReadLine().ToUpper();

                    switch (decisao)
                    {
                        case "S":
                            Console.WriteLine("Refazendo Cálculo...\n");
                            validaDecisao = true;
                            break;

                        case "N":
                            Console.WriteLine("Encerrando programa...\n");
                            validaDecisao = true;
                            Console.ReadLine();
                            break;

                        default:
                            Console.Write("Digite uma opção válida!: ");
                            break;
                    }
                }
            }
        }
    }
}