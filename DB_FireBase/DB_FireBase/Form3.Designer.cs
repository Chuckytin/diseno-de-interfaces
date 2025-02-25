namespace DB_FireBase
{
    partial class Form3
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_insert = new Button();
            btn_search = new Button();
            btn_retrive = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btn_insert, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_search, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_retrive, 1, 1);
            tableLayoutPanel1.Location = new Point(144, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(212, 143);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_insert
            // 
            btn_insert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_insert.Location = new Point(109, 3);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(100, 65);
            btn_insert.TabIndex = 1;
            btn_insert.Text = "Insertar";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += this.btn_insert_Click;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_search.Location = new Point(3, 3);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(100, 65);
            btn_search.TabIndex = 0;
            btn_search.Text = "Abrir";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_retrive
            // 
            btn_retrive.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_retrive.Location = new Point(109, 74);
            btn_retrive.Name = "btn_retrive";
            btn_retrive.Size = new Size(100, 66);
            btn_retrive.TabIndex = 2;
            btn_retrive.Text = "Recuperar";
            btn_retrive.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(476, 265);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form2";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_insert;
        private Button btn_search;
        private Button btn_retrive;
        private PictureBox pictureBox1;
    }
}