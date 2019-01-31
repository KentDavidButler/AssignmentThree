using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeMVC
{
    class AsiaDB
    {
        public List<Country> Countries = new List<Country>();

        public AsiaDB()
        {
            string[] cnColors = { "Red", "Gold" };
            Countries.Add(new Country("China", "Mandarin", "Nǐ hǎo, shìjiè!", cnColors));
            string[] jpColors = { "Red", "White" };
            Countries.Add(new Country("Japan", "Japanese", "Kon'nichiwa sekai!", jpColors));
            string[] thColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("Thiland", "Thai", "S̄wạs̄dī chāw lok", thColors));
            string[] inColors = { "Saffron", "White", "India Green" };
            Countries.Add(new Country("India", "Hindi, Bengali, Tamil", "namaste duniya! Ōhē biśba! Vaṇakkam ulakam!", thColors));
            string[] skColors = { "Red", "White", "Blue", "Black" };
            Countries.Add(new Country("South Korea", "Korean", "annyeong sesang!", thColors));

        }
    }
}
