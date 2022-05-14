using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Veterinaria
    {
        private static Queue<Paciente> filaDePacientes;
        private static List<Animal> listaAnimales;
        private static Paseador<Perro> paseadorPerros;
        private static Paseador<Gato> paseadorGatos;

        public static string Nombre
        {
            get { return "Pequeñas Patitas"; }

        }

        public static Queue<Paciente> FilaDePacientes
        {
            get => filaDePacientes;
            set => filaDePacientes = value;
        }

        public static List<Animal> ListaAnimales
        {
            get => listaAnimales;
            set => listaAnimales = value;
        }
        public static Paseador<Perro> PaseoPerruno
        {
            get => paseadorPerros;
            set => paseadorPerros = value;
        }
        public static Paseador<Gato> PaseoGatuno
        {
            get => paseadorGatos;
            set => paseadorGatos = value;
        }

        static Veterinaria()
        {
            filaDePacientes = new Queue<Paciente>();
            listaAnimales = new List<Animal>();
            paseadorPerros = new Paseador<Perro>("Paseo Perruno");
            paseadorGatos = new Paseador<Gato>("Paseo Gatuno");
        }

        public static string MostrarFila(Queue<Paciente> filaDePacientes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Paciente item in filaDePacientes)
            {
                sb.Append(item.Nombre + " ");
                sb.AppendLine(item.TipoDeAnimal.ToString());
                sb.AppendLine("----------------------------");
            }
            return sb.ToString();
        }

        public static string MostrarLista(List<Animal> lista)
        {
            StringBuilder sb = new StringBuilder();
            if (lista is not null)
            {
                foreach (Animal item in lista)
                {
                    sb.AppendLine($"id de Registro {item.Id.ToString()}");
                    sb.Append(item.Nombre + " ");
                    sb.AppendLine(item.Edad.ToString() + " años");
                    //sb.AppendLine(Animal.Mostrar(item));
                    sb.AppendLine("----------------------------");
                }
            }


            return sb.ToString();
        }

        public static void AgregarAnimal(Animal unAnimal)
        {
            if (unAnimal is not null)
            {

                ListaAnimales.Add(unAnimal);

            }
        }

        public static Animal BuscarAnimalPorId(int id, List<Animal> lista)
        {
            Animal aux = null;
            foreach (Animal item in lista)
            {
                if (item.Id == id)
                {
                    aux = item;
                    break;
                }
            }
            return aux;
        }
        public static bool CargarListaAnimalesDesdeXml(List<Animal> lista)
        {
            return true;
        }

        public static bool GuardarListaAnimalesJson(List<Animal> lista)
        {
            return true;
        }

        public static bool GuardarListaAnimalesEnXml(List<Animal> lista)
        {
            return true;
        }

        public static bool CargarListaAnimalesJson(List<Animal> lista)
        {
            return true;
        }

        public static bool GuardarListaAnimalesDataBase(List<Animal> lista)
        {
            return true;
        }

        public static bool CargarListaAnimalesDataBase(List<Animal> lista)
        {
            return true;
        }

        public static bool AgregarAPaseos(Animal a)
        {
            bool retorno = false;
            if (a is not null)
            {
                if (a is Perro)
                {
                    paseadorPerros.AgregarALista((Perro)a, paseadorPerros.Lista);
                }
                if (a is Gato)
                {
                    paseadorGatos.AgregarALista((Gato)a,paseadorGatos.Lista);
                }
            }
            return retorno;
        }
    }
}
