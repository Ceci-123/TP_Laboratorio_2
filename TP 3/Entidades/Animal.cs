using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Animal
    {
        private string nombre;
        private int id;
        private int edad;
        private static int nextId;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public int Edad { get => edad; set => edad = value; }

        static Animal()
        {
            
            nextId = 1;
        }

        public Animal(string nombre)
        {
            this.nombre = nombre;
            this.id = nextId;
            nextId++;
        }
    }
}
