using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato :Animal
    {
        public bool vacunado;
        public Gato(string nombre) : base(nombre)
        {

        }

        public Gato(string nombre, bool vacunado) : this(nombre)
        {
            this.vacunado = vacunado;
        }

        public string Mostrar(Gato g)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar(g));
            sb.Append($"");
            return sb.ToString();
        }
    }
}
