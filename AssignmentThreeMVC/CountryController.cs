using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeMVC
{
    class CountryController
    {
        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);
            cd.Display();
        }

        public void CountryMenu()
        {
            bool validInput;

            do
            {
                do
                {
                    string input = ContinentSelectionView.SelectContinet();
                    if (input.ToLower() == "north america")
                    {
                        PickedNADB();
                        validInput = true;
                    }
                    else if (input.ToLower() == "asia")
                    {
                        PickedASDB();
                        validInput = true;
                    }
                    else
                    {
                        validInput = false;
                    }
                } while (validInput == false);
                do
                {
                    if (Char.TryParse(ValidationViewer.YorN(), out char yOrN));
                    {
                        if (yOrN == 'y')
                        {
                            //breaks out of inner loop and replays outer loop
                            validInput = false;
                            break;
                        }
                        else if (yOrN == 'n')
                        {
                            //breaks out of inner loop and ends outer loop
                            validInput = true;
                            break;
                        }
                        else
                        {
                            //replays inner loop
                            validInput = false;
                            ValidationViewer.NotValidInput();
                        }
                    }
                } while (validInput == false);

            } while (validInput == false);
            

        }

        private void PickedASDB()
        {
            List<string> countryNames = new List<string>();
            List<Country> countries = new List<Country>();
            string input;
            bool validInput = false;
            AsiaDB nadb = new AsiaDB();
            countries = nadb.Countries;
            foreach (Country item in countries)
            {
                countryNames.Add(item.Name);
            }
            do
            {
                input = CountrySelectionView.SelectCountry(countryNames);
                if (countryNames.Contains(input))
                {
                    foreach (Country item in countries)
                    {
                        if (item.Name == input)
                        {
                            CountrySelectionView.Detail(item);
                            validInput = true;
                        }
                    }
                }
                else
                {
                    validInput = false;
                    ValidationViewer.NotValidInput();
                }
            } while (validInput == false);
            
        }

        private void PickedNADB()
        {
            List<string> countryNames = new List<string>();
            List<Country> countries = new List<Country>();
            string input;
            bool validInput = false;
            NorthAmericaDB nadb = new NorthAmericaDB();
            countries = nadb.Countries;
            foreach (Country item in countries)
            {
                countryNames.Add(item.Name);
            }
            do
            {
                input = CountrySelectionView.SelectCountry(countryNames);
                if (countryNames.Contains(input))
                {
                    foreach (Country item in countries)
                    {
                        if (item.Name == input)
                        {
                            validInput = true;
                            CountrySelectionView.Detail(item);
                        }
                    }
                }
                else
                {
                    validInput = false;
                    ValidationViewer.NotValidInput();
                }
            } while (validInput == false); 
        }
    }
}
