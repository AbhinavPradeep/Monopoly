using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Banker
{
    class Banker
    {
        int balance ;

        public Banker()
        {
            Console.WriteLine("Hello I am your banker Lucy, Welcome Bow WOW !!!");
            balance = 2500 ;
            Console.WriteLine("I am giving you " + balance + " to start the game");
        }

        public bool Withdraw (int WAmount)
        {
            if (balance >= WAmount)
            {
                balance = balance - WAmount;
                Console.WriteLine("You have Withdrawn " + WAmount);
                return true ;
            }
            else
            {
                return false ;
            }
           
        }

        public void Deposit(int DAmount)
        {
            balance = balance + DAmount;
            Console.WriteLine("You have deposited " + DAmount);
        }

        public int ShowBalance()
        {
            Console.WriteLine("Your banlance is " + balance) ;
            return balance;

        }
    }
}
