namespace PracticaWindowsForms
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            label_info = new Label();
            button_pulsa = new Button();
            label_intentos = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_info
            // 
            label_info.AccessibleDescription = "";
            label_info.AccessibleName = "";
            label_info.Anchor = AnchorStyles.None;
            label_info.AutoSize = true;
            label_info.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_info.Location = new Point(166, 30);
            label_info.Name = "label_info";
            label_info.Size = new Size(10, 23);
            label_info.TabIndex = 0;
            label_info.Text = "\r\n";
            label_info.Click += label1_Click;
            // 
            // button_pulsa
            // 
            button_pulsa.Anchor = AnchorStyles.None;
            button_pulsa.Font = new Font("Century", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_pulsa.Location = new Point(133, 189);
            button_pulsa.Name = "button_pulsa";
            button_pulsa.Size = new Size(75, 36);
            button_pulsa.TabIndex = 1;
            button_pulsa.Text = "Pulsa!";
            button_pulsa.UseVisualStyleBackColor = true;
            button_pulsa.Click += button1_Click;
            // 
            // label_intentos
            // 
            label_intentos.Anchor = AnchorStyles.None;
            label_intentos.AutoSize = true;
            label_intentos.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_intentos.Location = new Point(145, 284);
            label_intentos.Name = "label_intentos";
            label_intentos.Size = new Size(52, 15);
            label_intentos.TabIndex = 2;
            label_intentos.Text = "Intentos";
            label_intentos.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(100, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(button_pulsa, 0, 2);
            tableLayoutPanel1.Controls.Add(label_intentos, 0, 3);
            tableLayoutPanel1.Controls.Add(label_info, 0, 0);
            tableLayoutPanel1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(88, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(342, 335);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_info;
        private Button button_pulsa;
        private Label label_intentos;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
