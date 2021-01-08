using ConsoleAppTeste.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleAppTeste.Business
{
    public class ReadFile
    {
        private static string directoryPath = @"../../../Data/in";

        public static List<Client> clients = new List<Client>();
        public static List<Sale> sales = new List<Sale>();
        public static List<Seller> sellers = new List<Seller>();

        public static FileInfo[] GetFiles()
        {
            DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
            FileInfo[] files = directorySelected.GetFiles("*.dat");

            return files;
        }

        public static Data ReadData(FileInfo[] files)
        {
            Console.WriteLine("Lendo dados existentes...");

            foreach (FileInfo file in files)
            {
                using (FileStream fs = file.OpenRead())
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = String.Empty;

                    Console.WriteLine("Analisando tipo de dado...");
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split("ç", StringSplitOptions.RemoveEmptyEntries);

                        ReadDataByType(data);
                    }
                }
            }

            return new Data(sellers, clients, sales);
        }

        public static void ReadDataByType(string[] data)
        {
            if (data[0] == "001")
            {
                ReadSellerData(data);
            }

            if (data[0] == "002")
            {
                ReadClientData(data);
            }

            if (data[0] == "003")
            {
                ReadSalesData(data);
            }
        }
        public static void ReadSellerData(string[] data)
        {
            Console.WriteLine("Analisando dados do vendedor " + data[2] + "...");

            sellers.Add(new Seller(data[1], data[2], data[3]));
        }

        public static void ReadClientData(string[] data)
        {
            Console.WriteLine("Analisando dados do cliente " + data[2] + "...");

            clients.Add(new Client(data[1], data[2], data[3]));
        }

        public static void ReadSalesData(string[] data)
        {
            Console.WriteLine("Analisando dados das vendas de " + data[3] + "...");

            List<Item> items = new List<Item>();
            string[] itemsData = data[2].Replace("[", string.Empty).Replace("]", string.Empty).Split(",", StringSplitOptions.RemoveEmptyEntries);

            if(data[2].Length != 0)
            {
                items = ReadSalesItemData(itemsData);
            }

            sales.Add(new Sale(data[1], items, data[3]));
        }

        public static List<Item> ReadSalesItemData(string[] itemsSale)
        {
            Console.WriteLine("Analisando dados dos itens da venda...");

            List<Item> items = new List<Item>();

            foreach (string iSale in itemsSale)
            {
                string[] itemData = iSale.Split("-", StringSplitOptions.RemoveEmptyEntries);
                items.Add(new Item(itemData[0], itemData[1], itemData[2]));
            }

            return items;
        }
    }
}
