using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDate
{
    public static class Ferramentas
    {
       

        public static DateTime SomarDias(DateTime primeiraData, int dias)
        {

            DateTime resultado = primeiraData.AddDays(dias);                 
            
            return resultado;
        }
        public static TimeSpan Diferenca(DateTime primeiraData, DateTime segundaData)
        {
            

            TimeSpan sub = primeiraData.Subtract(segundaData);            
            return sub;

        }
        
        public static TimeSpan DiferencaDias(DateTime primeiraData, DateTime segundaData)
        {
            

            TimeSpan diferenca = primeiraData.Subtract(segundaData);    
            return diferenca;
        }
        public static int DiferencaMeses(DateTime primeiraData, DateTime segundaData)
        {
            int meses = Convert.ToInt32(DiferencaDias(primeiraData, segundaData).TotalDays / 30.44);
            return meses;
        }
        public static int DiferencaAnos(DateTime primeiraData, DateTime segundaData)
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
