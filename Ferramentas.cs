using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDate
{
    public static class Ferramentas
    {
        public static DateTime SomarDias(string data, int dias)
        {
            string dia = data.Substring(0, 2);
            string mes = data.Substring(3, 2);
            string ano = data.Substring(6);
            string dataEUA = $"{ano}/{mes}/{dia}";

            DateTime dataC = Convert.ToDateTime(dataEUA);
            DateTime resultado = dataC.AddDays(dias);
            return resultado;
        }
        public static TimeSpan DiferencaDias(string primeiraData, string segundaData)
        {
            string dia1 = primeiraData.Substring(0, 2);
            string mes1 = primeiraData.Substring(3, 2);
            string ano1 = primeiraData.Substring(6);
            string dataEUA1 = $"{ano1}/{mes1}/{dia1}";
            DateTime dataB = Convert.ToDateTime(dataEUA1);

            string dia2 = segundaData.Substring(0, 2);
            string mes2 = segundaData.Substring(3, 2);
            string ano2 = segundaData.Substring(6);
            string dataEUA2 = $"{ano2}/{mes2}/{dia2}";
            DateTime dataC = Convert.ToDateTime(dataEUA2);

            TimeSpan diferenca = dataC.Subtract(dataB);
            return diferenca;
        }       
        public static void Menu()
        {
            Console.WriteLine("1-SOMAR DIAS\n2-DIFERENÇA ENTRE DATAS\n");
            Console.Write("DIGITE A NUMERAÇÃO CORRESPONDENTE A SUA ESCOLHA:(");            
        }
        
    }
}
