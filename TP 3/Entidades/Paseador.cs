﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paseador<T> where T: Animal
    {
        private List<T> lista;
        private string nombrePaseador;

        public List<T> Lista { get => lista; set => lista = value; }
        public string NombrePaseador { get => nombrePaseador; }

        public int TamañoManada { get => lista.Count(); }

        public Paseador(string nombre)
        {
           this.lista = new List<T>();
           this.nombrePaseador = nombre;
        }

        public void AgregarALista(T t, List<T> lista)
        {
            foreach (T item in lista)
            {
                if (item.Id == t.Id)
                {
                    break;
                }
                else
                {
                   lista.Add(t);

                }
            }
        }
    }
}