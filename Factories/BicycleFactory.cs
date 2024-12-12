using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportClassLibrary.Domain;

namespace TransportClassLibrary.Factories
{
    public class BicycleFactory : AbstractTransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Bicycle(25, 500, "An eco-friendly and healthy bicycle.");
        }
    }
}
