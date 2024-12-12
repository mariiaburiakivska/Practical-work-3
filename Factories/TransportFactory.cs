using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportClassLibrary.Domain;

namespace TransportClassLibrary.Factories
{
    public abstract class AbstractTransportFactory : ITransportFactory
    {
        public abstract ITransport CreateTransport();

    }
}
