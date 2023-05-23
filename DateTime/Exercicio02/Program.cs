using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia a data de nascimento de uma pessoa e calcule a sua idade

            Console.Write("\nInforme sua data da nascimento (00/00/0000): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            var idade = CalcularIdade(dataNascimento);

            Console.Write("Você tem {0} anos.", idade);
        }
        static int CalcularIdade(DateTime dataNascimento)
        {
            var idade = 0;
            idade = DateTime.Today.Year - dataNascimento.Year;
            if (DateTime.Today.DayOfYear < dataNascimento.DayOfYear)
                idade = idade - 1;
            return idade;
        }
    }
}
