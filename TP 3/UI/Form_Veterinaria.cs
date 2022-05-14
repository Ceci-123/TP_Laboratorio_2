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
    public partial class Form_Veterinaria : Form
    {
        private int cantidadEsperando = 0;
        private Paciente? pacienteActual = null;
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
            //RefrescarLista();
        }

        private void btn_AgregarPaciente_Click(object sender, EventArgs e)
        {
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
                RefrescarLista();
                this.txt_bx_nombre.Text = "";
                this.cmb_TipoAnimal.Text = "";
            }
            else
            {
                MessageBox.Show("debe completar los campos");
            }
        }

        private void RefrescarLista()
        {
            this.rchTxt_Info.Text = Veterinaria.MostrarFila(Veterinaria.FilaDePacientes);
            SumarUnPaciente();
        }

        private void SumarUnPaciente()
        {
            cantidadEsperando++;
            this.lbl_PacientesEnEspera.Text = $"Pacientes en espera {cantidadEsperando}";
        }

        private void btn_AtenderProximo_Click(object sender, EventArgs e)
        {
            try
            {
               pacienteActual = Veterinaria.FilaDePacientes.Dequeue();

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
                    //aqui codigo
                }
            }
            
        }

        
    }
}
