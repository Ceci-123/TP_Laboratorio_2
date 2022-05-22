using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato :Animal, IVacunable
    {
        public bool vacunado;
        public Gato(string nombre, int edad) : base(nombre, edad)
        {

        }

        public Gato(string nombre, int edad, bool vacunado) : this(nombre, edad)
        {
            this.vacunado = vacunado;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            if (vacunado)
            {
                sb.Append($"Tiene sus vacunas al dia");

            }
            return sb.ToString();
        }

        public bool Vacunacion()
        {
            return true;
        }
    }
}
