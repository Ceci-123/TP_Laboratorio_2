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

namespace CalculadoraTP1
{
    public partial class FormCalculadora : Form
    {

        #region Variables
        string memoria = "";
                
        #endregion

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }


        private void btn_operar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero1.Text) || string.IsNullOrEmpty(txtNumero2.Text))
            {
                MessageBox.Show("Error, no ingresaste los numeros", "Error", MessageBoxButtons.OK);
            }
            if (cmbOperador.SelectedIndex < 0)
            {
                MessageBox.Show("Error, no ingresaste el operador", "Error", MessageBoxButtons.OK);
            }
            
            this.lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.SelectedIndex.ToString()).ToString();
            EscribirHistorial();
            
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(lblResultado.Text))
            {
                MessageBox.Show("Error, no hay resultado para convertir", "Error", MessageBoxButtons.OK);
            }
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
            EscribirHistorialBinario();

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(lblResultado.Text))
            {
                MessageBox.Show("Error, no hay resultado para convertir", "Error", MessageBoxButtons.OK);
            }
            if (!Operando.ConsultaBinario(lblResultado.Text))
            {
                MessageBox.Show("Error, no se puede convertir", "Error", MessageBoxButtons.OK);
            }
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
            EscribirHistorialBinario();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        #region Metodos

        private static double Operar(string primerNumeroStr, string segundoNumeroStr, string operador)
        {
            Operando primerOperando = new Operando();
            Operando segundoOperando = new Operando();
            primerOperando.Numero = primerNumeroStr;
            segundoOperando.Numero = segundoNumeroStr;
            char opcion;
            switch (operador)
            {
                case "0":
                    opcion = '+';
                    break;
                case "1":
                    opcion = '-';
                    break;
                case "2":
                    opcion = '*';
                    break;
                case "3":
                    opcion = '/';
                    break;
                default:
                    opcion = '+';
                    break;
            }

            return Entidades.Calculadora.Operar(primerOperando, segundoOperando,opcion);
            
        }

        private void Limpiar()
        {
            this.lblResultado.Text = " ";
            this.txtNumero1.Text = " ";
            this.txtNumero2.Text = " ";
            this.cmbOperador.SelectedIndex = -1;

        }

        /// <summary>
        /// Escribe en el listbox el contenido de los text box txtNumero1, txtNumero2, la eleccion del combobox
        /// y el contenido del lblResultado
        /// </summary>
        private void EscribirHistorial()
        {
            if (!(string.IsNullOrEmpty(txtNumero1.Text) || string.IsNullOrEmpty(txtNumero2.Text) || string.IsNullOrEmpty(cmbOperador.Text)))
            {
                memoria = txtNumero1.Text + " " + cmbOperador.SelectedItem.ToString() + " " + txtNumero2.Text + " = " + lblResultado.Text + "\n";
                lstOperaciones.Items.Add(memoria);

            }
        }

        private void EscribirHistorialBinario()
        {
            memoria = " = " + lblResultado.Text + "\n";
            lstOperaciones.Items.Add(memoria);

        }

        #endregion


    }
}
