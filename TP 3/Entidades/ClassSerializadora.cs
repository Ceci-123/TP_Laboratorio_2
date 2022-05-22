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

        public static void EscribirAXml(Paciente animalito)
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
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Paciente));
                    xmlSerializer.Serialize(streamWriter, animalito);
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }


        public static Paciente LeerDesdeXml()
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            Paciente animalito = null;
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

                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Paciente));
                            animalito = (Paciente)xmlSerializer.Deserialize(sr);

                        }
                    }
                }

                return animalito;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }

        public static void EscribirAJson(Animal animalito)
        {
            string nombreArchivo = path + "SerializacionJson" + ".JSON";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }


                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(animalito));

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }

        public static Animal LeerDesdeJson()
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            Animal datosRecuperados = default;
            try
            {

                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains("SerializacionJson"))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        datosRecuperados = JsonSerializer.Deserialize<Animal>(File.ReadAllText(archivo));
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
