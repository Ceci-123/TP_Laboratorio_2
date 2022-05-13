using System;

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
    }
}
