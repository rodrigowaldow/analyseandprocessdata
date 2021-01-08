using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTeste.Entities
{
    public class Client
    {
        public string CNPJ { get; set; }
        public string Name { get; set; }
        public string BusinessArea { get; set; }

        public Client(string cnpj, string name, string businessArea)
        {
            CNPJ = cnpj;
            Name = name;
            BusinessArea = businessArea;
        }
    }
}
