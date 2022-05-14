using System;
using System.Text;

namespace Entidades
{
    public class Perro : Animal
    {
        private int peso;
        private string raza;
        private bool vacunado;

        public Perro(string nombre) : base(nombre)
        {

        }

        public Perro(string nombre, int peso, string raza, bool vacunado) :this(nombre)
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

        public string Mostrar(Perro p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar(p));
            sb.Append($"Peso {p.Peso} Raza {p.Raza} Vacunado {p.Vacunado}");
            return sb.ToString();
        }
    }
}
