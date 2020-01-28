using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal myCash = 5000.00m;
            decimal bitCoin = 0m;
            decimal etherium = 0;
            decimal liteCoin = 0;

            do
            {

                Console.WriteLine("\nPlease select an option:\n\nD) Make Deposit\nW) Buy Etheriumd\nE) Check Etherium Balance\nB) Check Bitcoin Balance\nL) Check LiteCoin Balance\n ");
                ConsoleKey userChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (userChoice)
                {
                    case ConsoleKey.D:
                        Console.WriteLine("\nEnter a dollar amount to be deposited: $\n");
                        string amount = Console.ReadLine();
                        myCash = myCash + Convert.ToDecimal(amount);
                        Console.WriteLine("\nThank you, your deposit has been recieved.\n\nYour new cash balance is " + myCash + ".\n");
                        break;

                    case ConsoleKey.W:
                        Console.WriteLine("\nEnter amount to be converted to Etherium:\n");
                        string remove = Console.ReadLine();
                        myCash = myCash - Convert.ToDecimal(remove);
                        decimal etheriumAdd = Convert.ToDecimal(remove);
                        decimal etheriumWorth = 586.15m;
                        etherium = etheriumAdd / etheriumWorth;
                        decimal myEtherium = etheriumAdd;
                        Console.WriteLine("\nThank you, you have converted " + Convert.ToDecimal(remove) + " cash into etherium and your balance is " + etherium + ".");
                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("\nEnter amount to be converted to BitCoin:\n");
                        string removeb = Console.ReadLine();
                        myCash = myCash - Convert.ToDecimal(removeb);
                        decimal bitCoinAdd = Convert.ToDecimal(removeb);
                        decimal bitCoinWorth = 7480m;
                        etherium = bitCoinAdd / bitCoinWorth;
                        decimal mybitCoin = bitCoinAdd;
                        Console.WriteLine("\nThank you, you have converted " + Convert.ToDecimal(removeb) + " cash into BitCoin and your balance is " + bitCoin + ".");
                        break;


                    case ConsoleKey.L:
                        Console.WriteLine("\nEnter amount to be converted to LiteCoin:\n");
                        string removel = Console.ReadLine();
                        myCash = myCash - Convert.ToDecimal(removel);
                        decimal liteCoinAdd = Convert.ToDecimal(removel);
                        decimal liteCoinWorth = 119.04m;
                        liteCoin = liteCoinAdd / liteCoinWorth;
                        decimal myliteCoin = liteCoinAdd;
                        Console.WriteLine("\nThank you, you have converted " + Convert.ToDecimal(removel) + " cash into LiteCoin and your balance is " + liteCoin + ".");
                        break;


                    default:
                        Console.WriteLine("That was not a valid input choice: ");
                        break;

                }//end switch


            } while (myCash!=0);

        }
    }
}
