﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class Form_Veterinaria : Form
    {
        private int cantidadEsperando = 0;
        private Paciente? pacienteActual = null;
        private bool resultado;
        public Form_Veterinaria()
        {
            InitializeComponent();
            this.cantidadEsperando = Veterinaria.FilaDePacientes.Count;
            this.cmb_TipoAnimal.DataSource = Enum.GetValues(typeof(Paciente.eAnimal));
        }

        private void Form_Veterinaria_Load(object sender, EventArgs e)
        {
            this.lbl_NombreVet.Text = Veterinaria.Nombre;
            this.lbl_PacientesEnEspera.Text = $"Pacientes en espera {cantidadEsperando}";
            this.lbl_NombrePaciente.Visible = false;
            this.lbl_TipoAnimal.Visible = false;
            this.cmb_TipoAnimal.Visible = false;
            this.txt_bx_nombre.Visible = false;
            this.lbl_Hora.Text = DateTime.Now.ToString();
            this.lbl_mensajito.Text = ExtendTime.DiaSemana(DateTime.Now);
            ReproducirLadrido();
        }

        private void ReproducirLadrido()
        {
           
            SoundPlayer sonido = new SoundPlayer(Properties.Resources.ladrido);
            sonido.Play();
            
        }

        private void btn_AgregarPaciente_Click(object sender, EventArgs e)
        {
            this.pictureBox_Foto.Visible = false;
            this.lbl_NombrePaciente.Visible = true;
            this.lbl_TipoAnimal.Visible = true;
            this.cmb_TipoAnimal.Visible = true;
            this.txt_bx_nombre.Visible = true;
            this.cmb_TipoAnimal.Text = "";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(this.txt_bx_nombre.Text)
                && this.cmb_TipoAnimal is not null)
            {
                pacienteActual = new Paciente(this.txt_bx_nombre.Text,(Paciente.eAnimal)this.cmb_TipoAnimal.SelectedItem);
                Veterinaria.FilaDePacientes = pacienteActual + Veterinaria.FilaDePacientes;
                RefrescarListaYSumar();
                this.txt_bx_nombre.Text = "";
                this.cmb_TipoAnimal.Text = "";
            }
            else
            {
                MessageBox.Show("debe completar los campos");
            }
        }

        private void RefrescarListaYSumar()
        {
            this.rchTxt_Info.Text = Veterinaria.MostrarFila(Veterinaria.FilaDePacientes);
            SumarUnPaciente();
        }

        private void RefrescarListaYRestar()
        {
            this.rchTxt_Info.Text = Veterinaria.MostrarFila(Veterinaria.FilaDePacientes);
            RestarUnPaciente();
        }
        private void SumarUnPaciente()
        {
            cantidadEsperando++;
            this.lbl_PacientesEnEspera.Text = $"Pacientes en espera {cantidadEsperando}";
        }

        private void RestarUnPaciente()
        {
            cantidadEsperando--;
            this.lbl_PacientesEnEspera.Text = $"Pacientes en espera {cantidadEsperando}";
        }
        private void btn_AtenderProximo_Click(object sender, EventArgs e)
        {
            try
            {
               pacienteActual = Veterinaria.FilaDePacientes.Dequeue();
               RefrescarListaYRestar();

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No hay pacientes en espera");
            }    
            catch (Exception)
            {
                MessageBox.Show("algo malio sal");
            }
            if(pacienteActual is not null)
            {
               Form frmAtencion = new Form_Atencion(pacienteActual);
                if (frmAtencion.ShowDialog() == DialogResult.OK)
                {
                    //todo
                }
            }
            
        }

        private void btn_CargaXML_Click(object sender, EventArgs e)
        {
          resultado = Veterinaria.CargarListaAnimalesDesdeXml(Veterinaria.ListaAnimales);
            if (resultado)
            {
                MessageBox.Show("Lista cargada correctamente", "Carga XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo cargar la lista", "Carga XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_GuardarXml_Click(object sender, EventArgs e)
        {
            resultado = Veterinaria.GuardarListaAnimalesEnXml(Veterinaria.ListaAnimales);
            if (resultado)
            {
                MessageBox.Show("Lista guardada correctamente", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la lista", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
