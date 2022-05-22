using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hamster :Animal
    {
        public Hamster(string nombre, int edad) : base(nombre, edad)
        {

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hamster");
            return sb.ToString();
        }
    }
}
