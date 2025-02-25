namespace DB_FireBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            text_age = new TextBox();
            text_address = new TextBox();
            text_name = new TextBox();
            lbl_id = new Label();
            lbl_name = new Label();
            lnl_address = new Label();
            lbl_age = new Label();
            text_id = new TextBox();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_insert = new Button();
            btn_get = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            button1 = new Button();
            lbl_inform = new Label();
            btn_visual = new Button();
            btn_image = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(text_age, 1, 3);
            tableLayoutPanel1.Controls.Add(text_address, 1, 2);
            tableLayoutPanel1.Controls.Add(text_name, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl_id, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_name, 0, 1);
            tableLayoutPanel1.Controls.Add(lnl_address, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_age, 0, 3);
            tableLayoutPanel1.Controls.Add(text_id, 1, 0);
            tableLayoutPanel1.Location = new Point(55, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(247, 117);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // text_age
            // 
            text_age.Location = new Point(89, 90);
            text_age.Name = "text_age";
            text_age.Size = new Size(155, 23);
            text_age.TabIndex = 11;
            // 
            // text_address
            // 
            text_address.Location = new Point(89, 61);
            text_address.Name = "text_address";
            text_address.Size = new Size(155, 23);
            text_address.TabIndex = 10;
            // 
            // text_name
            // 
            text_name.Location = new Point(89, 32);
            text_name.Name = "text_name";
            text_name.Size = new Size(155, 23);
            text_name.TabIndex = 9;
            // 
            // lbl_id
            // 
            lbl_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(3, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(80, 29);
            lbl_id.TabIndex = 4;
            lbl_id.Text = "Id:";
            // 
            // lbl_name
            // 
            lbl_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(3, 29);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(80, 29);
            lbl_name.TabIndex = 5;
            lbl_name.Text = "Nombre:";
            // 
            // lnl_address
            // 
            lnl_address.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lnl_address.AutoSize = true;
            lnl_address.Location = new Point(3, 58);
            lnl_address.Name = "lnl_address";
            lnl_address.Size = new Size(80, 29);
            lnl_address.TabIndex = 6;
            lnl_address.Text = "Dirección:";
            // 
            // lbl_age
            // 
            lbl_age.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_age.AutoSize = true;
            lbl_age.Location = new Point(3, 87);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(80, 30);
            lbl_age.TabIndex = 7;
            lbl_age.Text = "Edad:";
            // 
            // text_id
            // 
            text_id.Location = new Point(89, 3);
            text_id.Name = "text_id";
            text_id.Size = new Size(155, 23);
            text_id.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(560, 190);
            dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(btn_insert, 0, 0);
            tableLayoutPanel2.Controls.Add(btn_get, 0, 1);
            tableLayoutPanel2.Controls.Add(btn_update, 0, 2);
            tableLayoutPanel2.Controls.Add(btn_delete, 0, 3);
            tableLayoutPanel2.Controls.Add(button1, 1, 4);
            tableLayoutPanel2.Location = new Point(393, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(222, 155);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(3, 3);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(71, 23);
            btn_insert.TabIndex = 0;
            btn_insert.Text = "Insertar";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_get
            // 
            btn_get.Location = new Point(3, 34);
            btn_get.Name = "btn_get";
            btn_get.Size = new Size(71, 23);
            btn_get.TabIndex = 1;
            btn_get.Text = "Recuperar";
            btn_get.UseVisualStyleBackColor = true;
            btn_get.Click += btn_get_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(3, 65);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(71, 23);
            btn_update.TabIndex = 2;
            btn_update.Text = "Actualizar";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(3, 96);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(71, 24);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Eliminar";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_ClickAsync;
            // 
            // button1
            // 
            button1.Location = new Point(80, 127);
            button1.Name = "button1";
            button1.Size = new Size(139, 24);
            button1.TabIndex = 4;
            button1.Text = "Eliminar Todo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_inform
            // 
            lbl_inform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_inform.AutoSize = true;
            lbl_inform.Location = new Point(55, 22);
            lbl_inform.Name = "lbl_inform";
            lbl_inform.Size = new Size(144, 15);
            lbl_inform.TabIndex = 12;
            lbl_inform.Text = "Información del elemento";
            // 
            // btn_visual
            // 
            btn_visual.Location = new Point(512, 188);
            btn_visual.Name = "btn_visual";
            btn_visual.Size = new Size(103, 37);
            btn_visual.TabIndex = 4;
            btn_visual.Text = "Visualizar datos";
            btn_visual.UseVisualStyleBackColor = true;
            btn_visual.Click += btn_visual_Click;
            // 
            // btn_image
            // 
            btn_image.Location = new Point(512, 443);
            btn_image.Name = "btn_image";
            btn_image.Size = new Size(100, 38);
            btn_image.TabIndex = 13;
            btn_image.Text = "Gestor";
            btn_image.UseVisualStyleBackColor = true;
            btn_image.Click += btn_image_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 493);
            Controls.Add(btn_image);
            Controls.Add(btn_visual);
            Controls.Add(lbl_inform);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox text_age;
        private TextBox text_address;
        private TextBox text_name;
        private Label lbl_id;
        private Label lbl_name;
        private Label lnl_address;
        private Label lbl_age;
        private TextBox text_id;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_insert;
        private Button btn_get;
        private Button btn_update;
        private Button btn_delete;
        private Label lbl_inform;
        private Button btn_visual;
        private Button button1;
        private Button btn_image;
    }
}
