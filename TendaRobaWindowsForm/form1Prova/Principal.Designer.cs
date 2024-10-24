namespace form1Prova
{
    partial class Principal
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "1- producte1 x1000" }, -1, Color.Empty, Color.MistyRose, null);
            ListViewItem listViewItem14 = new ListViewItem("2- Product2 x160");
            ListViewItem listViewItem15 = new ListViewItem("3- Product3 x130");
            ListViewItem listViewItem16 = new ListViewItem("4- Product4 x100");
            ListViewItem listViewItem17 = new ListViewItem("5- Product5 x95");
            ListViewItem listViewItem18 = new ListViewItem("");
            ListViewItem listViewItem19 = new ListViewItem(new string[] { "1- producte1 x1000" }, -1, Color.Empty, Color.Honeydew, null);
            ListViewItem listViewItem20 = new ListViewItem("2- Product2 x160");
            ListViewItem listViewItem21 = new ListViewItem("3- Product3 x130");
            ListViewItem listViewItem22 = new ListViewItem("4- Product4 x100");
            ListViewItem listViewItem23 = new ListViewItem("5- Product5 x95");
            ListViewItem listViewItem24 = new ListViewItem("");
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox4 = new GroupBox();
            button2 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            button6 = new Button();
            textBox2 = new TextBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            label5 = new Label();
            groupBox1 = new GroupBox();
            listView2 = new ListView();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 48);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(420, 11);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 1;
            label1.Text = "BOTIGA ROBA";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(15, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1035, 556);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Font = new Font("Segoe UI", 14F);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1027, 528);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "stock";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button4);
            groupBox4.Location = new Point(773, 146);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(190, 312);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Opcions";
            groupBox4.MouseEnter += groupBox4_MouseEnter;
            groupBox4.MouseLeave += groupBox4_MouseLeave;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(19, 51);
            button2.Name = "button2";
            button2.Size = new Size(149, 36);
            button2.TabIndex = 0;
            button2.Text = "Nou producte";
            toolTip3.SetToolTip(button2, "afageix un nou producte al stock");
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            // 
            // button5
            // 
            button5.BackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.System;
            button5.Location = new Point(19, 245);
            button5.Name = "button5";
            button5.Size = new Size(149, 36);
            button5.TabIndex = 3;
            button5.Text = "Detalls";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            button5.MouseEnter += button5_MouseEnter;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(19, 116);
            button3.Name = "button3";
            button3.Size = new Size(149, 36);
            button3.TabIndex = 1;
            button3.Text = "Afegir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseEnter += button3_MouseEnter;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(19, 181);
            button4.Name = "button4";
            button4.Size = new Size(149, 36);
            button4.TabIndex = 2;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            button4.MouseEnter += button4_MouseEnter;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.lupa1;
            button1.Location = new Point(597, 20);
            button1.Name = "button1";
            button1.Size = new Size(31, 33);
            button1.TabIndex = 3;
            button1.Tag = "";
            toolTip1.SetToolTip(button1, "Cerca");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(556, 32);
            textBox1.TabIndex = 2;
            toolTip2.SetToolTip(textBox1, "introdueix el codi o el nom del producte per cercar-lo");
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(22, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(692, 441);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "codi";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "nom";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "talla";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "color";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "marca";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "preu";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "stock";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1027, 528);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "historial";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.lupa1;
            button6.Location = new Point(735, 21);
            button6.Name = "button6";
            button6.Size = new Size(31, 33);
            button6.TabIndex = 4;
            button6.Tag = "";
            toolTip1.SetToolTip(button6, "Cerca");
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(556, 23);
            textBox2.TabIndex = 3;
            toolTip2.SetToolTip(textBox2, "introdueix el codi o el nom del producte per cercar-lo");
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dataGridView2.Location = new Point(162, 78);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(672, 444);
            dataGridView2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "codi";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "nom";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "talla";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "marca";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.FillWeight = 130F;
            dataGridViewTextBoxColumn6.HeaderText = "data";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.FillWeight = 150F;
            dataGridViewTextBoxColumn7.HeaderText = "motiu";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1027, 528);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "informes";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Snow;
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Location = new Point(527, 36);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(430, 459);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Vendas";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.top_banner_color;
            pictureBox2.Location = new Point(9, 394);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(415, 53);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.top_banner2;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(40, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 379);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MistyRose;
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(275, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 406);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Top Devolucions";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // listView1
            // 
            listView1.BackColor = Color.MistyRose;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Font = new Font("Segoe UI", 14F);
            listView1.GridLines = true;
            listViewItem14.IndentCount = 2;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18 });
            listView1.Location = new Point(17, 67);
            listView1.Name = "listView1";
            listView1.Size = new Size(195, 303);
            listView1.TabIndex = 0;
            listView1.TileSize = new Size(228, 45);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(31, 368);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Honeydew;
            groupBox1.Controls.Add(listView2);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(25, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 406);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Top Ventas";
            // 
            // listView2
            // 
            listView2.BackColor = Color.Honeydew;
            listView2.BorderStyle = BorderStyle.None;
            listView2.Font = new Font("Segoe UI", 14F);
            listView2.GridLines = true;
            listViewItem20.IndentCount = 2;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem19, listViewItem20, listViewItem21, listViewItem22, listViewItem23, listViewItem24 });
            listView2.Location = new Point(13, 67);
            listView2.Name = "listView2";
            listView2.Size = new Size(195, 303);
            listView2.TabIndex = 1;
            listView2.TileSize = new Size(228, 45);
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Tile;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1062, 631);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "gestio tenda";
            TopMost = true;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label5;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ListView listView1;
        private ListView listView2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Button button6;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private GroupBox groupBox4;
        private Button button2;
        private Button button5;
        private Button button3;
        private Button button4;
    }
}
