using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClassLibrary.Domain
{
    public interface ITransport
    {
        string Name { get; }
        string Description { get; set; }
        int Speed { get; set; }
        double Cost { get; set; }

        void DisplayInfo();
    }
}
