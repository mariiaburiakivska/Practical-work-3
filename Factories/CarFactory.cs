using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportClassLibrary.Domain;

namespace TransportClassLibrary.Factories
{
    public class CarFactory : AbstractTransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Car(150, 20000, "A fast and comfortable car.");
        }
    }
}
