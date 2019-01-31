using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeMVC
{
    class ContinentSelectionView
    {

        public static string SelectContinet()
            {
            Console.WriteLine("What Continent Would you like to learn about?");
            Console.Write("North America or Asia: ");
            string input = Console.ReadLine();
            Console.WriteLine("");
            return input;
        }


    }
}
