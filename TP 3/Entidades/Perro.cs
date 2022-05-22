using System;
using System.Text;

namespace Entidades
{
    public class Perro : Animal, IVacunable
    {
        private int peso;
        private string raza;
        private bool vacunado;

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

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Peso {this.Peso} Raza {this.Raza}");
            if (vacunado)
            {
                sb.Append($"Todas sus vacunas al dia");
            }
            return sb.ToString();
        }

        public bool Vacunacion()
        {
            return true;
        }
    }
}
