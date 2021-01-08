using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTeste.Entities
{
    public class Item
    {
        public string ID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Item(string id, string quantity, string price)
        {
            ID = id;
            Quantity = Convert.ToInt32(quantity);
            Price = Convert.ToDouble(price);
        }
    }

}
