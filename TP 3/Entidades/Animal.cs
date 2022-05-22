using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Perro))]
    [XmlInclude(typeof(Gato))]
    [XmlInclude(typeof(Conejo))]
    [XmlInclude(typeof(Hamster))]
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
        public Animal()
        {

        }
        public Animal(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.id = nextId;
            nextId++;
        }

        /// <summary>
        /// Sobrecarga del operador == para saber si un animal es igual a otro
        /// </summary>
        /// <param name="a1">Primer animal a comparar</param>
        /// <param name="a2">Segundo animal a comparar</param>
        /// <returns></returns>
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

        /// <summary>
        /// Sobrecarga del operador != para saber si un animal es igual a otro
        /// </summary>
        /// <param name="a1">Primer animal a comparar</param>
        /// <param name="a2">Segundo animal a comparar</param>
        /// <returns></returns>
        public static bool operator !=(Animal a1, Animal a2)
        {
            return !(a1 == a2);
        }

        /// <summary>
        /// Muestra los datos de un animal
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Mostrar(Animal a)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre {a.Nombre} Id {a.Id} Edad {a.edad}");
            return sb.ToString();
        }
    }
}
