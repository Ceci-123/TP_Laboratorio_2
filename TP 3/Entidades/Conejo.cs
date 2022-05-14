using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conejo :Animal
    {
        private string colorPelaje;
        public Conejo(string nombre) : base(nombre)
        {

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
