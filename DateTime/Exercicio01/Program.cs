using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que imprima a data (dd/MM/yyyy) e hora(HH:mm) atual na tela.
            
            DateTime dAtual = new DateTime();
            Console.WriteLine(dAtual);
            DateTime dtAtual = DateTime.Now;
            Console.WriteLine(dtAtual);

            string hora = DateTime.Now.ToString("HH:mm");
            string data = DateTime.Now.ToShortDateString();
            Console.WriteLine("Data: " + data);
            Console.WriteLine("Hora: " + hora);
        }
    }
}
