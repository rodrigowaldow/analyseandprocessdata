using System;
using System.IO;

namespace ConsoleAppTeste
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicializando App!");

            Console.WriteLine("Consultando arquivos existentes...");
            FileInfo[] files = Business.ReadFile.GetFiles();

            Console.WriteLine("Acessando dados dos arquivos...");
            var allData = Business.ReadFile.ReadData(files);

            Console.WriteLine("Processando dados dos arquivos...");
            var analysisData = Business.AnalysisData.ProcessData(allData);

            Console.WriteLine("Salvando dados no arquivo...");
            Business.WriteFile.WriteData(analysisData);

            Console.WriteLine("Fim!");
        }
    }
}
