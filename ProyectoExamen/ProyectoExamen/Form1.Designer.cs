namespace ProyectoExamen
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
            this.cartaProducto1 = new ProyectoExamen.CartaProducto();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cartaProducto1
            // 
            this.cartaProducto1.BackColor = System.Drawing.Color.Red;
            this.cartaProducto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartaProducto1.Location = new System.Drawing.Point(0, 0);
            this.cartaProducto1.Name = "cartaProducto1";
            this.cartaProducto1.Size = new System.Drawing.Size(984, 611);
            this.cartaProducto1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "EXAMEN NAVIDEÑO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartaProducto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CartaProducto cartaProducto1;
        private System.Windows.Forms.Label label1;
    }
}

