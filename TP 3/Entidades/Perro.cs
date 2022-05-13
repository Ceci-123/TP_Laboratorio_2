using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro :Animal
    {
        private int peso;
        private string raza;
        private bool vacunado;

        public Perro(string nombre) :base(nombre)
        {

        }

        public int Peso { get => peso; set => peso = value; }
        public string Raza { get => raza; set => raza = value; }
        public bool Vacunado { get => vacunado; set => vacunado = value; }

        public static bool FichaCompleta(Perro unPerro)
        {
            bool retorno = false;
            if(unPerro != null)
            {
                if (unPerro.Edad == 0 && !(String.IsNullOrEmpty(unPerro.Nombre)) &&
                    unPerro.peso == 0 && !(String.IsNullOrEmpty(unPerro.raza))
                    && !unPerro.vacunado)
                {
                    retorno = true;
                }
            }
            return retorno; 
        }
    }
}
