using System.Collections.Generic;

namespace Entidades
{
    public class Paciente
    {
        public enum eAnimal
        {
            Perro,
            Gato,
            Conejo,
            Hamster
        }
        
        private string nombre;
        private eAnimal tipoDeAnimal;

        public string Nombre { get => nombre; set => nombre = value; }
        internal eAnimal TipoDeAnimal { get => tipoDeAnimal; }

        
        public Paciente(string nombre, eAnimal tipo)
        {
            this.nombre = nombre;
            this.tipoDeAnimal = tipo;
            
        }

        public static Queue<Paciente> operator +(Paciente unPaciente, Queue<Paciente> listado)
        {
            Queue<Paciente> retorno = listado;
            if (unPaciente is not null && listado is not null)
            {
                listado.Enqueue(unPaciente);
            }
            return retorno;
        }
    }
}