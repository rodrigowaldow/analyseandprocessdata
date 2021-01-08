using ConsoleAppTeste.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTeste.Business
{
    public class AnalysisData
    {
        public static Analyse ProcessData(Data all)
        {
            Analyse analyse = new Analyse();
            analyse.ClientQuantity = GetClientQuantity(all.Clients);
            analyse.SellerQuantity = GetSellerQuantity(all.Sellers);
            analyse.BiggestSaleID = GetBiggestSale(all.Sales);
            analyse.WorstSeller = GetWorstSeller(all.Sales);

            return analyse;
        }

        public static int GetClientQuantity(List<Client> clients)
        {
            return clients.Count;
        }

        public static int GetSellerQuantity(List<Seller> sellers)
        {
            return sellers.Count;
        }

        public static string GetBiggestSale(List<Sale> sales)
        {
            return sales.OrderBy(x => x.Total).LastOrDefault().SaleID;
        }

        public static string GetWorstSeller(List<Sale> sales)
        {
            string worstSaleName = sales.GroupBy(f => f.SalesmanName)
            .Select(p => p.OrderByDescending(x => x.Total).FirstOrDefault().SalesmanName)
            .FirstOrDefault();
                
            return worstSaleName;
        }
    }
}
