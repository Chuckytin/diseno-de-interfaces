namespace Calculadora
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_mas_menos = new Button();
            btn_coma = new Button();
            btn_cero = new Button();
            btn_tres = new Button();
            btn_dos = new Button();
            btn_uno = new Button();
            btn_seis = new Button();
            btn_cinco = new Button();
            btn_cuatro = new Button();
            btn_nueve = new Button();
            btn_ocho = new Button();
            btn_siete = new Button();
            button3 = new Button();
            btn_ce = new Button();
            btn_c = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_igual = new Button();
            btn_mas = new Button();
            btn_menos = new Button();
            btn_multiplicar = new Button();
            btn_dividir = new Button();
            textBox1 = new TextBox();
            lbl_op = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btn_mas_menos, 2, 4);
            tableLayoutPanel1.Controls.Add(btn_coma, 1, 4);
            tableLayoutPanel1.Controls.Add(btn_cero, 0, 4);
            tableLayoutPanel1.Controls.Add(btn_tres, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_dos, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_uno, 0, 3);
            tableLayoutPanel1.Controls.Add(btn_seis, 2, 2);
            tableLayoutPanel1.Controls.Add(btn_cinco, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_cuatro, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_nueve, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_ocho, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_siete, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_ce, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_c, 0, 0);
            tableLayoutPanel1.Location = new Point(37, 98);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(200, 324);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_mas_menos
            // 
            btn_mas_menos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_mas_menos.BackColor = SystemColors.ActiveBorder;
            btn_mas_menos.FlatAppearance.BorderColor = Color.Black;
            btn_mas_menos.FlatAppearance.BorderSize = 2;
            btn_mas_menos.FlatStyle = FlatStyle.Flat;
            btn_mas_menos.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_mas_menos.Location = new Point(138, 262);
            btn_mas_menos.Margin = new Padding(6);
            btn_mas_menos.Name = "btn_mas_menos";
            btn_mas_menos.Size = new Size(56, 56);
            btn_mas_menos.TabIndex = 14;
            btn_mas_menos.Text = "+/-";
            btn_mas_menos.UseVisualStyleBackColor = false;
            btn_mas_menos.Click += btn_mas_menos_Click;
            // 
            // btn_coma
            // 
            btn_coma.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_coma.BackColor = SystemColors.ActiveBorder;
            btn_coma.FlatAppearance.BorderColor = Color.Black;
            btn_coma.FlatAppearance.BorderSize = 2;
            btn_coma.FlatStyle = FlatStyle.Flat;
            btn_coma.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_coma.Location = new Point(72, 262);
            btn_coma.Margin = new Padding(6);
            btn_coma.Name = "btn_coma";
            btn_coma.Size = new Size(54, 56);
            btn_coma.TabIndex = 13;
            btn_coma.Text = ",";
            btn_coma.UseVisualStyleBackColor = false;
            btn_coma.Click += btn_coma_Click;
            // 
            // btn_cero
            // 
            btn_cero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_cero.BackColor = SystemColors.ActiveBorder;
            btn_cero.FlatAppearance.BorderColor = Color.Black;
            btn_cero.FlatAppearance.BorderSize = 2;
            btn_cero.FlatStyle = FlatStyle.Flat;
            btn_cero.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_cero.Location = new Point(6, 262);
            btn_cero.Margin = new Padding(6);
            btn_cero.Name = "btn_cero";
            btn_cero.Size = new Size(54, 56);
            btn_cero.TabIndex = 12;
            btn_cero.Text = "0";
            btn_cero.UseVisualStyleBackColor = false;
            btn_cero.Click += addNumber;
            // 
            // btn_tres
            // 
            btn_tres.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_tres.BackColor = SystemColors.ActiveBorder;
            btn_tres.FlatAppearance.BorderColor = Color.Black;
            btn_tres.FlatAppearance.BorderSize = 2;
            btn_tres.FlatStyle = FlatStyle.Flat;
            btn_tres.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_tres.Location = new Point(138, 198);
            btn_tres.Margin = new Padding(6);
            btn_tres.Name = "btn_tres";
            btn_tres.Size = new Size(56, 52);
            btn_tres.TabIndex = 11;
            btn_tres.Text = "3";
            btn_tres.UseVisualStyleBackColor = false;
            btn_tres.Click += addNumber;
            // 
            // btn_dos
            // 
            btn_dos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_dos.BackColor = SystemColors.ActiveBorder;
            btn_dos.FlatAppearance.BorderColor = Color.Black;
            btn_dos.FlatAppearance.BorderSize = 2;
            btn_dos.FlatStyle = FlatStyle.Flat;
            btn_dos.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_dos.Location = new Point(72, 198);
            btn_dos.Margin = new Padding(6);
            btn_dos.Name = "btn_dos";
            btn_dos.Size = new Size(54, 52);
            btn_dos.TabIndex = 10;
            btn_dos.Text = "2";
            btn_dos.UseVisualStyleBackColor = false;
            btn_dos.Click += addNumber;
            // 
            // btn_uno
            // 
            btn_uno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_uno.BackColor = SystemColors.ActiveBorder;
            btn_uno.FlatAppearance.BorderColor = Color.Black;
            btn_uno.FlatAppearance.BorderSize = 2;
            btn_uno.FlatStyle = FlatStyle.Flat;
            btn_uno.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_uno.Location = new Point(6, 198);
            btn_uno.Margin = new Padding(6);
            btn_uno.Name = "btn_uno";
            btn_uno.Size = new Size(54, 52);
            btn_uno.TabIndex = 9;
            btn_uno.Text = "1";
            btn_uno.UseVisualStyleBackColor = false;
            btn_uno.Click += addNumber;
            // 
            // btn_seis
            // 
            btn_seis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_seis.BackColor = SystemColors.ActiveBorder;
            btn_seis.FlatAppearance.BorderColor = Color.Black;
            btn_seis.FlatAppearance.BorderSize = 2;
            btn_seis.FlatStyle = FlatStyle.Flat;
            btn_seis.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_seis.Location = new Point(138, 134);
            btn_seis.Margin = new Padding(6);
            btn_seis.Name = "btn_seis";
            btn_seis.Size = new Size(56, 52);
            btn_seis.TabIndex = 8;
            btn_seis.Text = "6";
            btn_seis.UseVisualStyleBackColor = false;
            btn_seis.Click += addNumber;
            // 
            // btn_cinco
            // 
            btn_cinco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_cinco.BackColor = SystemColors.ActiveBorder;
            btn_cinco.FlatAppearance.BorderColor = Color.Black;
            btn_cinco.FlatAppearance.BorderSize = 2;
            btn_cinco.FlatStyle = FlatStyle.Flat;
            btn_cinco.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_cinco.Location = new Point(72, 134);
            btn_cinco.Margin = new Padding(6);
            btn_cinco.Name = "btn_cinco";
            btn_cinco.Size = new Size(54, 52);
            btn_cinco.TabIndex = 7;
            btn_cinco.Text = "5";
            btn_cinco.UseVisualStyleBackColor = false;
            btn_cinco.Click += addNumber;
            // 
            // btn_cuatro
            // 
            btn_cuatro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_cuatro.BackColor = SystemColors.ActiveBorder;
            btn_cuatro.FlatAppearance.BorderColor = Color.Black;
            btn_cuatro.FlatAppearance.BorderSize = 2;
            btn_cuatro.FlatStyle = FlatStyle.Flat;
            btn_cuatro.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_cuatro.Location = new Point(6, 134);
            btn_cuatro.Margin = new Padding(6);
            btn_cuatro.Name = "btn_cuatro";
            btn_cuatro.Size = new Size(54, 52);
            btn_cuatro.TabIndex = 6;
            btn_cuatro.Text = "4";
            btn_cuatro.UseVisualStyleBackColor = false;
            btn_cuatro.Click += addNumber;
            // 
            // btn_nueve
            // 
            btn_nueve.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_nueve.BackColor = SystemColors.ActiveBorder;
            btn_nueve.FlatAppearance.BorderColor = Color.Black;
            btn_nueve.FlatAppearance.BorderSize = 2;
            btn_nueve.FlatStyle = FlatStyle.Flat;
            btn_nueve.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_nueve.Location = new Point(138, 70);
            btn_nueve.Margin = new Padding(6);
            btn_nueve.Name = "btn_nueve";
            btn_nueve.Size = new Size(56, 52);
            btn_nueve.TabIndex = 5;
            btn_nueve.Text = "9";
            btn_nueve.UseVisualStyleBackColor = false;
            btn_nueve.Click += addNumber;
            // 
            // btn_ocho
            // 
            btn_ocho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_ocho.BackColor = SystemColors.ActiveBorder;
            btn_ocho.FlatAppearance.BorderColor = Color.Black;
            btn_ocho.FlatAppearance.BorderSize = 2;
            btn_ocho.FlatStyle = FlatStyle.Flat;
            btn_ocho.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_ocho.Location = new Point(72, 70);
            btn_ocho.Margin = new Padding(6);
            btn_ocho.Name = "btn_ocho";
            btn_ocho.Size = new Size(54, 52);
            btn_ocho.TabIndex = 4;
            btn_ocho.Text = "8";
            btn_ocho.UseVisualStyleBackColor = false;
            btn_ocho.Click += addNumber;
            // 
            // btn_siete
            // 
            btn_siete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_siete.BackColor = SystemColors.ActiveBorder;
            btn_siete.FlatAppearance.BorderColor = Color.Black;
            btn_siete.FlatAppearance.BorderSize = 2;
            btn_siete.FlatStyle = FlatStyle.Flat;
            btn_siete.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_siete.Location = new Point(6, 70);
            btn_siete.Margin = new Padding(6);
            btn_siete.Name = "btn_siete";
            btn_siete.Size = new Size(54, 52);
            btn_siete.TabIndex = 3;
            btn_siete.Text = "7";
            btn_siete.UseVisualStyleBackColor = false;
            btn_siete.Click += addNumber;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = SystemColors.ActiveBorder;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 15.75F);
            button3.Location = new Point(138, 6);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(56, 52);
            button3.TabIndex = 2;
            button3.Text = "<.";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btn_ce
            // 
            btn_ce.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_ce.BackColor = SystemColors.ActiveBorder;
            btn_ce.FlatAppearance.BorderColor = Color.Black;
            btn_ce.FlatAppearance.BorderSize = 2;
            btn_ce.FlatStyle = FlatStyle.Flat;
            btn_ce.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_ce.Location = new Point(72, 6);
            btn_ce.Margin = new Padding(6);
            btn_ce.Name = "btn_ce";
            btn_ce.Size = new Size(54, 52);
            btn_ce.TabIndex = 1;
            btn_ce.Text = "CE";
            btn_ce.UseVisualStyleBackColor = false;
            btn_ce.Click += btn_ce_Click;
            // 
            // btn_c
            // 
            btn_c.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_c.BackColor = SystemColors.ActiveBorder;
            btn_c.FlatAppearance.BorderColor = Color.Black;
            btn_c.FlatAppearance.BorderSize = 2;
            btn_c.FlatStyle = FlatStyle.Flat;
            btn_c.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_c.Location = new Point(6, 6);
            btn_c.Margin = new Padding(6);
            btn_c.Name = "btn_c";
            btn_c.Size = new Size(54, 52);
            btn_c.TabIndex = 0;
            btn_c.Tag = "btn_c_click";
            btn_c.Text = "C";
            btn_c.UseVisualStyleBackColor = false;
            btn_c.Click += btn_c_Click_1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btn_igual, 0, 4);
            tableLayoutPanel2.Controls.Add(btn_mas, 0, 3);
            tableLayoutPanel2.Controls.Add(btn_menos, 0, 2);
            tableLayoutPanel2.Controls.Add(btn_multiplicar, 0, 1);
            tableLayoutPanel2.Controls.Add(btn_dividir, 0, 0);
            tableLayoutPanel2.Location = new Point(268, 98);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(65, 324);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_igual
            // 
            btn_igual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_igual.BackColor = SystemColors.ActiveBorder;
            btn_igual.FlatAppearance.BorderColor = Color.Black;
            btn_igual.FlatAppearance.BorderSize = 2;
            btn_igual.FlatStyle = FlatStyle.Flat;
            btn_igual.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_igual.Location = new Point(6, 262);
            btn_igual.Margin = new Padding(6);
            btn_igual.Name = "btn_igual";
            btn_igual.Size = new Size(53, 56);
            btn_igual.TabIndex = 5;
            btn_igual.Tag = "btn_igual_click";
            btn_igual.Text = "=";
            btn_igual.UseVisualStyleBackColor = false;
            btn_igual.Click += btn_igual_Click_1;
            // 
            // btn_mas
            // 
            btn_mas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_mas.BackColor = SystemColors.ActiveBorder;
            btn_mas.FlatAppearance.BorderColor = Color.Black;
            btn_mas.FlatAppearance.BorderSize = 2;
            btn_mas.FlatStyle = FlatStyle.Flat;
            btn_mas.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_mas.Location = new Point(6, 198);
            btn_mas.Margin = new Padding(6);
            btn_mas.Name = "btn_mas";
            btn_mas.Size = new Size(53, 52);
            btn_mas.TabIndex = 4;
            btn_mas.Tag = "1";
            btn_mas.Text = "+";
            btn_mas.UseVisualStyleBackColor = false;
            // 
            // btn_menos
            // 
            btn_menos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_menos.BackColor = SystemColors.ActiveBorder;
            btn_menos.FlatAppearance.BorderColor = Color.Black;
            btn_menos.FlatAppearance.BorderSize = 2;
            btn_menos.FlatStyle = FlatStyle.Flat;
            btn_menos.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_menos.Location = new Point(6, 134);
            btn_menos.Margin = new Padding(6);
            btn_menos.Name = "btn_menos";
            btn_menos.Size = new Size(53, 52);
            btn_menos.TabIndex = 3;
            btn_menos.Tag = "2";
            btn_menos.Text = "-";
            btn_menos.UseVisualStyleBackColor = false;
            btn_menos.Click += btn_menos_Click;
            // 
            // btn_multiplicar
            // 
            btn_multiplicar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_multiplicar.BackColor = SystemColors.ActiveBorder;
            btn_multiplicar.FlatAppearance.BorderColor = Color.Black;
            btn_multiplicar.FlatAppearance.BorderSize = 2;
            btn_multiplicar.FlatStyle = FlatStyle.Flat;
            btn_multiplicar.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_multiplicar.Location = new Point(6, 70);
            btn_multiplicar.Margin = new Padding(6);
            btn_multiplicar.Name = "btn_multiplicar";
            btn_multiplicar.Size = new Size(53, 52);
            btn_multiplicar.TabIndex = 2;
            btn_multiplicar.Tag = "3";
            btn_multiplicar.Text = "x";
            btn_multiplicar.UseVisualStyleBackColor = false;
            // 
            // btn_dividir
            // 
            btn_dividir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_dividir.BackColor = SystemColors.ActiveBorder;
            btn_dividir.FlatAppearance.BorderColor = Color.Black;
            btn_dividir.FlatAppearance.BorderSize = 2;
            btn_dividir.FlatStyle = FlatStyle.Flat;
            btn_dividir.Font = new Font("Microsoft Sans Serif", 15.75F);
            btn_dividir.Location = new Point(6, 6);
            btn_dividir.Margin = new Padding(6);
            btn_dividir.Name = "btn_dividir";
            btn_dividir.Size = new Size(53, 52);
            btn_dividir.TabIndex = 1;
            btn_dividir.Tag = "4";
            btn_dividir.Text = "/";
            btn_dividir.UseVisualStyleBackColor = false;
            btn_dividir.Click += btn_dividir_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(37, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 37);
            textBox1.TabIndex = 2;
            // 
            // lbl_op
            // 
            lbl_op.AutoSize = true;
            lbl_op.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_op.Location = new Point(281, 69);
            lbl_op.Name = "lbl_op";
            lbl_op.Size = new Size(46, 18);
            lbl_op.TabIndex = 3;
            lbl_op.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(359, 450);
            Controls.Add(lbl_op);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_mas_menos;
        private Button btn_coma;
        private Button btn_cero;
        private Button btn_tres;
        private Button btn_dos;
        private Button btn_uno;
        private Button btn_seis;
        private Button btn_cinco;
        private Button btn_cuatro;
        private Button btn_nueve;
        private Button btn_ocho;
        private Button btn_siete;
        private Button button3;
        private Button btn_ce;
        private Button btn_c;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_menos;
        private Button btn_multiplicar;
        private Button btn_dividir;
        private Button btn_igual;
        private Button btn_mas;
        private TextBox textBox1;
        private Label lbl_op;
    }
}
