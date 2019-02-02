using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermPOS
{
    class Validation
    {
        public static bool ValidCategory(string Category)
        {
            if (Category == "stimulants")
            {
                return true;
            }
            else if (Category == "steroids")
            {
                return true;
            }
            else if (Category == "depressants")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again:");
                return false;
            }
        }
        public static int ValidDrug(string num)
        {
            if (int.TryParse(num, out int isNum))
            {
                return isNum;
            }
            else
            {
                return -1;
            }
        }
        public static int Size(string isSize)
        {
            if(int.TryParse(isSize, out int size))
            {
                return size;
            }
            else
            {
                return -1;
            }
        }
        public static bool PurchaseMore()
        {
            Console.WriteLine("Would you like to Purchase More? (y/n)");
            string userContinue = Console.ReadLine().ToLower();
            bool run;
            if (userContinue == "y")
            {
                run = true;
            }
            else if(userContinue == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Invalid response. Please try again: (y/n)");
                run = PurchaseMore();
            }
            return run;
        }
    }
}