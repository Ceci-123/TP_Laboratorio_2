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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_tipoAnimal = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_devolverInfo = new System.Windows.Forms.RichTextBox();
            this.btn_ImportarJson = new System.Windows.Forms.Button();
            this.btn_importarDBase = new System.Windows.Forms.Button();
            this.btn_ExportarJson = new System.Windows.Forms.Button();
            this.btn_listado = new System.Windows.Forms.Button();
            this.txt_bx_busquedaPorId = new System.Windows.Forms.TextBox();
            this.numeric_peso = new System.Windows.Forms.NumericUpDown();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_pelaje = new System.Windows.Forms.Label();
            this.chk_paseo = new System.Windows.Forms.CheckBox();
            this.btn_ExportarDBase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_peso)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Atencion
            // 
            this.lbl_Atencion.AutoSize = true;
            this.lbl_Atencion.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Atencion.Location = new System.Drawing.Point(15, 34);
            this.lbl_Atencion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Atencion.Name = "lbl_Atencion";
            this.lbl_Atencion.Size = new System.Drawing.Size(143, 23);
            this.lbl_Atencion.TabIndex = 0;
            this.lbl_Atencion.Text = "Atendiendo a";
            // 
            // num_edad
            // 
            this.num_edad.Location = new System.Drawing.Point(166, 155);
            this.num_edad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_edad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_edad.Name = "num_edad";
            this.num_edad.Size = new System.Drawing.Size(85, 22);
            this.num_edad.TabIndex = 1;
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(63, 159);
            this.lbl_edad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(46, 18);
            this.lbl_edad.TabIndex = 2;
            this.lbl_edad.Text = "Edad";
            // 
            // chk_bx_vacunado
            // 
            this.chk_bx_vacunado.AutoSize = true;
            this.chk_bx_vacunado.Location = new System.Drawing.Point(301, 155);
            this.chk_bx_vacunado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_bx_vacunado.Name = "chk_bx_vacunado";
            this.chk_bx_vacunado.Size = new System.Drawing.Size(144, 22);
            this.chk_bx_vacunado.TabIndex = 3;
            this.chk_bx_vacunado.Text = "Esta vacunado?";
            this.chk_bx_vacunado.UseVisualStyleBackColor = true;
            // 
            // lbl_Alta
            // 
            this.lbl_Alta.AutoSize = true;
            this.lbl_Alta.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Alta.Location = new System.Drawing.Point(15, 94);
            this.lbl_Alta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Alta.Name = "lbl_Alta";
            this.lbl_Alta.Size = new System.Drawing.Size(255, 23);
            this.lbl_Alta.TabIndex = 4;
            this.lbl_Alta.Text = "Alta de ficha de paciente";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Location = new System.Drawing.Point(63, 200);
            this.lbl_Peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(42, 18);
            this.lbl_Peso.TabIndex = 5;
            this.lbl_Peso.Text = "Peso";
            // 
            // lbl_raza
            // 
            this.lbl_raza.AutoSize = true;
            this.lbl_raza.Location = new System.Drawing.Point(64, 243);
            this.lbl_raza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_raza.Name = "lbl_raza";
            this.lbl_raza.Size = new System.Drawing.Size(45, 18);
            this.lbl_raza.TabIndex = 6;
            this.lbl_raza.Text = "Raza";
            // 
            // txt_raza
            // 
            this.txt_raza.Location = new System.Drawing.Point(166, 239);
            this.txt_raza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_raza.Name = "txt_raza";
            this.txt_raza.Size = new System.Drawing.Size(127, 22);
            this.txt_raza.TabIndex = 7;
            // 
            // txt_pelaje
            // 
            this.txt_pelaje.Location = new System.Drawing.Point(166, 274);
            this.txt_pelaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pelaje.Name = "txt_pelaje";
            this.txt_pelaje.Size = new System.Drawing.Size(127, 22);
            this.txt_pelaje.TabIndex = 8;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(196, 34);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(90, 23);
            this.lbl_Nombre.TabIndex = 9;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_tipoAnimal
            // 
            this.lbl_tipoAnimal.AutoSize = true;
            this.lbl_tipoAnimal.Location = new System.Drawing.Point(353, 34);
            this.lbl_tipoAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipoAnimal.Name = "lbl_tipoAnimal";
            this.lbl_tipoAnimal.Size = new System.Drawing.Size(142, 18);
            this.lbl_tipoAnimal.TabIndex = 10;
            this.lbl_tipoAnimal.Text = "Tipo de Animalito";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(34, 322);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(436, 28);
            this.btn_ok.TabIndex = 11;
            this.btn_ok.Text = "Ingresar Ficha";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(683, 85);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(222, 28);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar por Id";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_devolverInfo
            // 
            this.txt_devolverInfo.Location = new System.Drawing.Point(560, 131);
            this.txt_devolverInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_devolverInfo.Name = "txt_devolverInfo";
            this.txt_devolverInfo.Size = new System.Drawing.Size(345, 219);
            this.txt_devolverInfo.TabIndex = 13;
            this.txt_devolverInfo.Text = "";
            // 
            // btn_ImportarJson
            // 
            this.btn_ImportarJson.Location = new System.Drawing.Point(34, 379);
            this.btn_ImportarJson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ImportarJson.Name = "btn_ImportarJson";
            this.btn_ImportarJson.Size = new System.Drawing.Size(136, 75);
            this.btn_ImportarJson.TabIndex = 14;
            this.btn_ImportarJson.Text = "Importar datos en formato Json";
            this.btn_ImportarJson.UseVisualStyleBackColor = true;
            // 
            // btn_importarDBase
            // 
            this.btn_importarDBase.Location = new System.Drawing.Point(190, 379);
            this.btn_importarDBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_importarDBase.Name = "btn_importarDBase";
            this.btn_importarDBase.Size = new System.Drawing.Size(137, 75);
            this.btn_importarDBase.TabIndex = 15;
            this.btn_importarDBase.Text = "Importar a Base de datos";
            this.btn_importarDBase.UseVisualStyleBackColor = true;
            // 
            // btn_ExportarJson
            // 
            this.btn_ExportarJson.Location = new System.Drawing.Point(335, 379);
            this.btn_ExportarJson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ExportarJson.Name = "btn_ExportarJson";
            this.btn_ExportarJson.Size = new System.Drawing.Size(130, 75);
            this.btn_ExportarJson.TabIndex = 16;
            this.btn_ExportarJson.Text = "Exportar datos desde formato Json";
            this.btn_ExportarJson.UseVisualStyleBackColor = true;
            // 
            // btn_listado
            // 
            this.btn_listado.Location = new System.Drawing.Point(662, 379);
            this.btn_listado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_listado.Name = "btn_listado";
            this.btn_listado.Size = new System.Drawing.Size(243, 75);
            this.btn_listado.TabIndex = 17;
            this.btn_listado.Text = "Listado de todos los animales";
            this.btn_listado.UseVisualStyleBackColor = true;
            // 
            // txt_bx_busquedaPorId
            // 
            this.txt_bx_busquedaPorId.Location = new System.Drawing.Point(560, 91);
            this.txt_bx_busquedaPorId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_bx_busquedaPorId.Name = "txt_bx_busquedaPorId";
            this.txt_bx_busquedaPorId.Size = new System.Drawing.Size(77, 22);
            this.txt_bx_busquedaPorId.TabIndex = 19;
            // 
            // numeric_peso
            // 
            this.numeric_peso.Location = new System.Drawing.Point(166, 200);
            this.numeric_peso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeric_peso.Name = "numeric_peso";
            this.numeric_peso.Size = new System.Drawing.Size(85, 22);
            this.numeric_peso.TabIndex = 20;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
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
            this.lbl_pelaje.Location = new System.Drawing.Point(63, 278);
            this.lbl_pelaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pelaje.Name = "lbl_pelaje";
            this.lbl_pelaje.Size = new System.Drawing.Size(98, 18);
            this.lbl_pelaje.TabIndex = 22;
            this.lbl_pelaje.Text = "Color Pelaje";
            // 
            // chk_paseo
            // 
            this.chk_paseo.AutoSize = true;
            this.chk_paseo.Location = new System.Drawing.Point(300, 201);
            this.chk_paseo.Name = "chk_paseo";
            this.chk_paseo.Size = new System.Drawing.Size(170, 22);
            this.chk_paseo.TabIndex = 23;
            this.chk_paseo.Text = "Sale con paseador?";
            this.chk_paseo.UseVisualStyleBackColor = true;
            // 
            // btn_ExportarDBase
            // 
            this.btn_ExportarDBase.Location = new System.Drawing.Point(473, 379);
            this.btn_ExportarDBase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ExportarDBase.Name = "btn_ExportarDBase";
            this.btn_ExportarDBase.Size = new System.Drawing.Size(133, 75);
            this.btn_ExportarDBase.TabIndex = 24;
            this.btn_ExportarDBase.Text = "Exportar datos a Base de Datos";
            this.btn_ExportarDBase.UseVisualStyleBackColor = true;
            // 
            // Form_Atencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 479);
            this.Controls.Add(this.btn_ExportarDBase);
            this.Controls.Add(this.chk_paseo);
            this.Controls.Add(this.lbl_pelaje);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.numeric_peso);
            this.Controls.Add(this.txt_bx_busquedaPorId);
            this.Controls.Add(this.btn_listado);
            this.Controls.Add(this.btn_ExportarJson);
            this.Controls.Add(this.btn_importarDBase);
            this.Controls.Add(this.btn_ImportarJson);
            this.Controls.Add(this.txt_devolverInfo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_tipoAnimal);
            this.Controls.Add(this.lbl_Nombre);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Atencion";
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
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_tipoAnimal;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.RichTextBox txt_devolverInfo;
        private System.Windows.Forms.Button btn_ImportarJson;
        private System.Windows.Forms.Button btn_importarDBase;
        private System.Windows.Forms.Button btn_ExportarJson;
        private System.Windows.Forms.Button btn_listado;
        private System.Windows.Forms.TextBox txt_bx_busquedaPorId;
        private System.Windows.Forms.NumericUpDown numeric_peso;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_pelaje;
        private System.Windows.Forms.CheckBox chk_paseo;
        private System.Windows.Forms.Button btn_ExportarDBase;
    }
}