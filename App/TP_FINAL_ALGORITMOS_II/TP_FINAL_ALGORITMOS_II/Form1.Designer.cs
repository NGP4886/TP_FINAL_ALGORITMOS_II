namespace TP_FINAL_ALGORITMOS_II
{
    partial class Form1
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
            this.btnProbar = new System.Windows.Forms.Button();
            this.btnPruebaBDD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProbar
            // 
            this.btnProbar.Location = new System.Drawing.Point(211, 125);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(75, 23);
            this.btnProbar.TabIndex = 0;
            this.btnProbar.Text = "button1";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // btnPruebaBDD
            // 
            this.btnPruebaBDD.Location = new System.Drawing.Point(391, 124);
            this.btnPruebaBDD.Name = "btnPruebaBDD";
            this.btnPruebaBDD.Size = new System.Drawing.Size(75, 23);
            this.btnPruebaBDD.TabIndex = 1;
            this.btnPruebaBDD.Text = "Prueba BDD";
            this.btnPruebaBDD.UseVisualStyleBackColor = true;
            this.btnPruebaBDD.Click += new System.EventHandler(this.btnPruebaBDD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPruebaBDD);
            this.Controls.Add(this.btnProbar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button btnPruebaBDD;
    }
}

