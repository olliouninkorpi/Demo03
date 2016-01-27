using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            SaunaStove saunastove = new SaunaStove();
            saunastove.Temperature = 900;
            saunastove.Humidity = 22;
            saunastove.PrintData();
            Console.WriteLine(saunastove.ToString());

            Console.WriteLine("Temperature of the Official Sauna Stove = " + saunastove.Temperature);
            Console.ReadLine();
        }
    }
}
