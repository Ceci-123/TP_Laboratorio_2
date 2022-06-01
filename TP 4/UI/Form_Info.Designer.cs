namespace UI
{
    partial class Form_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Info));
            this.btn_GuardarEnXml = new System.Windows.Forms.Button();
            this.richtxt_Info = new System.Windows.Forms.RichTextBox();
            this.btn_CargarDesdeXml = new System.Windows.Forms.Button();
            this.btn_GuardarEnJson = new System.Windows.Forms.Button();
            this.btn_CargarDesdeJson = new System.Windows.Forms.Button();
            this.btn_GuardarEnDbase = new System.Windows.Forms.Button();
            this.btn_CargarDesdeDbase = new System.Windows.Forms.Button();
            this.btn_PaseoPerruno = new System.Windows.Forms.Button();
            this.btn_PaseoGatuno = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GuardarEnXml
            // 
            this.btn_GuardarEnXml.BackColor = System.Drawing.Color.LightCyan;
            this.btn_GuardarEnXml.Location = new System.Drawing.Point(25, 30);
            this.btn_GuardarEnXml.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GuardarEnXml.Name = "btn_GuardarEnXml";
            this.btn_GuardarEnXml.Size = new System.Drawing.Size(165, 121);
            this.btn_GuardarEnXml.TabIndex = 1;
            this.btn_GuardarEnXml.Text = "Guardar datos de pacientes en Xml";
            this.btn_GuardarEnXml.UseVisualStyleBackColor = false;
            this.btn_GuardarEnXml.Click += new System.EventHandler(this.btn_GuardarEnXml_Click);
            // 
            // richtxt_Info
            // 
            this.richtxt_Info.BackColor = System.Drawing.Color.LightCyan;
            this.richtxt_Info.Location = new System.Drawing.Point(25, 338);
            this.richtxt_Info.Margin = new System.Windows.Forms.Padding(4);
            this.richtxt_Info.Name = "richtxt_Info";
            this.richtxt_Info.Size = new System.Drawing.Size(671, 280);
            this.richtxt_Info.TabIndex = 1;
            this.richtxt_Info.Text = "";
            // 
            // btn_CargarDesdeXml
            // 
            this.btn_CargarDesdeXml.BackColor = System.Drawing.Color.LightCyan;
            this.btn_CargarDesdeXml.Location = new System.Drawing.Point(25, 179);
            this.btn_CargarDesdeXml.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CargarDesdeXml.Name = "btn_CargarDesdeXml";
            this.btn_CargarDesdeXml.Size = new System.Drawing.Size(165, 121);
            this.btn_CargarDesdeXml.TabIndex = 5;
            this.btn_CargarDesdeXml.Text = "Cargar datos de pacientes desde Xml";
            this.btn_CargarDesdeXml.UseVisualStyleBackColor = false;
            this.btn_CargarDesdeXml.Click += new System.EventHandler(this.btn_CargarDesdeXml_Click);
            // 
            // btn_GuardarEnJson
            // 
            this.btn_GuardarEnJson.BackColor = System.Drawing.Color.LightCyan;
            this.btn_GuardarEnJson.Location = new System.Drawing.Point(226, 30);
            this.btn_GuardarEnJson.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GuardarEnJson.Name = "btn_GuardarEnJson";
            this.btn_GuardarEnJson.Size = new System.Drawing.Size(165, 121);
            this.btn_GuardarEnJson.TabIndex = 2;
            this.btn_GuardarEnJson.Text = "Guardar datos de paseos perrunos en Json";
            this.btn_GuardarEnJson.UseVisualStyleBackColor = false;
            this.btn_GuardarEnJson.Click += new System.EventHandler(this.btn_GuardarEnJson_Click);
            // 
            // btn_CargarDesdeJson
            // 
            this.btn_CargarDesdeJson.BackColor = System.Drawing.Color.LightCyan;
            this.btn_CargarDesdeJson.Location = new System.Drawing.Point(226, 179);
            this.btn_CargarDesdeJson.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CargarDesdeJson.Name = "btn_CargarDesdeJson";
            this.btn_CargarDesdeJson.Size = new System.Drawing.Size(165, 121);
            this.btn_CargarDesdeJson.TabIndex = 6;
            this.btn_CargarDesdeJson.Text = "Recuperar datos de paseos perrunos desde Json";
            this.btn_CargarDesdeJson.UseVisualStyleBackColor = false;
            this.btn_CargarDesdeJson.Click += new System.EventHandler(this.btn_CargarDesdeJson_Click);
            // 
            // btn_GuardarEnDbase
            // 
            this.btn_GuardarEnDbase.BackColor = System.Drawing.Color.LightCyan;
            this.btn_GuardarEnDbase.Location = new System.Drawing.Point(427, 30);
            this.btn_GuardarEnDbase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GuardarEnDbase.Name = "btn_GuardarEnDbase";
            this.btn_GuardarEnDbase.Size = new System.Drawing.Size(165, 121);
            this.btn_GuardarEnDbase.TabIndex = 3;
            this.btn_GuardarEnDbase.Text = "Enviar datos al Instituto de Zoonosis";
            this.btn_GuardarEnDbase.UseVisualStyleBackColor = false;
            this.btn_GuardarEnDbase.Click += new System.EventHandler(this.btn_GuardarEnDbase_Click);
            // 
            // btn_CargarDesdeDbase
            // 
            this.btn_CargarDesdeDbase.BackColor = System.Drawing.Color.LightCyan;
            this.btn_CargarDesdeDbase.Location = new System.Drawing.Point(427, 179);
            this.btn_CargarDesdeDbase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CargarDesdeDbase.Name = "btn_CargarDesdeDbase";
            this.btn_CargarDesdeDbase.Size = new System.Drawing.Size(165, 121);
            this.btn_CargarDesdeDbase.TabIndex = 7;
            this.btn_CargarDesdeDbase.Text = "Consulta Base de datos del Instituto de Zoonosis";
            this.btn_CargarDesdeDbase.UseVisualStyleBackColor = false;
            this.btn_CargarDesdeDbase.Click += new System.EventHandler(this.btn_CargarDesdeDbase_Click);
            // 
            // btn_PaseoPerruno
            // 
            this.btn_PaseoPerruno.BackColor = System.Drawing.Color.LightCyan;
            this.btn_PaseoPerruno.Location = new System.Drawing.Point(628, 30);
            this.btn_PaseoPerruno.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PaseoPerruno.Name = "btn_PaseoPerruno";
            this.btn_PaseoPerruno.Size = new System.Drawing.Size(165, 121);
            this.btn_PaseoPerruno.TabIndex = 4;
            this.btn_PaseoPerruno.Text = "Mostrar Paseos Perrunos";
            this.btn_PaseoPerruno.UseVisualStyleBackColor = false;
            this.btn_PaseoPerruno.Click += new System.EventHandler(this.btn_PaseoPerruno_Click);
            // 
            // btn_PaseoGatuno
            // 
            this.btn_PaseoGatuno.BackColor = System.Drawing.Color.LightCyan;
            this.btn_PaseoGatuno.Location = new System.Drawing.Point(628, 179);
            this.btn_PaseoGatuno.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PaseoGatuno.Name = "btn_PaseoGatuno";
            this.btn_PaseoGatuno.Size = new System.Drawing.Size(165, 121);
            this.btn_PaseoGatuno.TabIndex = 8;
            this.btn_PaseoGatuno.Text = "Mostrar Paseos Gatunos";
            this.btn_PaseoGatuno.UseVisualStyleBackColor = false;
            this.btn_PaseoGatuno.Click += new System.EventHandler(this.btn_PaseoGatuno_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Salir.Location = new System.Drawing.Point(704, 338);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(92, 280);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Cerrar App";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(818, 653);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_PaseoGatuno);
            this.Controls.Add(this.btn_PaseoPerruno);
            this.Controls.Add(this.btn_CargarDesdeDbase);
            this.Controls.Add(this.btn_GuardarEnDbase);
            this.Controls.Add(this.btn_CargarDesdeJson);
            this.Controls.Add(this.btn_GuardarEnJson);
            this.Controls.Add(this.btn_CargarDesdeXml);
            this.Controls.Add(this.richtxt_Info);
            this.Controls.Add(this.btn_GuardarEnXml);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion sobre Pacientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarEnXml;
        private System.Windows.Forms.RichTextBox richtxt_Info;
        private System.Windows.Forms.Button btn_CargarDesdeXml;
        private System.Windows.Forms.Button btn_GuardarEnJson;
        private System.Windows.Forms.Button btn_CargarDesdeJson;
        private System.Windows.Forms.Button btn_GuardarEnDbase;
        private System.Windows.Forms.Button btn_CargarDesdeDbase;
        private System.Windows.Forms.Button btn_PaseoPerruno;
        private System.Windows.Forms.Button btn_PaseoGatuno;
        private System.Windows.Forms.Button btn_Salir;
    }
}