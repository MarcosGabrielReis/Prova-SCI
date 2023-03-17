using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoisCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int menor = int.MaxValue;
            int maior = int.MinValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            Console.WriteLine("\nO menor número é: " + menor);
            Console.WriteLine("O maior número é: " + maior);

            Console.ReadKey();

        }
    }
}
