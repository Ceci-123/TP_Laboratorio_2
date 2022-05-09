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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_tipoAnimal = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Atencion
            // 
            this.lbl_Atencion.AutoSize = true;
            this.lbl_Atencion.Location = new System.Drawing.Point(84, 38);
            this.lbl_Atencion.Name = "lbl_Atencion";
            this.lbl_Atencion.Size = new System.Drawing.Size(78, 15);
            this.lbl_Atencion.TabIndex = 0;
            this.lbl_Atencion.Text = "Atendiendo a";
            // 
            // num_edad
            // 
            this.num_edad.Location = new System.Drawing.Point(212, 173);
            this.num_edad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_edad.Name = "num_edad";
            this.num_edad.Size = new System.Drawing.Size(120, 23);
            this.num_edad.TabIndex = 1;
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(86, 175);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_edad.TabIndex = 2;
            this.lbl_edad.Text = "Edad";
            // 
            // chk_bx_vacunado
            // 
            this.chk_bx_vacunado.AutoSize = true;
            this.chk_bx_vacunado.Location = new System.Drawing.Point(93, 237);
            this.chk_bx_vacunado.Name = "chk_bx_vacunado";
            this.chk_bx_vacunado.Size = new System.Drawing.Size(107, 19);
            this.chk_bx_vacunado.TabIndex = 3;
            this.chk_bx_vacunado.Text = "Esta vacunado?";
            this.chk_bx_vacunado.UseVisualStyleBackColor = true;
            // 
            // lbl_Alta
            // 
            this.lbl_Alta.AutoSize = true;
            this.lbl_Alta.Location = new System.Drawing.Point(84, 86);
            this.lbl_Alta.Name = "lbl_Alta";
            this.lbl_Alta.Size = new System.Drawing.Size(137, 15);
            this.lbl_Alta.TabIndex = 4;
            this.lbl_Alta.Text = "Alta de ficha de paciente";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Location = new System.Drawing.Point(93, 291);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(32, 15);
            this.lbl_Peso.TabIndex = 5;
            this.lbl_Peso.Text = "Peso";
            // 
            // lbl_raza
            // 
            this.lbl_raza.AutoSize = true;
            this.lbl_raza.Location = new System.Drawing.Point(96, 339);
            this.lbl_raza.Name = "lbl_raza";
            this.lbl_raza.Size = new System.Drawing.Size(31, 15);
            this.lbl_raza.TabIndex = 6;
            this.lbl_raza.Text = "Raza";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 334);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(221, 36);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 9;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_tipoAnimal
            // 
            this.lbl_tipoAnimal.AutoSize = true;
            this.lbl_tipoAnimal.Location = new System.Drawing.Point(344, 41);
            this.lbl_tipoAnimal.Name = "lbl_tipoAnimal";
            this.lbl_tipoAnimal.Size = new System.Drawing.Size(101, 15);
            this.lbl_tipoAnimal.TabIndex = 10;
            this.lbl_tipoAnimal.Text = "Tipo de Animalito";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(462, 281);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(158, 23);
            this.btn_ok.TabIndex = 11;
            this.btn_ok.Text = "Ingresar animal";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Form_Atencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_tipoAnimal);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_raza);
            this.Controls.Add(this.lbl_Peso);
            this.Controls.Add(this.lbl_Alta);
            this.Controls.Add(this.chk_bx_vacunado);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.num_edad);
            this.Controls.Add(this.lbl_Atencion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Atencion";
            this.Text = "Form_Atencion";
            this.Load += new System.EventHandler(this.Form_Atencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_tipoAnimal;
        private System.Windows.Forms.Button btn_ok;
    }
}