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
            this.SuspendLayout();
            // 
            // btn_GuardarEnXml
            // 
            this.btn_GuardarEnXml.Location = new System.Drawing.Point(57, 30);
            this.btn_GuardarEnXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GuardarEnXml.Name = "btn_GuardarEnXml";
            this.btn_GuardarEnXml.Size = new System.Drawing.Size(165, 121);
            this.btn_GuardarEnXml.TabIndex = 0;
            this.btn_GuardarEnXml.Text = "Guardar datos en Xml";
            this.btn_GuardarEnXml.UseVisualStyleBackColor = true;
            this.btn_GuardarEnXml.Click += new System.EventHandler(this.btn_GuardarEnXml_Click);
            // 
            // richtxt_Info
            // 
            this.richtxt_Info.Location = new System.Drawing.Point(57, 343);
            this.richtxt_Info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richtxt_Info.Name = "richtxt_Info";
            this.richtxt_Info.Size = new System.Drawing.Size(610, 280);
            this.richtxt_Info.TabIndex = 1;
            this.richtxt_Info.Text = "";
            // 
            // btn_CargarDesdeXml
            // 
            this.btn_CargarDesdeXml.Location = new System.Drawing.Point(57, 194);
            this.btn_CargarDesdeXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CargarDesdeXml.Name = "btn_CargarDesdeXml";
            this.btn_CargarDesdeXml.Size = new System.Drawing.Size(165, 121);
            this.btn_CargarDesdeXml.TabIndex = 2;
            this.btn_CargarDesdeXml.Text = "Cargar datos desde Xml";
            this.btn_CargarDesdeXml.UseVisualStyleBackColor = true;
            this.btn_CargarDesdeXml.Click += new System.EventHandler(this.btn_CargarDesdeXml_Click);
            // 
            // btn_GuardarEnJson
            // 
            this.btn_GuardarEnJson.Location = new System.Drawing.Point(288, 30);
            this.btn_GuardarEnJson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GuardarEnJson.Name = "btn_GuardarEnJson";
            this.btn_GuardarEnJson.Size = new System.Drawing.Size(165, 121);
            this.btn_GuardarEnJson.TabIndex = 3;
            this.btn_GuardarEnJson.Text = "Guardar datos en Json";
            this.btn_GuardarEnJson.UseVisualStyleBackColor = true;
            this.btn_GuardarEnJson.Click += new System.EventHandler(this.btn_GuardarEnJson_Click);
            // 
            // btn_CargarDesdeJson
            // 
            this.btn_CargarDesdeJson.Location = new System.Drawing.Point(288, 194);
            this.btn_CargarDesdeJson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CargarDesdeJson.Name = "btn_CargarDesdeJson";
            this.btn_CargarDesdeJson.Size = new System.Drawing.Size(165, 121);
            this.btn_CargarDesdeJson.TabIndex = 4;
            this.btn_CargarDesdeJson.Text = "Cargar datos desde Json";
            this.btn_CargarDesdeJson.UseVisualStyleBackColor = true;
            this.btn_CargarDesdeJson.Click += new System.EventHandler(this.btn_CargarDesdeJson_Click);
            // 
            // btn_GuardarEnDbase
            // 
            this.btn_GuardarEnDbase.Location = new System.Drawing.Point(503, 30);
            this.btn_GuardarEnDbase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GuardarEnDbase.Name = "btn_GuardarEnDbase";
            this.btn_GuardarEnDbase.Size = new System.Drawing.Size(165, 121);
            this.btn_GuardarEnDbase.TabIndex = 5;
            this.btn_GuardarEnDbase.Text = "Guardar datos en base de datos";
            this.btn_GuardarEnDbase.UseVisualStyleBackColor = true;
            this.btn_GuardarEnDbase.Click += new System.EventHandler(this.btn_GuardarEnDbase_Click);
            // 
            // btn_CargarDesdeDbase
            // 
            this.btn_CargarDesdeDbase.Location = new System.Drawing.Point(503, 194);
            this.btn_CargarDesdeDbase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CargarDesdeDbase.Name = "btn_CargarDesdeDbase";
            this.btn_CargarDesdeDbase.Size = new System.Drawing.Size(165, 121);
            this.btn_CargarDesdeDbase.TabIndex = 6;
            this.btn_CargarDesdeDbase.Text = "Cargar datos desde base de datos";
            this.btn_CargarDesdeDbase.UseVisualStyleBackColor = true;
            this.btn_CargarDesdeDbase.Click += new System.EventHandler(this.btn_CargarDesdeDbase_Click);
            // 
            // Form_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(735, 653);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}