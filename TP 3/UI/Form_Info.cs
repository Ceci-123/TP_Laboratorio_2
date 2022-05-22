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
                MessageBox.Show("exitoso");
            }
            else
            {
                MessageBox.Show("fallo");
            } 
        }

        private void btn_GuardarEnJson_Click(object sender, EventArgs e)
        {
            if (Veterinaria.GuardarListaAnimalesJson(Veterinaria.ListaAnimales))
            {
                MessageBox.Show("exitoso");
            }
            else
            {
                MessageBox.Show("fallo");
            }
        }

        private void btn_GuardarEnDbase_Click(object sender, EventArgs e)
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

        private void btn_CargarDesdeXml_Click(object sender, EventArgs e)
        {
            if (Veterinaria.CargarAnimalesDesdeXml(Veterinaria.ListaAnimales))
            {
                MessageBox.Show("exitoso");
            }
            else
            {
                MessageBox.Show("fallo");
            }
        }

        private void btn_CargarDesdeJson_Click(object sender, EventArgs e)
        {
            if (Veterinaria.CargarListaAnimalesJson(Veterinaria.ListaAnimales))
            {
                MessageBox.Show("exitoso");
            }
            else
            {
                MessageBox.Show("fallo");
            }
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
    }
}
