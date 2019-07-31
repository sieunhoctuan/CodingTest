using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingTest.Library;

namespace CodingTest
{
    class Program
    {        
        static void Main(string[] args)
        {
            var userInput = 0;
            var menu = new Menu();
            do
            {
                Init(menu);
                Console.WriteLine("Do you want to continue?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                var result = Console.ReadLine();
                userInput = Convert.ToInt32(result);
            } while (userInput == 1);
            Environment.Exit(0);
        }   
        
        public static void Init(Menu menu)
        {            
            var userInput = 0;
            var buyInput = 0;
            var sellInput = 0;            
            var colorInput = 0;
            var sizeInput = 0;
            var money = menu.Money;
            do
            {
                userInput = menu.DisplayMenu(money);                           

            } while (userInput > Constanst.Menu.Length);

            if (userInput == 1)
            {
                do
                {
                    buyInput = menu.BuyMenu();
                } while (buyInput > Constanst.BuyMenu.Length);

                if (buyInput == 1 && money > Constanst.Tshirt_Price_Buy)
                {
                    money = menu.BuyItem(Constanst.Tshirt_Price_Buy);
                    do
                    {
                        colorInput = menu.ColorMenu();
                    } while (colorInput > Constanst.ColorMenu.Length);

                    do
                    {
                        sizeInput = menu.SizeMenu();
                    } while (sizeInput > Constanst.SizeMenu.Length);

                }

                else if (buyInput == 2 && money > Constanst.Dressshirt_Price_Buy)
                {
                    money = menu.BuyItem(Constanst.Dressshirt_Price_Buy);
                    do
                    {
                        colorInput = menu.ColorMenu();
                    } while (colorInput > Constanst.ColorMenu.Length);

                    do
                    {
                        sizeInput = menu.SizeMenu();
                    } while (sizeInput > Constanst.SizeMenu.Length);

                }
                else
                {
                    Console.WriteLine("Not enough money");
                }
                Console.WriteLine("you have ${0}", money);                
            }
            else if (userInput == 2)
            {
                do
                {
                    sellInput = menu.SellMenu();
                } while (sellInput > Constanst.SellMenu.Length);

                if (sellInput == 1)
                {
                    money = menu.SellItem(Constanst.Tshirt_Price_Sell);
                    do
                    {
                        colorInput = menu.ColorMenu();
                    } while (colorInput > Constanst.ColorMenu.Length);

                    do
                    {
                        sizeInput = menu.SizeMenu();
                    } while (sizeInput > Constanst.SizeMenu.Length);

                }
                else if (sellInput == 2)
                {
                    money = menu.SellItem(Constanst.Dressshirt_Price_Sell);
                    do
                    {
                        colorInput = menu.ColorMenu();
                    } while (colorInput > Constanst.ColorMenu.Length);

                    do
                    {
                        sizeInput = menu.SizeMenu();
                    } while (sizeInput > Constanst.SizeMenu.Length);

                }
                Console.WriteLine("you have ${0}", money);                
            }
            else
            {
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}
