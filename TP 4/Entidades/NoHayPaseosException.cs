using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoHayPaseosException : Exception
    {
        public NoHayPaseosException()
        {

        }

        public NoHayPaseosException(string mensaje) : base(mensaje)
        {

        }
        public NoHayPaseosException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
