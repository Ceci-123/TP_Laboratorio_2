namespace UI
{
    partial class Form_Veterinaria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Veterinaria));
            this.lbl_NombreVet = new System.Windows.Forms.Label();
            this.lbl_PacientesEnEspera = new System.Windows.Forms.Label();
            this.btn_AtenderProximo = new System.Windows.Forms.Button();
            this.rchTxt_Info = new System.Windows.Forms.RichTextBox();
            this.btn_AgregarPaciente = new System.Windows.Forms.Button();
            this.lbl_NombrePaciente = new System.Windows.Forms.Label();
            this.txt_bx_nombre = new System.Windows.Forms.TextBox();
            this.lbl_TipoAnimal = new System.Windows.Forms.Label();
            this.cmb_TipoAnimal = new System.Windows.Forms.ComboBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Informacion = new System.Windows.Forms.Button();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.lbl_mensajito = new System.Windows.Forms.Label();
            this.pictureBox_Foto = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_tiempo_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_tiempo_minuto = new System.Windows.Forms.Label();
            this.lbl_tiempo_segundos = new System.Windows.Forms.Label();
            this.lbl_sesion = new System.Windows.Forms.Label();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.lbl_Modos = new System.Windows.Forms.Label();
            this.radioBtn_claro = new System.Windows.Forms.RadioButton();
            this.radioBtn_oscuro = new System.Windows.Forms.RadioButton();
            this.btn_carga_modo = new System.Windows.Forms.Button();
            this.btn_traer_modo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NombreVet
            // 
            this.lbl_NombreVet.AutoSize = true;
            this.lbl_NombreVet.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_NombreVet.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreVet.Location = new System.Drawing.Point(308, 18);
            this.lbl_NombreVet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NombreVet.Name = "lbl_NombreVet";
            this.lbl_NombreVet.Size = new System.Drawing.Size(188, 33);
            this.lbl_NombreVet.TabIndex = 10;
            this.lbl_NombreVet.Text = "Veterinaria";
            // 
            // lbl_PacientesEnEspera
            // 
            this.lbl_PacientesEnEspera.AutoSize = true;
            this.lbl_PacientesEnEspera.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_PacientesEnEspera.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PacientesEnEspera.Location = new System.Drawing.Point(600, 79);
            this.lbl_PacientesEnEspera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PacientesEnEspera.Name = "lbl_PacientesEnEspera";
            this.lbl_PacientesEnEspera.Size = new System.Drawing.Size(207, 23);
            this.lbl_PacientesEnEspera.TabIndex = 10;
            this.lbl_PacientesEnEspera.Text = "Pacientes en Espera";
            // 
            // btn_AtenderProximo
            // 
            this.btn_AtenderProximo.BackColor = System.Drawing.Color.LightCyan;
            this.btn_AtenderProximo.Location = new System.Drawing.Point(217, 157);
            this.btn_AtenderProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AtenderProximo.Name = "btn_AtenderProximo";
            this.btn_AtenderProximo.Size = new System.Drawing.Size(147, 95);
            this.btn_AtenderProximo.TabIndex = 2;
            this.btn_AtenderProximo.Text = "Atender Proximo";
            this.btn_AtenderProximo.UseVisualStyleBackColor = false;
            this.btn_AtenderProximo.Click += new System.EventHandler(this.btn_AtenderProximo_Click);
            // 
            // rchTxt_Info
            // 
            this.rchTxt_Info.BackColor = System.Drawing.Color.LightCyan;
            this.rchTxt_Info.Location = new System.Drawing.Point(444, 157);
            this.rchTxt_Info.Margin = new System.Windows.Forms.Padding(4);
            this.rchTxt_Info.Name = "rchTxt_Info";
            this.rchTxt_Info.Size = new System.Drawing.Size(435, 283);
            this.rchTxt_Info.TabIndex = 10;
            this.rchTxt_Info.Text = "";
            // 
            // btn_AgregarPaciente
            // 
            this.btn_AgregarPaciente.BackColor = System.Drawing.Color.LightCyan;
            this.btn_AgregarPaciente.Location = new System.Drawing.Point(33, 157);
            this.btn_AgregarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgregarPaciente.Name = "btn_AgregarPaciente";
            this.btn_AgregarPaciente.Size = new System.Drawing.Size(158, 95);
            this.btn_AgregarPaciente.TabIndex = 1;
            this.btn_AgregarPaciente.Text = "Agregar un Paciente a la fila";
            this.btn_AgregarPaciente.UseVisualStyleBackColor = false;
            this.btn_AgregarPaciente.Click += new System.EventHandler(this.btn_AgregarPaciente_Click);
            // 
            // lbl_NombrePaciente
            // 
            this.lbl_NombrePaciente.AutoSize = true;
            this.lbl_NombrePaciente.Location = new System.Drawing.Point(33, 306);
            this.lbl_NombrePaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NombrePaciente.Name = "lbl_NombrePaciente";
            this.lbl_NombrePaciente.Size = new System.Drawing.Size(164, 18);
            this.lbl_NombrePaciente.TabIndex = 10;
            this.lbl_NombrePaciente.Text = "Nombre del Paciente";
            // 
            // txt_bx_nombre
            // 
            this.txt_bx_nombre.Location = new System.Drawing.Point(217, 302);
            this.txt_bx_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bx_nombre.Name = "txt_bx_nombre";
            this.txt_bx_nombre.Size = new System.Drawing.Size(154, 22);
            this.txt_bx_nombre.TabIndex = 10;
            // 
            // lbl_TipoAnimal
            // 
            this.lbl_TipoAnimal.AutoSize = true;
            this.lbl_TipoAnimal.Location = new System.Drawing.Point(33, 346);
            this.lbl_TipoAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TipoAnimal.Name = "lbl_TipoAnimal";
            this.lbl_TipoAnimal.Size = new System.Drawing.Size(48, 18);
            this.lbl_TipoAnimal.TabIndex = 10;
            this.lbl_TipoAnimal.Text = "Es un";
            // 
            // cmb_TipoAnimal
            // 
            this.cmb_TipoAnimal.FormattingEnabled = true;
            this.cmb_TipoAnimal.Location = new System.Drawing.Point(217, 338);
            this.cmb_TipoAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_TipoAnimal.Name = "cmb_TipoAnimal";
            this.cmb_TipoAnimal.Size = new System.Drawing.Size(154, 26);
            this.cmb_TipoAnimal.TabIndex = 6;
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Ok.Location = new System.Drawing.Point(33, 378);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(338, 35);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Informacion
            // 
            this.btn_Informacion.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Informacion.Location = new System.Drawing.Point(217, 466);
            this.btn_Informacion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Informacion.Name = "btn_Informacion";
            this.btn_Informacion.Size = new System.Drawing.Size(416, 61);
            this.btn_Informacion.TabIndex = 3;
            this.btn_Informacion.Text = "Archivos de informacion";
            this.btn_Informacion.UseVisualStyleBackColor = false;
            this.btn_Informacion.Click += new System.EventHandler(this.btn_Informacion_Click);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Hora.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hora.Location = new System.Drawing.Point(33, 116);
            this.lbl_Hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(60, 23);
            this.lbl_Hora.TabIndex = 10;
            this.lbl_Hora.Text = "Hora";
            // 
            // lbl_mensajito
            // 
            this.lbl_mensajito.AutoSize = true;
            this.lbl_mensajito.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_mensajito.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajito.Location = new System.Drawing.Point(33, 79);
            this.lbl_mensajito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mensajito.Name = "lbl_mensajito";
            this.lbl_mensajito.Size = new System.Drawing.Size(107, 23);
            this.lbl_mensajito.TabIndex = 10;
            this.lbl_mensajito.Text = "Mensajito";
            // 
            // pictureBox_Foto
            // 
            this.pictureBox_Foto.Image = global::UI.Properties.Resources.perroVeterinario;
            this.pictureBox_Foto.Location = new System.Drawing.Point(26, 285);
            this.pictureBox_Foto.Name = "pictureBox_Foto";
            this.pictureBox_Foto.Size = new System.Drawing.Size(354, 155);
            this.pictureBox_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Foto.TabIndex = 16;
            this.pictureBox_Foto.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Salir.Location = new System.Drawing.Point(677, 466);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(202, 61);
            this.btn_Salir.TabIndex = 17;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_tiempo_hora
            // 
            this.lbl_tiempo_hora.AutoSize = true;
            this.lbl_tiempo_hora.Location = new System.Drawing.Point(12, 497);
            this.lbl_tiempo_hora.Name = "lbl_tiempo_hora";
            this.lbl_tiempo_hora.Size = new System.Drawing.Size(55, 18);
            this.lbl_tiempo_hora.TabIndex = 18;
            this.lbl_tiempo_hora.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lbl_tiempo_minuto
            // 
            this.lbl_tiempo_minuto.AutoSize = true;
            this.lbl_tiempo_minuto.Location = new System.Drawing.Point(73, 497);
            this.lbl_tiempo_minuto.Name = "lbl_tiempo_minuto";
            this.lbl_tiempo_minuto.Size = new System.Drawing.Size(55, 18);
            this.lbl_tiempo_minuto.TabIndex = 19;
            this.lbl_tiempo_minuto.Text = "label1";
            // 
            // lbl_tiempo_segundos
            // 
            this.lbl_tiempo_segundos.AutoSize = true;
            this.lbl_tiempo_segundos.Location = new System.Drawing.Point(136, 497);
            this.lbl_tiempo_segundos.Name = "lbl_tiempo_segundos";
            this.lbl_tiempo_segundos.Size = new System.Drawing.Size(55, 18);
            this.lbl_tiempo_segundos.TabIndex = 20;
            this.lbl_tiempo_segundos.Text = "label2";
            // 
            // lbl_sesion
            // 
            this.lbl_sesion.AutoSize = true;
            this.lbl_sesion.Location = new System.Drawing.Point(12, 466);
            this.lbl_sesion.Name = "lbl_sesion";
            this.lbl_sesion.Size = new System.Drawing.Size(169, 18);
            this.lbl_sesion.TabIndex = 21;
            this.lbl_sesion.Text = "Tiempo Sesion Actual";
            // 
            // lbl_aviso
            // 
            this.lbl_aviso.AutoSize = true;
            this.lbl_aviso.Location = new System.Drawing.Point(12, 537);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(55, 18);
            this.lbl_aviso.TabIndex = 22;
            this.lbl_aviso.Text = "label1";
            // 
            // lbl_Modos
            // 
            this.lbl_Modos.AutoSize = true;
            this.lbl_Modos.Location = new System.Drawing.Point(920, 116);
            this.lbl_Modos.Name = "lbl_Modos";
            this.lbl_Modos.Size = new System.Drawing.Size(98, 18);
            this.lbl_Modos.TabIndex = 23;
            this.lbl_Modos.Text = "Elegir modo";
            // 
            // radioBtn_claro
            // 
            this.radioBtn_claro.AutoSize = true;
            this.radioBtn_claro.Location = new System.Drawing.Point(908, 183);
            this.radioBtn_claro.Name = "radioBtn_claro";
            this.radioBtn_claro.Size = new System.Drawing.Size(110, 22);
            this.radioBtn_claro.TabIndex = 24;
            this.radioBtn_claro.TabStop = true;
            this.radioBtn_claro.Text = "Modo claro";
            this.radioBtn_claro.UseVisualStyleBackColor = true;
            this.radioBtn_claro.CheckedChanged += new System.EventHandler(this.radioBtn_claro_CheckedChanged);
            // 
            // radioBtn_oscuro
            // 
            this.radioBtn_oscuro.AutoSize = true;
            this.radioBtn_oscuro.Location = new System.Drawing.Point(908, 230);
            this.radioBtn_oscuro.Name = "radioBtn_oscuro";
            this.radioBtn_oscuro.Size = new System.Drawing.Size(122, 22);
            this.radioBtn_oscuro.TabIndex = 25;
            this.radioBtn_oscuro.TabStop = true;
            this.radioBtn_oscuro.Text = "Modo oscuro";
            this.radioBtn_oscuro.UseVisualStyleBackColor = true;
            this.radioBtn_oscuro.CheckedChanged += new System.EventHandler(this.radioBtn_oscuro_CheckedChanged);
            // 
            // btn_carga_modo
            // 
            this.btn_carga_modo.Location = new System.Drawing.Point(920, 285);
            this.btn_carga_modo.Name = "btn_carga_modo";
            this.btn_carga_modo.Size = new System.Drawing.Size(110, 91);
            this.btn_carga_modo.TabIndex = 26;
            this.btn_carga_modo.Text = "Guardar preferencia";
            this.btn_carga_modo.UseVisualStyleBackColor = true;
            this.btn_carga_modo.Click += new System.EventHandler(this.btn_carga_modo_Click);
            // 
            // btn_traer_modo
            // 
            this.btn_traer_modo.Location = new System.Drawing.Point(920, 415);
            this.btn_traer_modo.Name = "btn_traer_modo";
            this.btn_traer_modo.Size = new System.Drawing.Size(110, 91);
            this.btn_traer_modo.TabIndex = 27;
            this.btn_traer_modo.Text = "Leer preferencia guardada";
            this.btn_traer_modo.UseVisualStyleBackColor = true;
            this.btn_traer_modo.Click += new System.EventHandler(this.btn_traer_modo_Click);
            // 
            // Form_Veterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1048, 574);
            this.Controls.Add(this.btn_traer_modo);
            this.Controls.Add(this.btn_carga_modo);
            this.Controls.Add(this.radioBtn_oscuro);
            this.Controls.Add(this.radioBtn_claro);
            this.Controls.Add(this.lbl_Modos);
            this.Controls.Add(this.lbl_aviso);
            this.Controls.Add(this.lbl_sesion);
            this.Controls.Add(this.lbl_tiempo_segundos);
            this.Controls.Add(this.lbl_tiempo_minuto);
            this.Controls.Add(this.lbl_tiempo_hora);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pictureBox_Foto);
            this.Controls.Add(this.lbl_mensajito);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.btn_Informacion);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.cmb_TipoAnimal);
            this.Controls.Add(this.lbl_TipoAnimal);
            this.Controls.Add(this.txt_bx_nombre);
            this.Controls.Add(this.lbl_NombrePaciente);
            this.Controls.Add(this.btn_AgregarPaciente);
            this.Controls.Add(this.rchTxt_Info);
            this.Controls.Add(this.btn_AtenderProximo);
            this.Controls.Add(this.lbl_PacientesEnEspera);
            this.Controls.Add(this.lbl_NombreVet);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Veterinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeñas Patitas";
            this.Load += new System.EventHandler(this.Form_Veterinaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NombreVet;
        private System.Windows.Forms.Label lbl_PacientesEnEspera;
        private System.Windows.Forms.Button btn_AtenderProximo;
        private System.Windows.Forms.RichTextBox rchTxt_Info;
        private System.Windows.Forms.Button btn_AgregarPaciente;
        private System.Windows.Forms.Label lbl_NombrePaciente;
        private System.Windows.Forms.TextBox txt_bx_nombre;
        private System.Windows.Forms.Label lbl_TipoAnimal;
        private System.Windows.Forms.ComboBox cmb_TipoAnimal;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Informacion;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label lbl_mensajito;
        private System.Windows.Forms.PictureBox pictureBox_Foto;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_tiempo_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_tiempo_minuto;
        private System.Windows.Forms.Label lbl_tiempo_segundos;
        private System.Windows.Forms.Label lbl_sesion;
        private System.Windows.Forms.Label lbl_aviso;
        private System.Windows.Forms.Label lbl_Modos;
        private System.Windows.Forms.RadioButton radioBtn_claro;
        private System.Windows.Forms.RadioButton radioBtn_oscuro;
        private System.Windows.Forms.Button btn_carga_modo;
        private System.Windows.Forms.Button btn_traer_modo;
    }
}
