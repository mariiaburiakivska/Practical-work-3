using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClassLibrary.Domain
{
    public class Bus : ITransport
    {
        public string Name { get; } = "Bus";
        public string Description { get; set; }
        public int Speed { get; set; }
        public double Cost { get; set; }

        public Bus(int speed, double cost, string description)
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
