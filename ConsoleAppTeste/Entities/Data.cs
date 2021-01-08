using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTeste.Entities
{
    public class Data
    {
        public List<Seller> Sellers { get; set; }
        public List<Client> Clients { get; set; }
        public List<Sale> Sales { get; set; }

        public Data(List<Seller> sellers, List<Client> clients, List<Sale> sales)
        {
            Sellers = sellers;
            Clients = clients;
            Sales = sales;
        }
    }
}
