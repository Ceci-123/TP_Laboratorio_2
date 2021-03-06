namespace UI
{
    partial class Form_Atencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Atencion));
            this.lbl_Atencion = new System.Windows.Forms.Label();
            this.num_edad = new System.Windows.Forms.NumericUpDown();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.chk_bx_vacunado = new System.Windows.Forms.CheckBox();
            this.lbl_Alta = new System.Windows.Forms.Label();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.lbl_raza = new System.Windows.Forms.Label();
            this.txt_raza = new System.Windows.Forms.TextBox();
            this.txt_pelaje = new System.Windows.Forms.TextBox();
            this.lbl_tipoAnimal = new System.Windows.Forms.Label();
            this.btn_ingresarFicha = new System.Windows.Forms.Button();
            this.btn_buscarPorId = new System.Windows.Forms.Button();
            this.txt_devolverInfo = new System.Windows.Forms.RichTextBox();
            this.btn_listado = new System.Windows.Forms.Button();
            this.txt_bx_busquedaPorId = new System.Windows.Forms.TextBox();
            this.numeric_peso = new System.Windows.Forms.NumericUpDown();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_pelaje = new System.Windows.Forms.Label();
            this.chk_paseo = new System.Windows.Forms.CheckBox();
            this.btn_cerrarVentana = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.chk_AplicarVacuna = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_peso)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Atencion
            // 
            this.lbl_Atencion.AutoSize = true;
            this.lbl_Atencion.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Atencion.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Atencion.Location = new System.Drawing.Point(15, 34);
            this.lbl_Atencion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Atencion.Name = "lbl_Atencion";
            this.lbl_Atencion.Size = new System.Drawing.Size(143, 23);
            this.lbl_Atencion.TabIndex = 20;
            this.lbl_Atencion.Text = "Atendiendo a";
            // 
            // num_edad
            // 
            this.num_edad.BackColor = System.Drawing.Color.LightCyan;
            this.num_edad.Location = new System.Drawing.Point(166, 155);
            this.num_edad.Margin = new System.Windows.Forms.Padding(4);
            this.num_edad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_edad.Name = "num_edad";
            this.num_edad.Size = new System.Drawing.Size(85, 22);
            this.num_edad.TabIndex = 3;
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_edad.Location = new System.Drawing.Point(25, 155);
            this.lbl_edad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(46, 18);
            this.lbl_edad.TabIndex = 20;
            this.lbl_edad.Text = "Edad";
            // 
            // chk_bx_vacunado
            // 
            this.chk_bx_vacunado.AutoSize = true;
            this.chk_bx_vacunado.BackColor = System.Drawing.Color.LightCyan;
            this.chk_bx_vacunado.Location = new System.Drawing.Point(360, 212);
            this.chk_bx_vacunado.Margin = new System.Windows.Forms.Padding(4);
            this.chk_bx_vacunado.Name = "chk_bx_vacunado";
            this.chk_bx_vacunado.Size = new System.Drawing.Size(144, 22);
            this.chk_bx_vacunado.TabIndex = 6;
            this.chk_bx_vacunado.Text = "Esta vacunado?";
            this.chk_bx_vacunado.UseVisualStyleBackColor = false;
            // 
            // lbl_Alta
            // 
            this.lbl_Alta.AutoSize = true;
            this.lbl_Alta.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Alta.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Alta.Location = new System.Drawing.Point(15, 94);
            this.lbl_Alta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Alta.Name = "lbl_Alta";
            this.lbl_Alta.Size = new System.Drawing.Size(255, 23);
            this.lbl_Alta.TabIndex = 20;
            this.lbl_Alta.Text = "Alta de ficha de paciente";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Peso.Location = new System.Drawing.Point(25, 200);
            this.lbl_Peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(42, 18);
            this.lbl_Peso.TabIndex = 23;
            this.lbl_Peso.Text = "Peso";
            // 
            // lbl_raza
            // 
            this.lbl_raza.AutoSize = true;
            this.lbl_raza.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_raza.Location = new System.Drawing.Point(25, 242);
            this.lbl_raza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_raza.Name = "lbl_raza";
            this.lbl_raza.Size = new System.Drawing.Size(45, 18);
            this.lbl_raza.TabIndex = 23;
            this.lbl_raza.Text = "Raza";
            // 
            // txt_raza
            // 
            this.txt_raza.BackColor = System.Drawing.Color.LightCyan;
            this.txt_raza.Location = new System.Drawing.Point(166, 239);
            this.txt_raza.Margin = new System.Windows.Forms.Padding(4);
            this.txt_raza.Name = "txt_raza";
            this.txt_raza.Size = new System.Drawing.Size(127, 22);
            this.txt_raza.TabIndex = 7;
            // 
            // txt_pelaje
            // 
            this.txt_pelaje.BackColor = System.Drawing.Color.LightCyan;
            this.txt_pelaje.Location = new System.Drawing.Point(166, 274);
            this.txt_pelaje.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pelaje.Name = "txt_pelaje";
            this.txt_pelaje.Size = new System.Drawing.Size(127, 22);
            this.txt_pelaje.TabIndex = 8;
            // 
            // lbl_tipoAnimal
            // 
            this.lbl_tipoAnimal.AutoSize = true;
            this.lbl_tipoAnimal.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_tipoAnimal.Location = new System.Drawing.Point(353, 34);
            this.lbl_tipoAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipoAnimal.Name = "lbl_tipoAnimal";
            this.lbl_tipoAnimal.Size = new System.Drawing.Size(142, 18);
            this.lbl_tipoAnimal.TabIndex = 23;
            this.lbl_tipoAnimal.Text = "Tipo de Animalito";
            // 
            // btn_ingresarFicha
            // 
            this.btn_ingresarFicha.BackColor = System.Drawing.Color.LightCyan;
            this.btn_ingresarFicha.Location = new System.Drawing.Point(25, 322);
            this.btn_ingresarFicha.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ingresarFicha.Name = "btn_ingresarFicha";
            this.btn_ingresarFicha.Size = new System.Drawing.Size(479, 28);
            this.btn_ingresarFicha.TabIndex = 10;
            this.btn_ingresarFicha.Text = "Ingresar Ficha";
            this.btn_ingresarFicha.UseVisualStyleBackColor = false;
            this.btn_ingresarFicha.Click += new System.EventHandler(this.btn_ingresarFicha_Click);
            // 
            // btn_buscarPorId
            // 
            this.btn_buscarPorId.BackColor = System.Drawing.Color.LightCyan;
            this.btn_buscarPorId.Location = new System.Drawing.Point(683, 85);
            this.btn_buscarPorId.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscarPorId.Name = "btn_buscarPorId";
            this.btn_buscarPorId.Size = new System.Drawing.Size(222, 28);
            this.btn_buscarPorId.TabIndex = 2;
            this.btn_buscarPorId.Text = "Buscar por Id";
            this.btn_buscarPorId.UseVisualStyleBackColor = false;
            this.btn_buscarPorId.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_devolverInfo
            // 
            this.txt_devolverInfo.BackColor = System.Drawing.Color.LightCyan;
            this.txt_devolverInfo.Location = new System.Drawing.Point(560, 131);
            this.txt_devolverInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_devolverInfo.Name = "txt_devolverInfo";
            this.txt_devolverInfo.Size = new System.Drawing.Size(345, 219);
            this.txt_devolverInfo.TabIndex = 13;
            this.txt_devolverInfo.Text = "";
            // 
            // btn_listado
            // 
            this.btn_listado.BackColor = System.Drawing.Color.LightCyan;
            this.btn_listado.Location = new System.Drawing.Point(560, 379);
            this.btn_listado.Margin = new System.Windows.Forms.Padding(4);
            this.btn_listado.Name = "btn_listado";
            this.btn_listado.Size = new System.Drawing.Size(345, 75);
            this.btn_listado.TabIndex = 13;
            this.btn_listado.Text = "Listado de todos los animales ingresados";
            this.btn_listado.UseVisualStyleBackColor = false;
            this.btn_listado.Click += new System.EventHandler(this.btn_listado_Click);
            // 
            // txt_bx_busquedaPorId
            // 
            this.txt_bx_busquedaPorId.BackColor = System.Drawing.Color.LightCyan;
            this.txt_bx_busquedaPorId.Location = new System.Drawing.Point(560, 91);
            this.txt_bx_busquedaPorId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bx_busquedaPorId.Name = "txt_bx_busquedaPorId";
            this.txt_bx_busquedaPorId.Size = new System.Drawing.Size(77, 22);
            this.txt_bx_busquedaPorId.TabIndex = 1;
            // 
            // numeric_peso
            // 
            this.numeric_peso.BackColor = System.Drawing.Color.LightCyan;
            this.numeric_peso.Location = new System.Drawing.Point(166, 200);
            this.numeric_peso.Margin = new System.Windows.Forms.Padding(4);
            this.numeric_peso.Name = "numeric_peso";
            this.numeric_peso.Size = new System.Drawing.Size(85, 22);
            this.numeric_peso.TabIndex = 5;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Id.Location = new System.Drawing.Point(353, 97);
            this.lbl_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(180, 18);
            this.lbl_Id.TabIndex = 21;
            this.lbl_Id.Text = "Si lo conoce, ingrese Id";
            // 
            // lbl_pelaje
            // 
            this.lbl_pelaje.AutoSize = true;
            this.lbl_pelaje.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_pelaje.Location = new System.Drawing.Point(25, 278);
            this.lbl_pelaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pelaje.Name = "lbl_pelaje";
            this.lbl_pelaje.Size = new System.Drawing.Size(98, 18);
            this.lbl_pelaje.TabIndex = 22;
            this.lbl_pelaje.Text = "Color Pelaje";
            // 
            // chk_paseo
            // 
            this.chk_paseo.AutoSize = true;
            this.chk_paseo.BackColor = System.Drawing.Color.LightCyan;
            this.chk_paseo.Location = new System.Drawing.Point(334, 274);
            this.chk_paseo.Name = "chk_paseo";
            this.chk_paseo.Size = new System.Drawing.Size(170, 22);
            this.chk_paseo.TabIndex = 9;
            this.chk_paseo.Text = "Sale con paseador?";
            this.chk_paseo.UseVisualStyleBackColor = false;
            // 
            // btn_cerrarVentana
            // 
            this.btn_cerrarVentana.BackColor = System.Drawing.Color.LightCyan;
            this.btn_cerrarVentana.Location = new System.Drawing.Point(25, 379);
            this.btn_cerrarVentana.Name = "btn_cerrarVentana";
            this.btn_cerrarVentana.Size = new System.Drawing.Size(327, 75);
            this.btn_cerrarVentana.TabIndex = 11;
            this.btn_cerrarVentana.Text = "Regresar al formulario anterior";
            this.btn_cerrarVentana.UseVisualStyleBackColor = false;
            this.btn_cerrarVentana.Click += new System.EventHandler(this.btn_cerrarVentana_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Salir.Location = new System.Drawing.Point(375, 379);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(158, 75);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.Text = "Salir de la App ";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // chk_AplicarVacuna
            // 
            this.chk_AplicarVacuna.AutoSize = true;
            this.chk_AplicarVacuna.Location = new System.Drawing.Point(325, 156);
            this.chk_AplicarVacuna.Name = "chk_AplicarVacuna";
            this.chk_AplicarVacuna.Size = new System.Drawing.Size(179, 22);
            this.chk_AplicarVacuna.TabIndex = 4;
            this.chk_AplicarVacuna.Text = "Aplicar Antirrabica";
            this.chk_AplicarVacuna.UseVisualStyleBackColor = true;
            // 
            // Form_Atencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(927, 479);
            this.Controls.Add(this.chk_AplicarVacuna);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_cerrarVentana);
            this.Controls.Add(this.chk_paseo);
            this.Controls.Add(this.lbl_pelaje);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.numeric_peso);
            this.Controls.Add(this.txt_bx_busquedaPorId);
            this.Controls.Add(this.btn_listado);
            this.Controls.Add(this.txt_devolverInfo);
            this.Controls.Add(this.btn_buscarPorId);
            this.Controls.Add(this.btn_ingresarFicha);
            this.Controls.Add(this.lbl_tipoAnimal);
            this.Controls.Add(this.txt_pelaje);
            this.Controls.Add(this.txt_raza);
            this.Controls.Add(this.lbl_raza);
            this.Controls.Add(this.lbl_Peso);
            this.Controls.Add(this.lbl_Alta);
            this.Controls.Add(this.chk_bx_vacunado);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.num_edad);
            this.Controls.Add(this.lbl_Atencion);
            this.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Atencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeñas Patitas";
            this.Load += new System.EventHandler(this.Form_Atencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_peso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Atencion;
        private System.Windows.Forms.NumericUpDown num_edad;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.CheckBox chk_bx_vacunado;
        private System.Windows.Forms.Label lbl_Alta;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.Label lbl_raza;
        private System.Windows.Forms.TextBox txt_raza;
        private System.Windows.Forms.TextBox txt_pelaje;
        private System.Windows.Forms.Label lbl_tipoAnimal;
        private System.Windows.Forms.Button btn_ingresarFicha;
        private System.Windows.Forms.Button btn_buscarPorId;
        private System.Windows.Forms.RichTextBox txt_devolverInfo;
        private System.Windows.Forms.Button btn_listado;
        private System.Windows.Forms.TextBox txt_bx_busquedaPorId;
        private System.Windows.Forms.NumericUpDown numeric_peso;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_pelaje;
        private System.Windows.Forms.CheckBox chk_paseo;
        private System.Windows.Forms.Button btn_cerrarVentana;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.CheckBox chk_AplicarVacuna;
    }
}