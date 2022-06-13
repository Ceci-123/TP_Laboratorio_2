using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Entidades
{
    public class Veterinaria
    {
        private static Queue<Paciente> filaDePacientes;
        private static List<Animal> listaAnimales;
        private static Paseador<Perro> paseadorPerros;
        private static Paseador<Gato> paseadorGatos;
        private static int cantidadVacunasPerrunas;
        private static int cantidadVacunasGatunas;

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
        public static int CantidadVacunasPerrunas { get => cantidadVacunasPerrunas; set => cantidadVacunasPerrunas = value; }
        public static int CantidadVacunasGatunas { get => cantidadVacunasGatunas; set => cantidadVacunasGatunas = value; }

        static Veterinaria()
        {
            filaDePacientes = new Queue<Paciente>();
            listaAnimales = new List<Animal>();
            paseadorPerros = new Paseador<Perro>("Paseo Perruno");
            paseadorGatos = new Paseador<Gato>("Paseo Gatuno");
            cantidadVacunasGatunas = 0;
            cantidadVacunasPerrunas = 0;
        }

        /// <summary>
        /// Muestra la queue de pacientes por atender
        /// </summary>
        /// <param name="filaDePacientes"> la queue a mostrar</param>
        /// <returns></returns>
        public static string MostrarFila(Queue<Paciente> filaDePacientes)
        {
            StringBuilder sb = new StringBuilder();
            if (filaDePacientes != null)
            {
                foreach (Paciente item in filaDePacientes)
                {
                    sb.Append(item.Nombre + " ");
                    sb.AppendLine(item.TipoDeAnimal.ToString());
                }
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
                    sb.Append($"id: {item.Id.ToString()}");
                    sb.Append("Nombre: " + item.Nombre + " ");
                    sb.AppendLine("Edad: " + item.Edad.ToString() + " años");
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
            if (lista != null)
            {
                foreach (Animal item in lista)
                {
                    if (item.Id == id)
                    {
                        aux = item;
                        break;
                    }
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
            if (lista is not null)
            {
                try
                {
                    lista = ClassSerializadora.LeerDesdeXml();

                }
                catch (System.Exception)
                {
                    return lista;

                }
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
                if (lista is not null)
                {
                    ClassSerializadora.EscribirAJson(lista);

                }
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
                if (lista is not null)
                {
                    ClassSerializadora.EscribirAXml(lista);

                }
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
                if (paseo.Lista is not null)
                {

                    paseo.Lista = ClassSerializadora.LeerDesdeJson();
                }
                return paseo;
            }
            catch (System.Exception)
            {
                paseo = new Paseador<Perro>(" ");
                return paseo;
            }

        }

        /// <summary>
        /// Lee un archivo de texto en el escritorio con la preferencia de visualizacion
        /// </summary>
        /// <returns>Un string con el modo</returns>
        public static string LeerModoVisualizacion()
        {
            string retorno = " ";
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += "\\carpetaVeterinaria";
            ruta += "\\" + "preferencias.txt";
            try
            {
                using StreamReader fileReader = new StreamReader(ruta);
                retorno = fileReader.ReadToEnd();
                return retorno;

            }
            catch (Exception)
            {
                return retorno;

            }
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
                if (a is Perro && paseadorPerros.Lista is not null)
                {
                    paseadorPerros.AgregarALista((Perro)a, paseadorPerros.Lista);
                }
                if (a is Gato && paseadorGatos.Lista is not null)
                {
                    paseadorGatos.AgregarALista((Gato)a, paseadorGatos.Lista);
                }
            }

        }

        /// <summary>
        /// Guarda en un archivo de texto si el usuario elije modo claro o oscuro
        /// </summary>
        public static void GuardarModoVisualizacion(string modo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += "\\carpetaVeterinaria";
            if (!Directory.Exists(ruta))
            {
                try
                {
                    Directory.CreateDirectory(ruta);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            try
            {
                ruta += "\\" + "preferencias.txt";
                using StreamWriter writer = new StreamWriter(ruta);
                writer.WriteLine("Preferencia actual de visualizacion ");
                writer.WriteLine(modo);
            }
            catch (Exception)
            {

            }
        }
    }
}
