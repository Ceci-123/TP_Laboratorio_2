using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato :Animal, IVacunable, IPaseable
    {
        public bool vacunado;
        public string raza;

        public Gato()
        {

        }
        public Gato(string nombre, int edad) : base(nombre, edad)
        {

        }
        
        public Gato(string nombre, int edad, bool vacunado, string raza) : this(nombre, edad)
        {
            this.vacunado = vacunado;
            this.raza = raza;
        }

        /// <summary>
        /// Muestra los datos de un gato
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Gato");
            sb.AppendLine(this.raza);
            if (vacunado)
            {
                sb.Append($"Tiene sus vacunas al dia");

            }
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Vacunacion()
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Pasear()
        {
            return true;
        }
    }
}
