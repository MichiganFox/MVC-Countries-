using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries___DESIGN_PATTERNS_LAB
{
    public class CountryListView
    {
        //Porperty 
        public List<Country>Countries { get; set; } 

        //Constructor
        public CountryListView(List<Country> _countries)  
        {
            Countries = _countries;
        }
    
        public void Display()
        {
            int i = 0;
            foreach(Country c in Countries)
            {
                Console.WriteLine($"{i++}. {c.Name}");
            }
        }
    }
}
    


