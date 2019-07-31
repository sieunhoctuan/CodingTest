using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Library
{
    public class Menu
    {
        public int Money { get; set; } = 50;

        public int GetMoney()
        {
            return Money;
        }

        public int SellItem(int value)
        {
            return Money += value ;
        }

        public int BuyItem(int value)
        {            
            return Money -= value;            
        }
        public int DisplayMenu(int currentMoney)
        {            
            Console.WriteLine("Buy and sell clothing - You have ${0}", currentMoney);
            Console.WriteLine();
            var array = Constanst.Menu;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, array[i]);
            }

            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }

        public int BuyMenu()
        {
            Console.WriteLine("----------------");
            var array = Constanst.BuyMenu;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, array[i]);
            }
            var result = Console.ReadLine();
            
            return Convert.ToInt32(result);
        }

        public int SellMenu()
        {
            Console.WriteLine("----------------");
            var array = Constanst.SellMenu;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, array[i]);
            }
            var result = Console.ReadLine();

            return Convert.ToInt32(result);
        }        

        public int ColorMenu()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Choose color:");
            var array = Constanst.ColorMenu;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, array[i]);
            }          
            
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }

        public int SizeMenu()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Choose size:");
            var array = Constanst.SizeMenu;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, array[i]);
            }

            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }              
    }
}
