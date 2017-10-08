using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Banker
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            Banker lucy = new Banker();

            do
            {
                Console.WriteLine("Do you want to (D)eposit money or (W)ithdraw money or (S)ee your balance or (Q)uit");
                response = Console.ReadLine();

                if (response == "D" )
                {
                    int DAmount;
                    string SAmount;

                    Console.WriteLine( " Enter the amount you want to deposit " );
                    SAmount = Console.ReadLine();
                    int.TryParse(SAmount, out DAmount);

                    lucy.Deposit(DAmount);

                }
                else  if (response == "W")
                {
                    int WAmount;
                    string WSAmount;

                    Console.WriteLine(" Enter the amount you want to withdraw ");
                    WSAmount = Console.ReadLine();
                    int.TryParse(WSAmount, out WAmount);

                    if( lucy.Withdraw(WAmount) == false)
                        Console.WriteLine("Withdrawal failed");

                }
                else if (response == "S")
                {
                    lucy.ShowBalance();
                }


            } while (response != "Q");

            Environment.Exit(0);
        }
    }
}
