using System.Text;

namespace Entidades
{
    public class Conejo : Animal
    {
        public string colorPelaje;

        public Conejo()
        {

        }
        public Conejo(string nombre, int edad) : base(nombre, edad)
        {

        }
        public Conejo(string nombre, int edad, string pelaje) : this(nombre, edad)
        {
            this.colorPelaje = pelaje;
        }

        /// <summary>
        /// Muestra los datos de un conejo
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Es un Conejo ");
            sb.Append($"Pelaje color: {this.colorPelaje}");
            return sb.ToString();
        }
    }
}
