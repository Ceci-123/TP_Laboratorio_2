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
        public eAnimal TipoDeAnimal { get => tipoDeAnimal; }

        
        public Paciente(string nombre, eAnimal tipo)
        {
            this.nombre = nombre;
            this.tipoDeAnimal = tipo;
            
        }
        public Paciente()
        {

        }

        public static Queue<Paciente> operator +(Paciente unPaciente, Queue<Paciente> colaPacientes)
        {
            Queue<Paciente> retorno = colaPacientes;
            if (unPaciente is not null && colaPacientes is not null)
            {
                colaPacientes.Enqueue(unPaciente);
            }
            return retorno;
        }
    }
}