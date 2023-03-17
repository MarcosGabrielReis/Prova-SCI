using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int soma = 0;
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                numeros[i] = int.Parse(Console.ReadLine());

                soma += numeros[i];

                if (numeros[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("\nNúmeros pares:");
            for (int i = 0; i < 5; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.WriteLine("\nNúmeros ímpares:");
            for (int i = 0; i < 5; i++)
            {
                if (numeros[i] % 2 != 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }

            Console.WriteLine("\nMédia geral: " + (soma / 5));

            Console.ReadKey();  
        }



    }
    
}
