using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conejo :Animal
    {
        public string colorPelaje;
        public Conejo(string nombre, int edad) : base(nombre, edad)
        {

        }
        public Conejo(string nombre, int edad, 
            string pelaje) : this(nombre, edad)
        {
            this.colorPelaje = pelaje;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Conejo");
            sb.Append($"Pelaje {this.colorPelaje}");
            return sb.ToString();
        }
    }
}
