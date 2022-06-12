using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hamster :Animal
    {
        public Hamster()
        {

        }
        public Hamster(string nombre, int edad) : base(nombre, edad)
        {

        }

        /// <summary>
        /// Muestra los datos de un hamster
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Es un Hamster");
            return sb.ToString();
        }
    }
}
