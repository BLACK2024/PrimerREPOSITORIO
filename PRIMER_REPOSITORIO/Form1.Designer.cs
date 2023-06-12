namespace PRIMER_REPOSITORIO
{
    partial class FRMprincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNhola = new System.Windows.Forms.Button();
            this.LBLhola = new System.Windows.Forms.Label();
            this.BTNotroboton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNhola
            // 
            this.BTNhola.Location = new System.Drawing.Point(169, 130);
            this.BTNhola.Name = "BTNhola";
            this.BTNhola.Size = new System.Drawing.Size(75, 23);
            this.BTNhola.TabIndex = 0;
            this.BTNhola.Text = "HOLA";
            this.BTNhola.UseVisualStyleBackColor = true;
            this.BTNhola.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBLhola
            // 
            this.LBLhola.AutoSize = true;
            this.LBLhola.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LBLhola.Location = new System.Drawing.Point(162, 64);
            this.LBLhola.Name = "LBLhola";
            this.LBLhola.Size = new System.Drawing.Size(82, 39);
            this.LBLhola.TabIndex = 2;
            this.LBLhola.Text = "hola";
            // 
            // BTNotroboton
            // 
            this.BTNotroboton.Location = new System.Drawing.Point(169, 193);
            this.BTNotroboton.Name = "BTNotroboton";
            this.BTNotroboton.Size = new System.Drawing.Size(75, 23);
            this.BTNotroboton.TabIndex = 3;
            this.BTNotroboton.Text = "Otro boton";
            this.BTNotroboton.UseVisualStyleBackColor = true;
            // 
            // FRMprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 248);
            this.Controls.Add(this.BTNotroboton);
            this.Controls.Add(this.LBLhola);
            this.Controls.Add(this.BTNhola);
            this.Name = "FRMprincipal";
            this.Text = "priuncipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNhola;
        private System.Windows.Forms.Label LBLhola;
        private System.Windows.Forms.Button BTNotroboton;
    }
}

