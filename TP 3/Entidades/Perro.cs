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
    }
}
