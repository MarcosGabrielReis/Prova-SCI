using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite o nome do aluno (ou 'sair' para encerrar o programa): ");
                string nome = Console.ReadLine();

                if (nome.ToLower() == "sair")
                {
                    break;
                }

                double soma = 0;
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Digite a " + (i + 1) + "ª nota: ");
                    double nota = double.Parse(Console.ReadLine());
                    soma += nota;
                }

                double media = soma / 4;
                Console.WriteLine("A média do aluno " + nome + " é " + media);

                if (media >= 6)
                {
                    Console.WriteLine("APROVADO");
                }
                else
                {
                    Console.WriteLine("REPROVADO");
                }
                Console.WriteLine();


            }
        }
    }
}
