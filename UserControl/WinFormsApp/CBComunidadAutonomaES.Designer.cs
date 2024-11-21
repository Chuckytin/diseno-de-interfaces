namespace WinFormsApp
{
    partial class CBComunidadAutonomaES
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label_CA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(198, 21);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(276, 21);
            this.comboBox.TabIndex = 0;
            // 
            // label_CA
            // 
            this.label_CA.AutoSize = true;
            this.label_CA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CA.Location = new System.Drawing.Point(18, 20);
            this.label_CA.Name = "label_CA";
            this.label_CA.Size = new System.Drawing.Size(164, 19);
            this.label_CA.TabIndex = 1;
            this.label_CA.Text = "Comunidad Autónoma";
            // 
            // CBComunidadAutonomaES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_CA);
            this.Controls.Add(this.comboBox);
            this.Name = "CBComunidadAutonomaES";
            this.Size = new System.Drawing.Size(504, 64);
            this.Load += new System.EventHandler(this.CBComunidadAutonomaES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label_CA;
    }
}
