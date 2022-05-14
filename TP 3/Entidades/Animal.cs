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

        public static bool operator ==(Animal a1, Animal a2)
        {
            bool retorno = false;
            if (a1 == null && a2 == null)
            {
                if(a1.Id == a2.Id)
                {
                    retorno = true;
                }  
            }
            return retorno;
        }
        public static bool operator !=(Animal a1, Animal a2)
        {
            return !(a1 == a2);
        }

        public static string Mostrar(Animal a)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre {a.Nombre} Id {a.Id} Edad {a.edad}");
            return sb.ToString();
        }
    }
}
