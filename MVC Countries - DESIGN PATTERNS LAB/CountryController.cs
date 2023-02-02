using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries___DESIGN_PATTERNS_LAB
{
    public class CountryController
    {
        List<Country> CountryDb = new List<Country>()
       
         {
             new Country("USA", "North America", new List<string> {"Red","White","Blue"}),
             new Country("Germany", "Europe", new List<string> {"Red","White","Blue"}),
             new Country("Canada", "North America", new List<string> {"Red","White","Blue"}),
             new Country("Mexico", "North America", new List<string> {"Red","White","Blue"}),
             new Country("Brazil", "South America", new List<string> {"Red","White","Blue"}),
             new Country("Japan", "Asia", new List<string> {"Red","White","Blue"}),

         };

     
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView cd = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app.Please select a country from the following list: ");
            cd.Display();
            int choice = int.Parse(Console.ReadLine());
            WelcomeAction(int choice);
        }
    }
}

