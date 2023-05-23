using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia a data de nascimento de uma pessoa e calcule a sua idade em anos, meses e dias

            Console.Write("\nInforme sua data da nascimento: ");
            DateTime dtNasc = DateTime.Parse(Console.ReadLine());

            DateTime dtAtual = DateTime.Now;
            TimeSpan span = dtAtual - dtNasc;
            DateTime idade = DateTime.MinValue + span; //soma o intervalo a data 01/01/0001

            // Faz o ajuste devido ao MinValue
            int anos = idade.Year - 1;
            int meses = idade.Month - 1;
            int dias = idade.Day - 1;

            // Imprime
            Console.WriteLine("{0} anos, {1} meses, {2} dias", anos, meses, dias);
        }
    }
}
