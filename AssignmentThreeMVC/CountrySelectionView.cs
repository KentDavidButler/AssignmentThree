using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeMVC
{
    class CountrySelectionView
    {
        internal static string SelectCountry(List<string> countryList)
        {
            Console.WriteLine("What Country Would you like to learn about?");
            foreach (string item in countryList)
            {
                Console.WriteLine($"{item}");
            }
            string input = Console.ReadLine();
            Console.WriteLine("");
            return input;
        }


        public static void Detail(Country country)
        {
            Console.WriteLine($"You selected {country.Name}.");
            Console.WriteLine($"The language they speak is {country.Lang}.");
            Console.WriteLine($"The way to say hello is {country.Hello}.");
            Console.Write($"The colors of the flag are: ");
            foreach (string item in country.Colors)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("");
        }
    }
}
