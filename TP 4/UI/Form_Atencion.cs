using Entidades;
using System;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Form_Atencion : Form
    {
        Paciente pacienteActual;
        Animal animalito;
        bool bandera;

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
            bandera = false;
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
                    this.chk_AplicarVacuna.Visible = false;
                    break;
                case "Hamster":
                    this.lbl_pelaje.Visible = false;
                    this.txt_pelaje.Visible = false;
                    this.lbl_Peso.Visible = false;
                    this.lbl_raza.Visible = false;
                    this.txt_raza.Visible = false;
                    this.numeric_peso.Visible = false;
                    this.chk_bx_vacunado.Visible = false;
                    this.chk_paseo.Visible = false;
                    this.chk_AplicarVacuna.Visible = false;
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
            if (bandera)
            {
                MessageBox.Show("Ya ingresaste este animalito", "Error");
            }
            else
            {
                try
                {
                    string auxNombre = pacienteActual.Nombre;
                    string auxPelaje = this.txt_pelaje.Text;
                    int auxEdad = (int)this.num_edad.Value;
                    int auxPeso = (int)this.numeric_peso.Value;
                    string auxRaza = this.txt_raza.Text;
                    bool auxVacunado = this.chk_bx_vacunado.Checked;
                    bool auxPaseo = this.chk_paseo.Checked;
                    bool auxAntirrabica = this.chk_AplicarVacuna.Checked;

                    
                        switch (pacienteActual.TipoDeAnimal.ToString())
                        {
                            case "Conejo":
                                if (auxEdad == 0)
                                {
                                    MessageBox.Show("La edad no puede ser 0", "Error");
                                }
                                Veterinaria.AgregarAnimal(new Conejo(auxNombre, auxEdad, auxPelaje));
                                bandera = true;
                                break;
                            case "Perro":
                                if (auxEdad == 0 || auxPeso == 0)
                                {
                                    MessageBox.Show("Ni la edad ni el peso pueden ser 0", "Error");
                                }
                                Perro p = new Perro(auxNombre, auxEdad, auxPeso, auxRaza, auxVacunado);
                                bandera = true;
                                Veterinaria.AgregarAnimal(p);
                                if (auxPaseo)
                                {
                                    Veterinaria.AgregarAPaseos(p);
                                }
                                if (auxAntirrabica)
                                {
                                    p.AplicarVacuna();
                                }
                                break;
                            case "Gato":
                                if (auxEdad == 0 || auxPeso == 0)
                                {
                                    MessageBox.Show("Ni la edad ni el peso pueden ser 0", "Error");
                                }
                                Gato g = new Gato(auxNombre, auxEdad, auxVacunado, auxRaza);
                                bandera = true;
                                Veterinaria.AgregarAnimal(g);
                                if (auxPaseo)
                                {
                                    Veterinaria.AgregarAPaseos(g);
                                }
                                if (auxAntirrabica)
                                {
                                    g.AplicarVacuna();
                                }
                                break;
                            case "Hamster":
                                if (auxEdad == 0)
                                {
                                    MessageBox.Show("La edad no puede ser 0", "Error");
                                }
                                Veterinaria.AgregarAnimal(new Hamster(auxNombre, auxEdad));
                                bandera = true;
                                break;
                        }
                        LimpiarCampos();
                        RefrescarLista();
                           
                }


                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error");
                }

            }

        
        }

        /// <summary>
        /// Muestra la lista de animales de la veterinaria
        /// </summary>
        private void RefrescarLista()
        {
            this.txt_devolverInfo.Text = String.Empty;
            this.txt_devolverInfo.Text = Veterinaria.MostrarLista(Veterinaria.ListaAnimales);
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int aux = int.Parse(this.txt_bx_busquedaPorId.Text);
                if(Veterinaria.ListaAnimales.Count == 0)
                {
                    MessageBox.Show("Aun no hay animales ingresados");
                }
                animalito = Veterinaria.BuscarAnimalPorId(aux, Veterinaria.ListaAnimales);
                if (animalito is not null)
                {
                    this.txt_bx_busquedaPorId.Text = String.Empty;
                    MostrarAnimalitoPorId(animalito);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }

        }

        private void MostrarAnimalitoPorId(Animal animalito)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(animalito.Nombre);
            sb.Append(animalito.Id);

            if (animalito.GetType() == typeof(Perro))
            {
                sb.AppendLine(((Perro)animalito).Mostrar());
            }
            if (animalito.GetType() == typeof(Gato))
            {
                sb.AppendLine(((Gato)animalito).Mostrar());
            }
            if (animalito.GetType() == typeof(Conejo))
            {
                sb.AppendLine(((Conejo)animalito).Mostrar());
            }
            if (animalito.GetType() == typeof(Hamster))
            {
                sb.AppendLine(((Hamster)animalito).Mostrar());
            }
            this.txt_devolverInfo.Text = String.Empty;
            this.txt_devolverInfo.Text = sb.ToString();
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

        /// <summary>
        /// Coloca los campos con su contenido vacio
        /// </summary>
        private void LimpiarCampos()
        {
            this.numeric_peso.Value = 0;
            this.txt_raza.Text = String.Empty;
            this.chk_bx_vacunado.Checked = false;
            this.chk_paseo.Checked = false;
            this.txt_pelaje.Text = String.Empty;
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

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
