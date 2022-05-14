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
        public Conejo(string nombre) : base(nombre)
        {

        }
        public Conejo(string nombre, string pelaje) : this(nombre)
        {
            this.colorPelaje = pelaje;
        }
        public string Mostrar(Conejo c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar(c));
            sb.Append($"Pelaje {c.colorPelaje}");
            return sb.ToString();
        }
    }
}
