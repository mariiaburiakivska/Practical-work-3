using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportClassLibrary.Domain;

namespace TransportClassLibrary.Factories
{
    public interface ITransportFactory
    {
        ITransport CreateTransport();
    }
}
