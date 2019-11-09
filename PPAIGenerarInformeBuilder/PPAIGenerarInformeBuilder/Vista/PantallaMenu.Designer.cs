namespace PPAIGenerarInformeBuilder
{
    partial class PantallaMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_generar_informe = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(23, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar programación de Guardias";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(23, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "Finalizar Intervención";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_generar_informe
            // 
            this.btn_generar_informe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_generar_informe.Location = new System.Drawing.Point(237, 185);
            this.btn_generar_informe.Name = "btn_generar_informe";
            this.btn_generar_informe.Size = new System.Drawing.Size(188, 81);
            this.btn_generar_informe.TabIndex = 2;
            this.btn_generar_informe.Text = "Generar Informe de Cumplimiento de Guardias";
            this.btn_generar_informe.UseVisualStyleBackColor = true;
            this.btn_generar_informe.Click += new System.EventHandler(this.btn_generar_informe_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Location = new System.Drawing.Point(237, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 81);
            this.button4.TabIndex = 3;
            this.button4.Text = "Generar reporte de tiempo de Intervenciones";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bravo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_generar_informe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_generar_informe;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

