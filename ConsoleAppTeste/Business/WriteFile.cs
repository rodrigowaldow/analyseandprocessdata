using ConsoleAppTeste.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleAppTeste.Business
{
    public class WriteFile
    {
        private static string directoryPath = @"../../../Data/out/";
        private static string fileName = directoryPath + "processedData.done.dat";
        public static void WriteData(Analyse data)
        {
            using (FileStream fs = File.Create(fileName))
            using (StreamWriter sr = new StreamWriter(fs))
            {
                Console.WriteLine("Gerando arquivo processado...");

                Console.WriteLine("Quantidade de clientes no arquivo de entrada: " + data.ClientQuantity);
                Console.WriteLine("Quantidade de vendedores no arquivo de entrada: " + data.SellerQuantity);
                Console.WriteLine("ID da venda mais cara: " + data.BiggestSaleID);
                Console.WriteLine("O pior vendedor: " + data.WorstSeller);

                sr.WriteLine("Quantidade de clientes no arquivo de entrada: " + data.ClientQuantity);
                sr.WriteLine("Quantidade de vendedores no arquivo de entrada: " + data.SellerQuantity);
                sr.WriteLine("ID da venda mais cara: " + data.BiggestSaleID);
                sr.WriteLine("O pior vendedor: " + data.WorstSeller);
            }
        }
    }
}
