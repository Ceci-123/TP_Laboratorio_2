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
            this.btn_Carga_Xml = new System.Windows.Forms.Button();
            this.btn_CargaJson = new System.Windows.Forms.Button();
            this.btn_GuardarJson = new System.Windows.Forms.Button();
            this.btn_GuardarXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_NombreVet
            // 
            this.lbl_NombreVet.AutoSize = true;
            this.lbl_NombreVet.Location = new System.Drawing.Point(261, 25);
            this.lbl_NombreVet.Name = "lbl_NombreVet";
            this.lbl_NombreVet.Size = new System.Drawing.Size(62, 15);
            this.lbl_NombreVet.TabIndex = 0;
            this.lbl_NombreVet.Text = "Veterinaria";
            // 
            // lbl_PacientesEnEspera
            // 
            this.lbl_PacientesEnEspera.AutoSize = true;
            this.lbl_PacientesEnEspera.Location = new System.Drawing.Point(36, 91);
            this.lbl_PacientesEnEspera.Name = "lbl_PacientesEnEspera";
            this.lbl_PacientesEnEspera.Size = new System.Drawing.Size(110, 15);
            this.lbl_PacientesEnEspera.TabIndex = 1;
            this.lbl_PacientesEnEspera.Text = "Pacientes en Espera";
            // 
            // btn_AtenderProximo
            // 
            this.btn_AtenderProximo.Location = new System.Drawing.Point(39, 170);
            this.btn_AtenderProximo.Name = "btn_AtenderProximo";
            this.btn_AtenderProximo.Size = new System.Drawing.Size(114, 23);
            this.btn_AtenderProximo.TabIndex = 2;
            this.btn_AtenderProximo.Text = "Atender Proximo";
            this.btn_AtenderProximo.UseVisualStyleBackColor = true;
            this.btn_AtenderProximo.Click += new System.EventHandler(this.btn_AtenderProximo_Click);
            // 
            // rchTxt_Info
            // 
            this.rchTxt_Info.Location = new System.Drawing.Point(332, 160);
            this.rchTxt_Info.Name = "rchTxt_Info";
            this.rchTxt_Info.Size = new System.Drawing.Size(100, 96);
            this.rchTxt_Info.TabIndex = 3;
            this.rchTxt_Info.Text = "";
            // 
            // btn_AgregarPaciente
            // 
            this.btn_AgregarPaciente.Location = new System.Drawing.Point(54, 288);
            this.btn_AgregarPaciente.Name = "btn_AgregarPaciente";
            this.btn_AgregarPaciente.Size = new System.Drawing.Size(123, 23);
            this.btn_AgregarPaciente.TabIndex = 4;
            this.btn_AgregarPaciente.Text = "Agregar un Paciente";
            this.btn_AgregarPaciente.UseVisualStyleBackColor = true;
            this.btn_AgregarPaciente.Click += new System.EventHandler(this.btn_AgregarPaciente_Click);
            // 
            // lbl_NombrePaciente
            // 
            this.lbl_NombrePaciente.AutoSize = true;
            this.lbl_NombrePaciente.Location = new System.Drawing.Point(213, 330);
            this.lbl_NombrePaciente.Name = "lbl_NombrePaciente";
            this.lbl_NombrePaciente.Size = new System.Drawing.Size(118, 15);
            this.lbl_NombrePaciente.TabIndex = 5;
            this.lbl_NombrePaciente.Text = "Nombre del Paciente";
            // 
            // txt_bx_nombre
            // 
            this.txt_bx_nombre.Location = new System.Drawing.Point(340, 330);
            this.txt_bx_nombre.Name = "txt_bx_nombre";
            this.txt_bx_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_bx_nombre.TabIndex = 6;
            // 
            // lbl_TipoAnimal
            // 
            this.lbl_TipoAnimal.AutoSize = true;
            this.lbl_TipoAnimal.Location = new System.Drawing.Point(218, 381);
            this.lbl_TipoAnimal.Name = "lbl_TipoAnimal";
            this.lbl_TipoAnimal.Size = new System.Drawing.Size(35, 15);
            this.lbl_TipoAnimal.TabIndex = 7;
            this.lbl_TipoAnimal.Text = "Es un";
            // 
            // cmb_TipoAnimal
            // 
            this.cmb_TipoAnimal.FormattingEnabled = true;
            this.cmb_TipoAnimal.Location = new System.Drawing.Point(345, 379);
            this.cmb_TipoAnimal.Name = "cmb_TipoAnimal";
            this.cmb_TipoAnimal.Size = new System.Drawing.Size(121, 23);
            this.cmb_TipoAnimal.TabIndex = 8;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(505, 347);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Carga_Xml
            // 
            this.btn_Carga_Xml.Location = new System.Drawing.Point(561, 162);
            this.btn_Carga_Xml.Name = "btn_Carga_Xml";
            this.btn_Carga_Xml.Size = new System.Drawing.Size(75, 23);
            this.btn_Carga_Xml.TabIndex = 10;
            this.btn_Carga_Xml.Text = "Cargar desde xml";
            this.btn_Carga_Xml.UseVisualStyleBackColor = true;
            // 
            // btn_CargaJson
            // 
            this.btn_CargaJson.Location = new System.Drawing.Point(564, 252);
            this.btn_CargaJson.Name = "btn_CargaJson";
            this.btn_CargaJson.Size = new System.Drawing.Size(75, 23);
            this.btn_CargaJson.TabIndex = 11;
            this.btn_CargaJson.Text = "Cargar desde Json";
            this.btn_CargaJson.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarJson
            // 
            this.btn_GuardarJson.Location = new System.Drawing.Point(546, 103);
            this.btn_GuardarJson.Name = "btn_GuardarJson";
            this.btn_GuardarJson.Size = new System.Drawing.Size(75, 23);
            this.btn_GuardarJson.TabIndex = 12;
            this.btn_GuardarJson.Text = "Guardar en Json";
            this.btn_GuardarJson.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarXml
            // 
            this.btn_GuardarXml.Location = new System.Drawing.Point(550, 66);
            this.btn_GuardarXml.Name = "btn_GuardarXml";
            this.btn_GuardarXml.Size = new System.Drawing.Size(75, 23);
            this.btn_GuardarXml.TabIndex = 13;
            this.btn_GuardarXml.Text = "Guardar en XML";
            this.btn_GuardarXml.UseVisualStyleBackColor = true;
            // 
            // Form_Veterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GuardarXml);
            this.Controls.Add(this.btn_GuardarJson);
            this.Controls.Add(this.btn_CargaJson);
            this.Controls.Add(this.btn_Carga_Xml);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btn_Carga_Xml;
        private System.Windows.Forms.Button btn_CargaJson;
        private System.Windows.Forms.Button btn_GuardarJson;
        private System.Windows.Forms.Button btn_GuardarXml;
    }
}
