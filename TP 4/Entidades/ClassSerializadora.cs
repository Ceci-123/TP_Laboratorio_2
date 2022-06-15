using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    internal class ClassSerializadora
    {
        static string path;

        static ClassSerializadora()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\ArchivosSerializacion\";
        }

        /// <summary>
        /// Escribe una lista en un archivo de formato Xml
        /// </summary>
        /// <param name="lista">La lista a escribir</param>
        /// <exception cref="Exception"></exception>
        public static void EscribirAXml(List<Animal> lista)
        {
            string nombreArchivo = path + "SerializacionXml"  + ".xml";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Animal>));
                    xmlSerializer.Serialize(streamWriter, lista);
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Lee datos desde un archivo de formato Xml y los guarda en una lista
        /// </summary>
        /// <param name="lista">La lista donde guardar los datos</param>
        /// <exception cref="Exception"></exception>
        public static List<Animal> LeerDesdeXml()
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            List<Animal> animalitos = null;
            try
            {

                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains("SerializacionXml"))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        using (StreamReader sr = new StreamReader(archivo))
                        {

                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Animal>));
                            animalitos = (List<Animal>)xmlSerializer.Deserialize(sr);

                        }
                    }
                }

                return animalitos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }

        /// <summary>
        /// Escribe los datos de la lista en un archivo de formato Json
        /// </summary>
        /// <param name="lista">La lista donde se leen los datos</param>
        /// <exception cref="Exception"></exception>
        public static void EscribirAJson(Paseador<Perro> lista)
        {
            string nombreArchivo = path + "SerializacionJson" + ".JSON";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }


                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(lista));

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }

        /// <summary>
        /// Guarda en una lista los datos que lee desde un archivo Json
        /// </summary>
        /// <returns>La lista con los datos cargados</returns>
        /// <exception cref="Exception"></exception>
        public static List<Perro> LeerDesdeJson()
        {
           
            string archivo = path + "SerializacionJson" + ".JSON";
            List<Perro> datosRecuperados = new List<Perro>();
            try
            {

                if (Directory.Exists(path))
                {

                    if (archivo != null)
                    {
                      datosRecuperados = JsonSerializer.Deserialize<List<Perro>>(File.ReadAllText(archivo));
                    }
                }
                
                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }


    }
}
