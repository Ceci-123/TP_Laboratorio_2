using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Veterinaria
    {
        //private static string nombre;
        private static Queue<Paciente> filaDePacientes;

        public static string Nombre 
        {
            get { return "Pequeñas Patitas"; }
            
        }

        public static Queue<Paciente> FilaDePacientes { get => filaDePacientes;
            set => filaDePacientes = value;
        }

        static Veterinaria()
        {
            filaDePacientes = new Queue<Paciente>();
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
