using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeMVC
{
    class Program
    {
        static void Main(string[] args)
        {

            //still need to make two country lists
            //create a menu that allows you to select a country
            CountryController cc = new CountryController();
            cc.CountryMenu();
            //string[] colors = { "red", "white", "blue" };
            //Country c = new Country("United States", "English", "Hello World", colors);
            
        }
    }
}
