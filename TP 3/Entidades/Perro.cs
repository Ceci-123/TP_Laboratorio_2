using System;
using System.Text;

namespace Entidades
{
    public class Perro : Animal, IVacunable, IPaseable
    {
        private int peso;
        private string raza;
        private bool vacunado;

        public Perro()
        {

        }
            
        public Perro(string nombre, int edad) : base(nombre, edad)
        {

        }

        public Perro(string nombre, int edad, int peso, string raza, bool vacunado) :this(nombre, edad)
        {
            this.peso = peso;
            this.raza = raza;
            this.vacunado = vacunado;
        }

        public int Peso { get => peso; set => peso = value; }
        public string Raza { get => raza; set => raza = value; }
        public bool Vacunado { get => vacunado; set => vacunado = value; }

        /// <summary>
        /// Verifica si el perro tiene su ficha completa con todos los datos
        /// </summary>
        /// <returns>Un booleano</returns>
        public bool FichaCompleta()
        {
            bool retorno = false;

            if (this.Edad != 0 && !(String.IsNullOrEmpty(this.Nombre)) &&
                this.peso != 0 && !(String.IsNullOrEmpty(this.raza))
                && this.vacunado)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Muestra los datos de un perro
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Perro");
            sb.Append($"Peso {this.Peso} Raza {this.Raza}");
            if (vacunado)
            {
                sb.Append($" Todas sus vacunas al dia");
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
