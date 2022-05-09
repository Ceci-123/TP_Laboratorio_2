using System.Collections.Generic;

namespace Entidades
{
    public class Paciente
    {
        public enum eAnimal
        {
            Perro,
            Gato,
            Conejo
        }
        private static int nextId;
        private string nombre;
        private int id;
        private eAnimal tipoDeAnimal;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; }
        internal eAnimal TipoDeAnimal { get => tipoDeAnimal; }

        static Paciente()
        {
            nextId = 1;
        }
        public Paciente(string nombre, eAnimal tipo)
        {
            this.nombre = nombre;
            this.tipoDeAnimal = tipo;
            this.id = nextId;
            nextId++;
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