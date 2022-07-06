using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, tbl, media, total;
            string aluno;

            Console.WriteLine("Digite o nome completo do aluno");
            aluno = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota da avaliação: ");
            a1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota da avaliação");
            a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do trabalho");
            tbl = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(aluno);

            media = a1 + a2 + tbl;
            total = media / 3;

            if (total >= 9.5)
            {
                Console.WriteLine("Nota A");
            }

            else if (total >= 7.5)
            {
                Console.WriteLine("Nota B");
            }


            else if (total >= 6.5)
            {
                Console.WriteLine("Nota C");
            }

            else if (total >= 0.2)
            {
                Console.WriteLine("Nota D");

            }

            else if (total <= 0)
            {
                Console.WriteLine("Nota E");

            }

            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}
