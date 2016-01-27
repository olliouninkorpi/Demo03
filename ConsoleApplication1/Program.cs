using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new car object
            Car car = new Car();
            car.PrintData();
            car.Model = "Merseedes V5";
            car.Color = "Black";
            car.Engine = 3.2;
            car.DoorCount = 9;
            car.Accelerate();
            car.PrintData();

            //create another car object
            string model = "Vormula";
            Car car2 = new Car(model);
            car2.PrintData();
            car2.Color = "Green";
            car2.Engine = 2.1;
            car2.DoorCount = 4;
            car2.FuzzyDice = false;
            car2.Brake();
            car2.PrintData();

            Console.ReadLine();
        }
    }
}
