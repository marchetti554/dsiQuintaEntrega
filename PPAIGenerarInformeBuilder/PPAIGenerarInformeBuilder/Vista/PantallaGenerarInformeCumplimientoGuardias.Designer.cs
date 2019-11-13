namespace PPAIGenerarInformeBuilder.Vista
{
    partial class PantallaGenerarInformeCumplimientoGuardias
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
            this.fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_desde = new System.Windows.Forms.Label();
            this.lbl_fecha_hasta = new System.Windows.Forms.Label();
            this.dgv_bomberos = new System.Windows.Forms.DataGridView();
            this.esSeleccionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_generar_informe = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_bravo = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bomberos)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha_desde
            // 
            this.fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_desde.Location = new System.Drawing.Point(82, 99);
            this.fecha_desde.Margin = new System.Windows.Forms.Padding(2);
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Size = new System.Drawing.Size(210, 20);
            this.fecha_desde.TabIndex = 0;
            this.fecha_desde.Value = new System.DateTime(2019, 11, 13, 0, 0, 0, 0);
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_hasta.Location = new System.Drawing.Point(369, 99);
            this.fecha_hasta.Margin = new System.Windows.Forms.Padding(2);
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Size = new System.Drawing.Size(228, 20);
            this.fecha_hasta.TabIndex = 1;
            this.fecha_hasta.Value = new System.DateTime(2019, 11, 15, 0, 0, 0, 0);
            // 
            // lbl_fecha_desde
            // 
            this.lbl_fecha_desde.AutoSize = true;
            this.lbl_fecha_desde.Location = new System.Drawing.Point(8, 100);
            this.lbl_fecha_desde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha_desde.Name = "lbl_fecha_desde";
            this.lbl_fecha_desde.Size = new System.Drawing.Size(72, 13);
            this.lbl_fecha_desde.TabIndex = 2;
            this.lbl_fecha_desde.Text = "Fecha desde:";
            // 
            // lbl_fecha_hasta
            // 
            this.lbl_fecha_hasta.AutoSize = true;
            this.lbl_fecha_hasta.Location = new System.Drawing.Point(296, 100);
            this.lbl_fecha_hasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha_hasta.Name = "lbl_fecha_hasta";
            this.lbl_fecha_hasta.Size = new System.Drawing.Size(69, 13);
            this.lbl_fecha_hasta.TabIndex = 3;
            this.lbl_fecha_hasta.Text = "Fecha hasta:";
            // 
            // dgv_bomberos
            // 
            this.dgv_bomberos.AllowUserToAddRows = false;
            this.dgv_bomberos.AllowUserToDeleteRows = false;
            this.dgv_bomberos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bomberos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_bomberos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bomberos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.esSeleccionado,
            this.nombre,
            this.apellido,
            this.dni});
            this.dgv_bomberos.Location = new System.Drawing.Point(11, 146);
            this.dgv_bomberos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_bomberos.MultiSelect = false;
            this.dgv_bomberos.Name = "dgv_bomberos";
            this.dgv_bomberos.RowTemplate.Height = 24;
            this.dgv_bomberos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bomberos.Size = new System.Drawing.Size(595, 206);
            this.dgv_bomberos.TabIndex = 4;
            this.dgv_bomberos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bomberos_CellContentClick);
            // 
            // esSeleccionado
            // 
            this.esSeleccionado.HeaderText = "Seleccionado";
            this.esSeleccionado.Name = "esSeleccionado";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.Visible = false;
            // 
            // btn_generar_informe
            // 
            this.btn_generar_informe.Location = new System.Drawing.Point(11, 366);
            this.btn_generar_informe.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generar_informe.Name = "btn_generar_informe";
            this.btn_generar_informe.Size = new System.Drawing.Size(304, 55);
            this.btn_generar_informe.TabIndex = 5;
            this.btn_generar_informe.Text = "Generar Informe";
            this.btn_generar_informe.UseVisualStyleBackColor = true;
            this.btn_generar_informe.Click += new System.EventHandler(this.btn_generar_informe_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(320, 366);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(286, 55);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // lbl_bravo
            // 
            this.lbl_bravo.AutoSize = true;
            this.lbl_bravo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbl_bravo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bravo.Location = new System.Drawing.Point(15, 27);
            this.lbl_bravo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bravo.Name = "lbl_bravo";
            this.lbl_bravo.Size = new System.Drawing.Size(509, 26);
            this.lbl_bravo.TabIndex = 7;
            this.lbl_bravo.Text = "Generar Informe de Cumplimiento de Guardias";
            this.lbl_bravo.Click += new System.EventHandler(this.lbl_bravo_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(611, 133);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 23;
            this.btnValidar.Text = "button1";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-6, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(918, 56);
            this.listBox1.TabIndex = 24;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listBox3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(-124, 65);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(918, 17);
            this.listBox3.TabIndex = 25;
            // 
            // PantallaGenerarInformeCumplimientoGuardias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(688, 435);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lbl_bravo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_generar_informe);
            this.Controls.Add(this.dgv_bomberos);
            this.Controls.Add(this.lbl_fecha_hasta);
            this.Controls.Add(this.lbl_fecha_desde);
            this.Controls.Add(this.fecha_hasta);
            this.Controls.Add(this.fecha_desde);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaGenerarInformeCumplimientoGuardias";
            this.Text = "Bravo";
            this.Load += new System.EventHandler(this.PantallaGenerarInformeCumplimientoGuardias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bomberos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha_desde;
        private System.Windows.Forms.DateTimePicker fecha_hasta;
        private System.Windows.Forms.Label lbl_fecha_desde;
        private System.Windows.Forms.Label lbl_fecha_hasta;
        private System.Windows.Forms.DataGridView dgv_bomberos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.Button btn_generar_informe;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_bravo;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox3;
    }
}