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
            this.btn_CargaXML = new System.Windows.Forms.Button();
            this.btn_GuardarXml = new System.Windows.Forms.Button();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.lbl_mensajito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_NombreVet
            // 
            this.lbl_NombreVet.AutoSize = true;
            this.lbl_NombreVet.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreVet.Location = new System.Drawing.Point(379, 22);
            this.lbl_NombreVet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NombreVet.Name = "lbl_NombreVet";
            this.lbl_NombreVet.Size = new System.Drawing.Size(148, 26);
            this.lbl_NombreVet.TabIndex = 0;
            this.lbl_NombreVet.Text = "Veterinaria";
            // 
            // lbl_PacientesEnEspera
            // 
            this.lbl_PacientesEnEspera.AutoSize = true;
            this.lbl_PacientesEnEspera.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PacientesEnEspera.Location = new System.Drawing.Point(600, 79);
            this.lbl_PacientesEnEspera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PacientesEnEspera.Name = "lbl_PacientesEnEspera";
            this.lbl_PacientesEnEspera.Size = new System.Drawing.Size(207, 23);
            this.lbl_PacientesEnEspera.TabIndex = 1;
            this.lbl_PacientesEnEspera.Text = "Pacientes en Espera";
            // 
            // btn_AtenderProximo
            // 
            this.btn_AtenderProximo.Location = new System.Drawing.Point(217, 157);
            this.btn_AtenderProximo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AtenderProximo.Name = "btn_AtenderProximo";
            this.btn_AtenderProximo.Size = new System.Drawing.Size(147, 95);
            this.btn_AtenderProximo.TabIndex = 2;
            this.btn_AtenderProximo.Text = "Atender Proximo";
            this.btn_AtenderProximo.UseVisualStyleBackColor = true;
            this.btn_AtenderProximo.Click += new System.EventHandler(this.btn_AtenderProximo_Click);
            // 
            // rchTxt_Info
            // 
            this.rchTxt_Info.Location = new System.Drawing.Point(444, 157);
            this.rchTxt_Info.Margin = new System.Windows.Forms.Padding(4);
            this.rchTxt_Info.Name = "rchTxt_Info";
            this.rchTxt_Info.Size = new System.Drawing.Size(435, 256);
            this.rchTxt_Info.TabIndex = 3;
            this.rchTxt_Info.Text = "";
            // 
            // btn_AgregarPaciente
            // 
            this.btn_AgregarPaciente.Location = new System.Drawing.Point(33, 157);
            this.btn_AgregarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgregarPaciente.Name = "btn_AgregarPaciente";
            this.btn_AgregarPaciente.Size = new System.Drawing.Size(158, 95);
            this.btn_AgregarPaciente.TabIndex = 4;
            this.btn_AgregarPaciente.Text = "Agregar un Paciente";
            this.btn_AgregarPaciente.UseVisualStyleBackColor = true;
            this.btn_AgregarPaciente.Click += new System.EventHandler(this.btn_AgregarPaciente_Click);
            // 
            // lbl_NombrePaciente
            // 
            this.lbl_NombrePaciente.AutoSize = true;
            this.lbl_NombrePaciente.Location = new System.Drawing.Point(33, 306);
            this.lbl_NombrePaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NombrePaciente.Name = "lbl_NombrePaciente";
            this.lbl_NombrePaciente.Size = new System.Drawing.Size(164, 18);
            this.lbl_NombrePaciente.TabIndex = 5;
            this.lbl_NombrePaciente.Text = "Nombre del Paciente";
            // 
            // txt_bx_nombre
            // 
            this.txt_bx_nombre.Location = new System.Drawing.Point(217, 302);
            this.txt_bx_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bx_nombre.Name = "txt_bx_nombre";
            this.txt_bx_nombre.Size = new System.Drawing.Size(154, 22);
            this.txt_bx_nombre.TabIndex = 6;
            // 
            // lbl_TipoAnimal
            // 
            this.lbl_TipoAnimal.AutoSize = true;
            this.lbl_TipoAnimal.Location = new System.Drawing.Point(33, 375);
            this.lbl_TipoAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TipoAnimal.Name = "lbl_TipoAnimal";
            this.lbl_TipoAnimal.Size = new System.Drawing.Size(48, 18);
            this.lbl_TipoAnimal.TabIndex = 7;
            this.lbl_TipoAnimal.Text = "Es un";
            // 
            // cmb_TipoAnimal
            // 
            this.cmb_TipoAnimal.FormattingEnabled = true;
            this.cmb_TipoAnimal.Location = new System.Drawing.Point(217, 367);
            this.cmb_TipoAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_TipoAnimal.Name = "cmb_TipoAnimal";
            this.cmb_TipoAnimal.Size = new System.Drawing.Size(154, 26);
            this.cmb_TipoAnimal.TabIndex = 8;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(139, 448);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(96, 61);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_CargaXML
            // 
            this.btn_CargaXML.Location = new System.Drawing.Point(444, 448);
            this.btn_CargaXML.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CargaXML.Name = "btn_CargaXML";
            this.btn_CargaXML.Size = new System.Drawing.Size(181, 61);
            this.btn_CargaXML.TabIndex = 11;
            this.btn_CargaXML.Text = "Cargar desde XML";
            this.btn_CargaXML.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarXml
            // 
            this.btn_GuardarXml.Location = new System.Drawing.Point(689, 448);
            this.btn_GuardarXml.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GuardarXml.Name = "btn_GuardarXml";
            this.btn_GuardarXml.Size = new System.Drawing.Size(190, 61);
            this.btn_GuardarXml.TabIndex = 13;
            this.btn_GuardarXml.Text = "Guardar en XML";
            this.btn_GuardarXml.UseVisualStyleBackColor = true;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hora.Location = new System.Drawing.Point(404, 79);
            this.lbl_Hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(60, 23);
            this.lbl_Hora.TabIndex = 14;
            this.lbl_Hora.Text = "Hora";
            // 
            // lbl_mensajito
            // 
            this.lbl_mensajito.AutoSize = true;
            this.lbl_mensajito.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajito.Location = new System.Drawing.Point(33, 79);
            this.lbl_mensajito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mensajito.Name = "lbl_mensajito";
            this.lbl_mensajito.Size = new System.Drawing.Size(107, 23);
            this.lbl_mensajito.TabIndex = 15;
            this.lbl_mensajito.Text = "Mensajito";
            // 
            // Form_Veterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 540);
            this.Controls.Add(this.lbl_mensajito);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.btn_GuardarXml);
            this.Controls.Add(this.btn_CargaXML);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Veterinaria";
            this.Text = "Pequeñas Patitas";
            this.Load += new System.EventHandler(this.Form_Veterinaria_Load);
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
        private System.Windows.Forms.Button btn_CargaXML;
        private System.Windows.Forms.Button btn_GuardarXml;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label lbl_mensajito;
    }
}
