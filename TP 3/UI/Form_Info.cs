using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class Form_Info : Form
    {
        public Form_Info()
        {
            InitializeComponent();
        }

        private void btn_GuardarEnXml_Click(object sender, EventArgs e)
        {
            if (Veterinaria.GuardarAnimalesEnXml(Veterinaria.ListaAnimales))
            {
                MessageBox.Show("Datos guardados exitosamente", "Persistencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al guardar los datos", "Persistencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void btn_GuardarEnJson_Click(object sender, EventArgs e)
        {
            if (Veterinaria.GuardarListaAnimalesJson(Veterinaria.ListaAnimales))
            {
                MessageBox.Show("Datos guardados exitosamente","Persistencia de datos",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al guardar los datos", "Persistencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_GuardarEnDbase_Click(object sender, EventArgs e)
        {
            //if ()
            //{
            //    MessageBox.Show("exitoso");
            //} message, title, buttons, MessageBoxIcon.Warning
            //else
            //{
            //    MessageBox.Show("fallo");
            //}
        }

        private void btn_CargarDesdeXml_Click(object sender, EventArgs e)
        {
            this.richtxt_Info.Text = Veterinaria.MostrarLista(Veterinaria.CargarAnimalesDesdeXml(Veterinaria.ListaAnimales));
           
        }

        private void btn_CargarDesdeJson_Click(object sender, EventArgs e)
        {
            //this.richtxt_Info.Text = Veterinaria.CargarListaAnimalesJson(Veterinaria.ListaAnimales);
            //{
            //    MessageBox.Show("exitoso");
            //    RefrescarLista();  
            //}
            //else
            //{
            //    MessageBox.Show("fallo");
            //}
        }

        private void btn_CargarDesdeDbase_Click(object sender, EventArgs e)
        {
            //if ()
            //{
            //    MessageBox.Show("exitoso");
            //}
            //else
            //{
            //    MessageBox.Show("fallo");
            //}
        }

        private void RefrescarLista()
        {
            this.richtxt_Info.Text = String.Empty;
            this.richtxt_Info.Text = Veterinaria.MostrarLista(Veterinaria.ListaAnimales);
        }

        private void btn_PaseoPerruno_Click(object sender, EventArgs e)
        {
            this.richtxt_Info.Text = String.Empty;
            this.richtxt_Info.Text = (Veterinaria.PaseoPerruno.Lista.ToString());
        }

        private void btn_PaseoGatuno_Click(object sender, EventArgs e)
        {
            this.richtxt_Info.Text = String.Empty;
            this.richtxt_Info.Text = (Veterinaria.PaseoGatuno.Lista.ToString());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
