using Entidades;
using System;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace UI
{
    public partial class Form_Veterinaria : Form
    {
        private int cantidadEsperando = 0;
        private Paciente? pacienteActual = null;
        private int segundos;
        private int minutos;
        int horas;
        private string segundosString;
        string minutosString;
        private string horasString;
        private Thread hiloAlterno;
        public Form_Veterinaria()
        {
            InitializeComponent();
            this.cantidadEsperando = Veterinaria.FilaDePacientes.Count;
            this.cmb_TipoAnimal.DataSource = Enum.GetValues(typeof(Paciente.eAnimal));
            segundos = 0;
            minutos = 0;
            horas = 0;
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
            timer1.Enabled = true;
            timer1.Start();
            hiloAlterno = new Thread(Anunciar);
            hiloAlterno.Start();
        }

        private static void ReproducirLadrido()
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

        private void Anunciar()
        {
            try
            {
                InvocarLabel("SESION INICIADA...");
                Thread.Sleep(1000);
                InvocarLabel("BIENVENID@ A PEQUEÑAS PATITAS...");
                Thread.Sleep(1000);
                InvocarLabel("LISTO PARA INICIAR...");
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void InvocarLabel(string value)
        {

            if (InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    lbl_aviso.Text = string.Empty;
                    lbl_aviso.Text += value;
                });
            }
            else
            {
                lbl_aviso.Text = string.Empty;
                lbl_aviso.Text += value;
            }
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
            try
            {
                if (!String.IsNullOrEmpty(this.txt_bx_nombre.Text)
                && this.cmb_TipoAnimal is not null)
                {
                    pacienteActual = new Paciente(this.txt_bx_nombre.Text, (Paciente.eAnimal)this.cmb_TipoAnimal.SelectedItem);
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
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error");
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
            if (pacienteActual is not null)
            {
                Form frmAtencion = new Form_Atencion(pacienteActual);
                this.Hide();
                if (frmAtencion.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }

        }


        private void btn_Informacion_Click(object sender, EventArgs e)
        {
            Form_Info frm = new Form_Info();
            frm.Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            segundos += 1;
            if (segundos < 10)
            {
                segundosString = $"0 {segundos.ToString()}";
            }
            else
            {
                segundosString = $" {segundos.ToString()}";
            }
            if (minutos < 10)
            {
                minutosString = $"0 {minutos.ToString()}";
            }
            else
            {
                minutosString = $" {minutos.ToString()}";
            }
            if (horas < 10)
            {
                horasString = $"0 {horas.ToString()}";
            }
            else
            {
                horasString = $" {horas.ToString()}";
            }
            if (segundos == 59)
            {
                segundos = 0;
                minutos += 1;
            }
            if (minutos == 59)
            {
                minutos = 0;
                horas += 1;
            }
            this.lbl_tiempo_hora.Text = horasString;
            this.lbl_tiempo_minuto.Text = minutosString;
            this.lbl_tiempo_segundos.Text = segundosString;
        }
    }
}
