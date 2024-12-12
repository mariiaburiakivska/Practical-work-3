using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClassLibrary.Domain
{
    public class Bicycle : ITransport
    {
        public string Name { get; } = "Bicycle";
        public string Description { get; set; }
        public int Speed { get; set; }
        public double Cost { get; set; }

        public Bicycle(int speed, double cost, string description)
        {
            Speed = speed;
            Cost = cost;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Transport: {Name}\nDescription: {Description}\nSpeed: {Speed} km/h\nCost: {Cost} $");
        }
    }
}
