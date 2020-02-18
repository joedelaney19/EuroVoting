using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create list of country objects
            List<Country> CountryList = new List<Country>();

            // Create lists to iterate through when instantiating each country object
            string[] countryNames = { "Austria", "Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic", 
                "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy",
                "Latvia", "Lithuania", "Luxembourg", "Malta", "Netherlands", "Poland", "Portugal", "Romania", 
                "Slovakia", "Slovenia", "Spain", "Sweden" };

            double[] weightingsList = { 1.98, 2.56, 1.56, 0.91, 0.20, 2.35, 1.30, 0.30, 1.23, 14.98, 18.54, 2.40,
                2.18, 1.10, 13.65, 0.43, 0.62, 0.14, 0.11, 3.89, 8.49, 2.30, 4.34, 1.22, 0.47, 10.49, 2.29 };

            bool[] euroZoneList = { true, true, false, false, true, false, false, true, true, true, true, true, 
                false, true, true, true, true, true, true, true, false, true, false, true, true, true, false };

            // Iterate through country attributes and instantiate each object
            for(int i = 0; i < countryNames.Length; i++)
            {
                CountryList.Add(new Country(countryNames[i], weightingsList[i], euroZoneList[i]));
                Console.WriteLine($"{i + 1}: {countryNames[i]}, weighting: {weightingsList[i]}, eurozone: {euroZoneList[i]}");
            }
            Console.ReadLine();
        }

        class Country
        {
            private string name_;
            public string name
            {
                get { return name_; }
            }
            private double weighting_;
            public double weighting
            {
                get { return weighting_; }
            }
            private int vote_ = 1;
            public int vote
            {
                get { return vote_; }
            }
            private bool euroZone_;
            public bool euroZone
            {
                get { return euroZone_; }
            }

            public Country(string name, double weighting, bool euroZone)
            {
                name_ = name;
                weighting_ = weighting;
                euroZone_ = euroZone;
            }
        }
    }
}
