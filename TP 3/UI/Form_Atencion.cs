using Entidades;
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
        public Form_Atencion(Paciente unPaciente)
        {
            InitializeComponent();
            this.pacienteActual = unPaciente;
        }

        private void Form_Atencion_Load(object sender, EventArgs e)
        {
            this.lbl_Atencion.Text = $"Atendiendo a {pacienteActual.Nombre}";
        }
    }
}
