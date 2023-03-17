using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] alunos = new string[3, 5];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite o nome do " + (i + 1) + "º aluno: ");
                alunos[i, 0] = Console.ReadLine();

                double soma = 0;
                for (int j = 1; j <= 4; j++)

                {
                    Console.Write("Digite a " + j + "ª nota: ");
                    double nota = double.Parse(Console.ReadLine());
                    alunos[i, j] = nota.ToString();
                    soma += nota;
                }

                double media = soma / 4;
                alunos[i, 4] = media.ToString();
            }

            double maiorMedia = double.MinValue;
            string nomeMaiorMedia = "";
            double menorMedia = double.MaxValue;
            string nomeMenorMedia = "";

            for (int i = 0; i < 3; i++)
            {
                string nome = alunos[i, 0];
                double media = double.Parse(alunos[i, 4]);

                Console.WriteLine("\nAluno: " + nome);
                Console.WriteLine("Média: " + media);

                if (media > maiorMedia)
                {
                    maiorMedia = media;
                    nomeMaiorMedia = nome;
                }

                if (media < menorMedia)
                {
                    menorMedia = media;
                    nomeMenorMedia = nome;
                }
            }

            Console.WriteLine("\nO aluno com a maior média é: " + nomeMaiorMedia);
            Console.WriteLine("O aluno com a menor média é: " + nomeMenorMedia);

            Console.ReadKey();   
        }
    }
}
