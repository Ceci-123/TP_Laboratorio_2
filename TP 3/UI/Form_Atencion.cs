using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form_Atencion : Form
    {
        Paciente pacienteActual;
        Animal animalito;
        bool resultado;
        public Form_Atencion(Paciente unPaciente)
        {
            InitializeComponent();
            this.pacienteActual = unPaciente;
        }

        private void Form_Atencion_Load(object sender, EventArgs e)
        {
            this.lbl_Atencion.Text = $"Atendiendo a {pacienteActual.Nombre}";
            this.lbl_tipoAnimal.Text = $"Es un {pacienteActual.TipoDeAnimal}";
            ReproducirLadrido();
            switch (pacienteActual.TipoDeAnimal.ToString())
            {
                case "Conejo":
                    this.lbl_pelaje.Visible = true;
                    this.txt_pelaje.Visible = true;
                    this.lbl_Peso.Visible = false;
                    this.lbl_raza.Visible = false;
                    this.txt_raza.Visible = false;
                    this.numeric_peso.Visible = false;
                    this.chk_bx_vacunado.Visible = false;
                    this.chk_paseo.Visible = false;
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

        private void btn_ingresarFicha_Click(object sender, EventArgs e)
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
                    Veterinaria.AgregarAnimal(new Conejo(auxNombre,auxEdad, auxPelaje));
                    break;
                case "Perro":
                    Perro p = new Perro(auxNombre, auxEdad, auxPeso, auxRaza, auxVacunado);
                    Veterinaria.AgregarAnimal(p);
                    Veterinaria.AgregarAPaseos(p);
                    break;
                case "Gato":
                    Gato g = new Gato(auxNombre, auxEdad, auxVacunado);
                    Veterinaria.AgregarAnimal(g);
                    Veterinaria.AgregarAPaseos(g);
                    break;
                case "Hamster":
                    Veterinaria.AgregarAnimal(new Hamster(auxNombre, auxEdad));
                    break;

            }
            LimpiarCampos();
            RefrescarLista();
        }

        private void RefrescarLista()
        {
            this.txt_devolverInfo.Text = String.Empty;
            this.txt_devolverInfo.Text = Veterinaria.MostrarLista(Veterinaria.ListaAnimales);
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int aux = int.Parse(this.txt_bx_busquedaPorId.Text);
            animalito = Veterinaria.BuscarAnimalPorId(aux,Veterinaria.ListaAnimales);
            if(animalito is not null)
            {
                this.txt_devolverInfo.Text = String.Empty;
                this.txt_devolverInfo.Text = animalito.ToString();
                this.txt_devolverInfo.Text = Animal.Mostrar(animalito);
                this.txt_bx_busquedaPorId.Text = String.Empty;
            }
        }

        private void ReproducirLadrido()
        {
            try
            {
                SoundPlayer sonido = new SoundPlayer(Properties.Resources.dogbark);
                sonido.Play();
            }
            catch (Exception)
            {
                Console.Beep();
            }

        }

        private void btn_CargarJson_Click(object sender, EventArgs e)
        {
            resultado = Veterinaria.CargarListaAnimalesJson(Veterinaria.ListaAnimales);
            if (resultado)
            {
                MessageBox.Show("Lista cargada correctamente", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo cargar la lista", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_GuardarJson_Click(object sender, EventArgs e)
        {
            resultado = Veterinaria.GuardarListaAnimalesJson(Veterinaria.ListaAnimales);
            if (resultado)
            {
                MessageBox.Show("Lista guardada correctamente", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la lista", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_CargarDBase_Click(object sender, EventArgs e)
        {
            resultado = Veterinaria.CargarListaAnimalesDataBase(Veterinaria.ListaAnimales);
            if (resultado)
            {
                MessageBox.Show("Lista cargada correctamente", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo cargar la lista", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_GuardarDBase_Click(object sender, EventArgs e)
        {
            resultado = Veterinaria.GuardarListaAnimalesDataBase(Veterinaria.ListaAnimales);
            if (resultado)
            {
                MessageBox.Show("Lista guardada correctamente", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la lista", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarCampos()
        {
            this.numeric_peso.Value = 0;
            this.txt_raza.Text = String.Empty;
            this.chk_bx_vacunado.Checked = false;
            this.chk_paseo.Checked = false;
            this.txt_pelaje.Text= String.Empty;
            this.num_edad.Value = 0;
        }

        private void btn_cerrarVentana_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_listado_Click(object sender, EventArgs e)
        {
            RefrescarLista();
        }
    }
}
