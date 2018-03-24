namespace Carrera
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
            this.btnCorrer = new System.Windows.Forms.Button();
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(95, 12);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(136, 40);
            this.btnCorrer.TabIndex = 0;
            this.btnCorrer.Text = "Comenzar carrera";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(34, 79);
            this.txtMuestra.Multiline = true;
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(281, 289);
            this.txtMuestra.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 377);
            this.Controls.Add(this.txtMuestra);
            this.Controls.Add(this.btnCorrer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.TextBox txtMuestra;
    }
}

