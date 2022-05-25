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

        /// <summary>
        /// Devuelve el nombre de la Veterinaria
        /// </summary>
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

        /// <summary>
        /// Muestra la queue de pacientes por atender
        /// </summary>
        /// <param name="filaDePacientes"> la queue a mostrar</param>
        /// <returns></returns>
        public static string MostrarFila(Queue<Paciente> filaDePacientes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Paciente item in filaDePacientes)
            {
                sb.Append(item.Nombre + " ");
                sb.AppendLine(item.TipoDeAnimal.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Muestra la lista de animales
        /// </summary>
        /// <param name="lista">la lista a mostrar</param>
        /// <returns></returns>
        public static string MostrarLista(List<Animal> lista)
        {
            StringBuilder sb = new StringBuilder();
            if (lista is not null)
            {
                foreach (Animal item in lista)
                {
                    sb.Append($"id de Registro {item.Id.ToString()}");
                    sb.Append(item.Nombre + " ");
                    sb.AppendLine(item.Edad.ToString() + " años");
                    if (item is Perro)
                    {
                        sb.AppendLine(((Perro)item).Mostrar());
                    }
                    if (item is Gato)
                    {
                        sb.AppendLine(((Gato)item).Mostrar());

                    }
                    if (item is Conejo)
                    {
                        sb.AppendLine(((Conejo)item).Mostrar());

                    }
                    if (item is Hamster)
                    {
                        sb.AppendLine(((Hamster)item).Mostrar());

                    }
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Agrega un animal a la lista de animales
        /// </summary>
        /// <param name="unAnimal">el animal a agregar</param>
        public static void AgregarAnimal(Animal unAnimal)
        {
            if (unAnimal is not null)
            {
                ListaAnimales.Add(unAnimal);

            }
        }

        /// <summary>
        /// Busca un animal en la lista de animales por su id
        /// </summary>
        /// <param name="id">El id a encontrar</param>
        /// <param name="lista"> La lista donde se busca</param>
        /// <returns></returns>
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

        /// <summary>
        /// Llama a la clase serializadora para cargar la lista de animales desde un archivo de datos Xml
        /// </summary>
        /// <param name="lista">La lista donde se cargan los datos</param>
        /// <returns>La lista cargada</returns>
        public static List<Animal> CargarAnimalesDesdeXml(List<Animal> lista)
        {
            try
            {
                lista = ClassSerializadora.LeerDesdeXml();

            }
            catch (System.Exception)
            {
                return lista;

            }
            return lista;
        }

        /// <summary>
        /// Llama a la clase serializadora para guardar la lista de animales en un archivo en formato Json
        /// </summary>
        /// <param name="lista">La lista a guardar</param>
        /// <returns></returns>
        public static bool GuardarListaAnimalesJson(Paseador<Perro> lista)
        {
            bool retorno = false;
            try
            {
                ClassSerializadora.EscribirAJson(lista);
                retorno = true;
            }
            catch (System.Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Llama a la clase serializadora para guardar una lista de animales en un archivo en formato Xml
        /// </summary>
        /// <param name="lista">La lista a guardar</param>
        /// <returns></returns>
        public static bool GuardarAnimalesEnXml(List<Animal> lista)
        {
            bool retorno = false;

            try
            {
                ClassSerializadora.EscribirAXml(lista);
                retorno = true;
            }
            catch (System.Exception)
            {
                retorno = false;
            }


            return retorno;
        }

        /// <summary>
        /// Llama a la clase serializadora para cargar un archivo en formato Json a la lista de animales de la veterinaria
        /// </summary>
        /// <param name="lista">La lista donde guardar los datos</param>
        /// <returns></returns>
        public static Paseador<Perro> CargarListaAnimalesJson(Paseador<Perro> paseo)
        {
            try
            {
               paseo.Lista = ClassSerializadora.LeerDesdeJson();
            }
            catch (System.Exception)
            {
                return paseo;
            }
            return paseo;
        }

        /// <summary>
        /// Llama a la clase serializadora para guardar la lista de animales en una base de datos
        /// </summary>
        /// <param name="lista">La lista a guardar</param>
        /// <returns></returns>
        public static bool GuardarListaAnimalesDataBase(List<Animal> lista)
        {
            return true;
        }

        /// <summary>
        /// Llama a la clase serializadora para cargar la lista de animales de la veterinaria desde una base de datos
        /// </summary>
        /// <param name="lista">La lista donde se guardan los datos</param>
        /// <returns></returns>
        public static bool CargarListaAnimalesDataBase(List<Animal> lista)
        {
            return true;
        }

        /// <summary>
        /// Se agrega un animal a la lista de paseos de su especie
        /// </summary>
        /// <param name="a">El animal a agregar</param>
        /// <returns></returns>
        public static void AgregarAPaseos(Animal a)
        {
           if (a is not null)
            {
                if (a is Perro)
                {
                    paseadorPerros.AgregarALista((Perro)a, paseadorPerros.Lista);
                }
                if (a is Gato)
                {
                    paseadorGatos.AgregarALista((Gato)a, paseadorGatos.Lista);
                }
            }
           
        }
    }
}
