using Newtonsoft.Json;
using StockAccountManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StockAccountManagement.Model
{
    public class StockAccount
    {
        public string FilePath = @"C:\\Bridgelabz\\Stock Account Management\\StockAccountManagement\\StockAccountManagement\\StockAccountManagement\\JsonFile\\PortFolio.json";

        public void calculateValueOfEachStocks ()
        {
            var jsonData = File.ReadAllText (FilePath);

            var portFolio = JsonConvert.DeserializeObject<StockModel>(jsonData);

            int totalValueOfStocks = 0;
            foreach(var Stocks in portFolio.Stocks)
            {
                Console.WriteLine("Share Name : " + Stocks.shareName + "\t\t" + "Share Price : " + Stocks.sharePrice + "\t \t" + "Number of share : " + Stocks.numberOfShare);
                int valueOfEachShare = Stocks.numberOfShare * Stocks.sharePrice;
                Console.WriteLine(" Total value of Share : " + valueOfEachShare);
                totalValueOfStocks +=valueOfEachShare;
                Console.WriteLine("");
            }
            Console.WriteLine(" \n Total Amount of All Stocks : " + totalValueOfStocks);
        }
    }
}
