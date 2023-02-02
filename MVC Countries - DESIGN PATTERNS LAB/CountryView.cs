using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Countries___DESIGN_PATTERNS_LAB
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
            
        }

        // constructor

        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name} ${DisplayCountry.Continent} ${DisplayCountry.Colors}");
            foreach(string flagColor in DisplayCountry.Colors) 
            {
               Enum.Parse(typeof(Color), flagColor);
                Console.WriteLine(flagColor);
            }
        }



    }


}
