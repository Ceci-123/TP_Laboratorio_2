using Entidades;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Form_Info : Form
    {
        bool bandera;
        public Form_Info()
        {
            InitializeComponent();
            bandera = false;
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
            try
            {
                if (Veterinaria.GuardarListaAnimalesJson(Veterinaria.PaseoPerruno))
                {
                    MessageBox.Show("Datos guardados exitosamente", "Persistencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar los datos", "Persistencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Guardado de datos");
            }
        }

        private void btn_GuardarEnDbase_Click(object sender, EventArgs e)
        {
            if (!bandera)
            {

                try
                {
                    VacunacionDao.EnviarData(1, DateTime.Now, Veterinaria.CantidadVacunasPerrunas, Veterinaria.CantidadVacunasGatunas); ;
                    MessageBox.Show("Datos enviados corrextamente", "Envio datos a Zoonosis");
                    bandera = true;

                }
                catch (Exception)
                {

                    MessageBox.Show("Ocurrio un error", "Envio datos a Zoonosis");
                }
            }
            else
            {
                MessageBox.Show("Ya se enviaron los datos de vacunacion hoy", "Envio datos a Zoonosis");
            }
        }

        private void btn_CargarDesdeXml_Click(object sender, EventArgs e)
        {
            try
            {
                this.richtxt_Info.Text = Veterinaria.MostrarLista(Veterinaria.CargarAnimalesDesdeXml(Veterinaria.ListaAnimales));
                if(Veterinaria.ListaAnimales.Count == 0)
                {
                    this.richtxt_Info.Text = "No hay animales en la lista";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Carga de datos");
            }

        }

        private void btn_CargarDesdeJson_Click(object sender, EventArgs e)
        {
            try
            {
                this.richtxt_Info.Text = (Veterinaria.CargarListaAnimalesJson(Veterinaria.PaseoPerruno)).MostrarListaPaseos();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Carga de datos");
            }

        }

        private void btn_CargarDesdeDbase_Click(object sender, EventArgs e)
        {
            try
            {
                this.richtxt_Info.Text = $"Vacunas antirrabicas aplicadas este mes. De perro: {VacunacionDao.ConsultaAntirrabica(true)} y de gato: {VacunacionDao.ConsultaAntirrabica(false)}";

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Carga de datos");
            }

        }

        private void RefrescarLista()
        {
            this.richtxt_Info.Text = String.Empty;
            this.richtxt_Info.Text = Veterinaria.MostrarLista(Veterinaria.ListaAnimales);
        }

        private void btn_PaseoPerruno_Click(object sender, EventArgs e)
        {
            this.richtxt_Info.Text = String.Empty;
            this.richtxt_Info.Text = (Veterinaria.PaseoPerruno.MostrarListaPaseos());
        }

        private void btn_PaseoGatuno_Click(object sender, EventArgs e)
        {
            this.richtxt_Info.Text = String.Empty;
            this.richtxt_Info.Text = (Veterinaria.PaseoGatuno.MostrarListaPaseos());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
