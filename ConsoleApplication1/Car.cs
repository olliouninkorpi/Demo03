using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car
    {
        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDice { get; set; }
        public int DoorCount { get; set; }

        // default constructor
        public Car()
        {
            FuzzyDice = true;
        }

        //parametric constructor
        public Car(string model)
        {
            Model = model;
        }
        // methods

        //add speed
        public void Accelerate()
        {
            Speed = Speed + 5; // Speed += 5
        }
        //slow down
        public void Brake()
        {
            Speed -= 5;
        }
        //print properties
        public void PrintData()
        {
            Console.WriteLine("Car properties:");
            Console.WriteLine("*Model: {0}", Model);
            Console.WriteLine("*Color: {0}", Color);
            Console.WriteLine("*Engine: {0}", Engine);
            Console.WriteLine("*Speed: {0}", Speed);
            Console.WriteLine("*Fuzzy Dice: {0}", FuzzyDice);
            Console.WriteLine("*Door count: {0}", DoorCount);

        }
    }
}
