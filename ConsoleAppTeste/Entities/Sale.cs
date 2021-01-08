using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTeste.Entities
{
    public class Sale
    {
        public string SaleID { get; set; }
        public List<Item> Items { get; set; }
        public string SalesmanName { get; set; }
        public double Total {
            get {
                return Items.Sum(x => x.Quantity * x.Price);
            }
        }
        public Sale(string id, List<Item> items, string salesmanName)
        {
            SaleID = id;
            Items = items;
            SalesmanName = salesmanName;
        }
    }
}
