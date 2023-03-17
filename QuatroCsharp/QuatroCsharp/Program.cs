using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuatroCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nO valor apresentado na posição três é: " + numeros[2]);

            Console.ReadKey();

        }
    }
}
