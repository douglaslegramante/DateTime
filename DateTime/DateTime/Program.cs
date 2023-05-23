using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração

            DateTime dt = new DateTime();
            Console.WriteLine(dt);

            DateTime dataEntrada = DateTime.Now;
            Console.WriteLine(dataEntrada);

            //Capturar hora
            string hora = DateTime.Now.ToShortTimeString();

            //Capturar data
            string data = DateTime.Now.ToShortDateString();

            //Exibindo modo console
            Console.WriteLine("Data: " + data + " Hora: " + hora);


            //Data atual
            DateTime DataAtual = DateTime.Now;
            //Apresentação da Data em um formato específico Dia/Mês/Ano com dia de 2 dígitos, mês de 2 dígitos e ano de 4 dígitos
            string sDataAtual = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(sDataAtual);

            //Apresentação da data com Data e Hora atual
            string sDataHoraAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine();
            //Data de 2 dias atras
            string Data2d = DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy");
            Console.WriteLine(Data2d);
            //Data de 3 meses atras
            string Data3m = DateTime.Now.AddMonths(-3).ToString("dd/MM/yyyy");
            Console.WriteLine(Data3m);
            //Data de 5 anos atras
            string Data5a = DateTime.Now.AddYears(-5).ToString("dd/MM/yyyy");
            Console.WriteLine(Data5a);
            //Data de 10 anos a Frente
            string Data10a = DateTime.Now.AddYears(10).ToString("dd/MM/yyyy");
            Console.WriteLine(Data10a);

            //Comparando datas
            DateTime dt1 = new DateTime(2008, 12, 29);
            DateTime dt2 = DateTime.Now; // data e hora atuais
            Console.WriteLine(dt1 < dt2); // exibe : True
            Console.WriteLine(dt1 > dt2); // exibe : False

            //Apresentando a diferença em dias de 2 Datas
            DateTime DataOntem = DateTime.Now.AddDays(-1);
            DateTime DataAmanha = DateTime.Now.AddDays(1);

            TimeSpan TSDiferenca = DataAmanha - DataOntem;
            double DiferencaEmDias = TSDiferenca.Days;

            Console.WriteLine("TimeSpan: " + TSDiferenca);
            Console.WriteLine("Diferença em dias: " + DiferencaEmDias);

            Console.ReadKey();
        }
    }
}
