namespace CalculadoraTP1
{
    partial class FormCalculadora
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
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.btnConvertirADecimal = new System.Windows.Forms.Button();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperador.Location = new System.Drawing.Point(204, 103);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(130, 48);
            this.cmbOperador.TabIndex = 3;
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 40;
            this.lstOperaciones.Location = new System.Drawing.Point(522, 25);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(266, 284);
            this.lstOperaciones.TabIndex = 1;
            // 
            // btnOperar
            // 
            this.btnOperar.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOperar.Location = new System.Drawing.Point(45, 187);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(130, 45);
            this.btnOperar.TabIndex = 5;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btn_operar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.Location = new System.Drawing.Point(204, 187);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 45);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.Location = new System.Drawing.Point(363, 187);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 45);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirABinario.Location = new System.Drawing.Point(45, 278);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(220, 40);
            this.btnConvertirABinario.TabIndex = 8;
            this.btnConvertirABinario.Text = "Convertir a binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btnConvertirABinario_Click);
            // 
            // btnConvertirADecimal
            // 
            this.btnConvertirADecimal.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirADecimal.Location = new System.Drawing.Point(289, 278);
            this.btnConvertirADecimal.Name = "btnConvertirADecimal";
            this.btnConvertirADecimal.Size = new System.Drawing.Size(203, 40);
            this.btnConvertirADecimal.TabIndex = 9;
            this.btnConvertirADecimal.Text = "Convertir a decimal";
            this.btnConvertirADecimal.UseVisualStyleBackColor = true;
            this.btnConvertirADecimal.Click += new System.EventHandler(this.btnConvertirADecimal_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumero2.Location = new System.Drawing.Point(363, 103);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(130, 48);
            this.txtNumero2.TabIndex = 4;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumero1.Location = new System.Drawing.Point(45, 103);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(130, 48);
            this.txtNumero1.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(45, 25);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResultado.Size = new System.Drawing.Size(447, 40);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "label1";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.btnConvertirADecimal);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.cmbOperador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "★·.·´¯`·.·★ Calculadora de Calanna Maria Cecilia del curso 2° D ★·.·´¯`·.·★";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.ListBox lstOperaciones;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.Button btnConvertirADecimal;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblResultado;
    }
}
