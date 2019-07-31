using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    public class Constanst
    {
        public const int Tshirt_Price_Buy = 6;
        public const int Dressshirt_Price_Buy = 8;

        public const int Tshirt_Price_Sell = 12;
        public const int Dressshirt_Price_Sell = 20;

        public static readonly string[] Menu = { "Buy clothes", "Sell clothes", "Exit" };
        public static readonly string[] BuyMenu = { "T-Shirt: $6", "Dress Shirt: $8"};
        public static readonly string[] SellMenu = { "T-Shirt: $12", "Dress Shirt: $20" };
        public static readonly string[] ColorMenu = {"Red", "White"};
        public static readonly string[] SizeMenu = { "S", "M" };

        
    }
}
