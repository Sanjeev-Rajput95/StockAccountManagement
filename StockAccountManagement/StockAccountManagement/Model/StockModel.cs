using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement.Model
{
    public class StockModel
    {
        public List<StockPortFolio> Stocks { get; set; }
    }

    public class StockPortFolio
    {
        public string shareName { get; set; }
        public int sharePrice { get; set; }
        public int numberOfShare { get; set; }
    }
}
