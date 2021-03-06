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
            // Form_Veterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(907, 540);
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
    }
}
