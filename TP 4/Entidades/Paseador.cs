using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paseador<T> where T: Animal
    {
        private List<T> lista;
        private string nombrePaseador;

        public List<T> Lista { get => lista; set => lista = value; }
        public string NombrePaseador { get => nombrePaseador; }

        public int TamañoManada { get => lista.Count(); }

        public Paseador(string nombre)
        {
           this.lista = new List<T>();
           this.nombrePaseador = nombre;
        }

        /// <summary>
        /// Agrega un objeto de tipo T a la lista de paseos
        /// </summary>
        /// <param name="t">El objeto a agregar</param>
        /// <param name="lista">La lista donde se agrega el objeto</param>
        public void AgregarALista(T t, List<T> lista)
        {
           if(t is not null && lista is not null)
            {
               lista.Add(t);

            }

            
        }

        /// <summary>
        /// Muestra la lista de paseos
        /// </summary>
        /// <returns>Un string con los datos de la lista</returns>
        public string MostrarListaPaseos()
        {
            StringBuilder sb = new StringBuilder();
            if(lista is not null)
            {
                foreach (T item in this.lista)
                {
                    sb.AppendLine($"Nombre {item.Nombre} Edad {item.Edad} ");
                }
            }
            if(lista.Count == 0)
            {
                throw new NoHayPaseosException("No hay paseos que mostrar");
                //sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
