using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeMVC
{
    class ValidationViewer
    {
        public static void NotValidInput()
        {
            Console.WriteLine("Sorry you did not put in a valid Option.");
        }

        public static string YorN()
        {
            Console.WriteLine("Do you want to run again? (Y or N):");
            return Console.ReadLine();
        }
    }
}
