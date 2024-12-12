using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportClassLibrary.Domain;

namespace TransportClassLibrary.Factories
{
    public class BusFactory : AbstractTransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Bus(100, 30000, "A reliable and large-capacity bus.");
        }
    }
}
