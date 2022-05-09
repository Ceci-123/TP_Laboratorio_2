using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Veterinaria
    {
        private static Queue<Paciente> filaDePacientes;
        private static List<Animal> listaAnimales;

        public static string Nombre 
        {
            get { return "Pequeñas Patitas"; }
            
        }

        public static Queue<Paciente> FilaDePacientes { get => filaDePacientes;
            set => filaDePacientes = value;         }

        public static List<Animal> ListaAnimales
        {
            get => listaAnimales;
            set => listaAnimales = value;
        }

        static Veterinaria()
        {
            filaDePacientes = new Queue<Paciente>();
            listaAnimales = new List<Animal>();
        }

        public static string MostrarFila(Queue<Paciente> filaDePacientes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Paciente item in filaDePacientes)
            {
               sb.Append(item.Nombre+ " ");
               sb.AppendLine(item.TipoDeAnimal.ToString());
               sb.AppendLine("----------------------------");
            }
            return sb.ToString();   
        }
    }
}
