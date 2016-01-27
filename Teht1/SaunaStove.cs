using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class SaunaStove
    {
        public int Temperature { get; set; }
    
        public int Humidity { get; set; }

        public bool IsOn { get; set; }

        public SaunaStove()
        {
            IsOn = true;
        }

        public void PrintData()
        {
            Console.WriteLine("Sauna Stove properties:");
            Console.WriteLine("*Temperature: {0}", Temperature);
            Console.WriteLine("*Humidity: {0}", Humidity);
            Console.WriteLine("*Is on?: {0}", IsOn);
        }

        // method returns object properties as one string
        public override string ToString()
        {
            return "Temp = " + Temperature + "Humid = " + Humidity + " Is On? = " + IsOn;
        }
    }
}
