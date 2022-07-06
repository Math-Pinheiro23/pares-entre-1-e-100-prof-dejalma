using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pares_entre_1_e_100_prof_dejalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aluno: Matheus Cardoso Pinheiro
            //R.A: 6322095
            //Curso: Análise e Desenvolvimento de Sistemas.
            //Semestre: 1°

            Console.WriteLine("Contador do 1 ao 100 de números pares");

            int num1, num2;

            num1 = 2;
            num2 = 100;

            for (; num1 <= num2; num1 = +2)
            {
                Console.WriteLine(num1++);
            }

            Console.ReadKey();
        }
    }
}
