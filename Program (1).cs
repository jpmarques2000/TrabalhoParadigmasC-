using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float p1,ma1,mb1, p2, ma2, mb2, spa, media, m1, m2, presenca;
            int qtdaulas, faltas;

            Console.WriteLine("Digite a primeira nota: ");
            p1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Nota do Trabalho 1:  ");
            ma1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Nota do Trabalho 2:  ");
            mb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Segunda Nota: ");
            p2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Nota do Trabalho 1: ");
            ma2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Nota do Trabalho 2: ");
            mb2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Nota da SPA: ");
            spa = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade de Aulas da Disciplina: ");
            qtdaulas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Numero de Faltas da Disciplina: ");
            faltas = int.Parse(Console.ReadLine());

            m1 = (p1 * 0.7f) + (ma1 * 0.2f) + (mb1 * 0.1f);
            m2 = (p2 * 0.7f) + (ma2 * 0.2f) + (mb2 * 0.1f);
            media = ((m1 + spa + (m2 * 2)) / 4);

            presenca = ((float)faltas / (float)qtdaulas) * 100;
            presenca = 100.0f - presenca;

            if (presenca < 75)
            {
                Console.WriteLine("Reprovado por Falta");
            }
            else
            {
                if (media < 3.0)
                {
                    Console.WriteLine("Reprovado por nota");
                }
                else if (media >= 3.0 && media < 5.0)
                {
                    Console.WriteLine("Recuperação");
                }
                else
                {
                    Console.WriteLine("Aprovado");
                }
            }
            
            Console.WriteLine("Media Final = " + media);

            Console.ReadKey();
        }
    }
}
