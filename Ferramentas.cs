using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaData
{
    public static class Ferramentas
    {
        public static DateTime SeparaData1(string primeiraData)
        {
            string dia = primeiraData.Substring(0, 2);
            string mes = primeiraData.Substring(3, 2);
            string ano = primeiraData.Substring(6);
            string hora = primeiraData.Substring(11,2);
            string minuto = primeiraData.Substring(14,2);
            string segundo = primeiraData.Substring(17,2);
            string dataEUA = $"{ano}/{mes}/{dia} {hora}:{minuto}:{segundo}";
            DateTime dataB = Convert.ToDateTime(dataEUA);
            return dataB;
        }
        public static DateTime SeparaData2(string segundaData)
        {
            string dia = segundaData.Substring(0, 2);
            string mes = segundaData.Substring(3, 2);
            string ano = segundaData.Substring(6);
            string hora = segundaData.Substring(11, 2);
            string minuto = segundaData.Substring(14, 2);
            string segundo = segundaData.Substring(17, 2);
            string dataEUA = $"{ano}/{mes}/{dia} {hora}:{minuto}:{segundo}";
            DateTime dataC = Convert.ToDateTime(dataEUA);
            return dataC;
        }

        public static DateTime SomarDias(string primeiraData, int dias)
        {           
            DateTime resultado = SeparaData1(primeiraData).AddDays(dias);
            
            return resultado;
        }       
        public static TimeSpan DiferencaDias(string primeiraData, string segundaData)
        {          
            TimeSpan diferenca = SeparaData1(primeiraData).Subtract(SeparaData2(segundaData));            
            return diferenca;
        }        
        public static int DiferencaMeses(string primeiraData, string segundaData)
        {
            int meses = Convert.ToInt32(DiferencaDias(primeiraData,segundaData).TotalDays/30.44);
            return meses;
        }
        public static int DiferencaAnos(string primeiraData, string segundaData)
        {
            int anos = Convert.ToInt32(DiferencaDias(primeiraData, segundaData).TotalDays / 365.25);
            return anos;
        }
        public static void Menu()
        {
            Console.WriteLine("1-SOMAR DIAS\n2-DIFERENÇA ENTRE DATAS\n");
            Console.Write("DIGITE A NUMERAÇÃO CORRESPONDENTE A SUA ESCOLHA:(");
            return;
        }

    }
}

