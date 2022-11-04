using StockAccountManagement.Model;

namespace StockAccountManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========= WELCOME TO THE STOCK ACCOUNT MANAGEMENT PROGRAM ==========");
            StockAccount account = new StockAccount();
            account.calculateValueOfEachStocks();

        }
    }
}