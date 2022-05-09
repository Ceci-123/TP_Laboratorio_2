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
            this.lbl_Atencion = new System.Windows.Forms.Label();
            this.num_edad = new System.Windows.Forms.NumericUpDown();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.chk_bx_vacunado = new System.Windows.Forms.CheckBox();
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
            // Form_Atencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_bx_vacunado);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.num_edad);
            this.Controls.Add(this.lbl_Atencion);
            this.Name = "Form_Atencion";
            this.Text = "Form_Atencion";
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Atencion;
        private System.Windows.Forms.NumericUpDown num_edad;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.CheckBox chk_bx_vacunado;
    }
}