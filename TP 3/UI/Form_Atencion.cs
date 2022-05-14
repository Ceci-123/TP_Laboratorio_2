﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form_Atencion : Form
    {
        Paciente pacienteActual;
        Animal animalito;
        public Form_Atencion(Paciente unPaciente)
        {
            InitializeComponent();
            this.pacienteActual = unPaciente;
        }

        private void Form_Atencion_Load(object sender, EventArgs e)
        {
            this.lbl_Atencion.Text = $"Atendiendo a {pacienteActual.Nombre}";
            this.lbl_tipoAnimal.Text = $"Es un {pacienteActual.TipoDeAnimal}";
            
            switch (pacienteActual.TipoDeAnimal.ToString())
            {
                case "Conejo":
                    this.lbl_pelaje.Visible = true;
                    this.txt_pelaje.Visible = true;
                    this.lbl_Peso.Visible = false;
                    this.lbl_raza.Visible = false;
                    this.txt_raza.Visible = false;
                    this.numeric_peso.Visible = false;
                    break;
                case "Hamster":
                    this.lbl_pelaje.Visible = false;
                    this.txt_pelaje.Visible = false;
                    this.lbl_Peso.Visible = false;
                    this.lbl_raza.Visible = false;
                    this.txt_raza.Visible = false;
                    this.numeric_peso.Visible = false;
                    break;
                case "Perro":
                case "Gato":
                    this.lbl_pelaje.Visible = false;
                    this.txt_pelaje.Visible = false;
                    break;

            }
                       
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
           string auxNombre = pacienteActual.Nombre;
            string auxPelaje = this.txt_pelaje.Text;
            int auxEdad = (int)this.num_edad.Value;
            int auxPeso = (int)this.numeric_peso.Value;
            string auxRaza = this.txt_raza.Text;
            bool auxVacunado = this.chk_bx_vacunado.Checked;
            bool auxPaseo = this.chk_paseo.Checked;
            switch (pacienteActual.TipoDeAnimal.ToString())
            {
                case "Conejo":
                    Veterinaria.AgregarAnimal(new Conejo(auxNombre,auxPelaje));
                    break;
                case "Perro":
                    Perro p = new Perro(auxNombre, auxPeso, auxRaza, auxVacunado);
                    Veterinaria.AgregarAnimal(p);
                    Veterinaria.AgregarAPaseos(p);
                    break;
                case "Gato":
                    Gato g = new Gato(auxNombre, auxVacunado);
                    Veterinaria.AgregarAnimal(g);
                    Veterinaria.AgregarAPaseos(g);
                    break;
                case "Hamster":
                    Veterinaria.AgregarAnimal(new Hamster(auxNombre));
                    break;

            }

            RefrescarLista();
        }

        private void RefrescarLista()
        {
            this.txt_devolverInfo.Text = null;
            this.txt_devolverInfo.Text += Veterinaria.ListaAnimales;
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int aux = int.Parse(this.txt_bx_busquedaPorId.Text);
            animalito = Veterinaria.BuscarAnimalPorId(aux,Veterinaria.ListaAnimales);
            if(animalito is not null)
            {
                this.txt_devolverInfo.Text += animalito; 
            }
        }
    }
}
