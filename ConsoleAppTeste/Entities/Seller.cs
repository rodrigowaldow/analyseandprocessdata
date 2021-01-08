using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTeste.Entities
{
    public class Seller
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }

        public Seller(string cpf, string name, string salary)
        {
            CPF = cpf;
            Name = name;
            Salary = salary;
        }
    }
}
