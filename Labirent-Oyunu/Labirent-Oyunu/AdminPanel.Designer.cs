namespace Labirent_Oyunu
{
    partial class AdminPanel
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnsil = new DataGridViewButtonColumn();
            İbtnincele = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            txtkullanıcı = new TextBox();
            txteposta = new TextBox();
            button1 = new Button();
            BTNGUNCELLE = new Button();
            txtsifre = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            checkBox1 = new CheckBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 501);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "OYUNCULAR";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnsil, İbtnincele });
            dataGridView1.Location = new Point(18, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(401, 453);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnsil
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            btnsil.DefaultCellStyle = dataGridViewCellStyle1;
            btnsil.HeaderText = "SİL";
            btnsil.Name = "btnsil";
            btnsil.ReadOnly = true;
            btnsil.Text = "SİL";
            btnsil.ToolTipText = "SİL";
            btnsil.UseColumnTextForButtonValue = true;
            // 
            // İbtnincele
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Gray;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Red;
            İbtnincele.DefaultCellStyle = dataGridViewCellStyle2;
            İbtnincele.HeaderText = "İNCELE";
            İbtnincele.Name = "İbtnincele";
            İbtnincele.ReadOnly = true;
            İbtnincele.Text = "İNCELE";
            İbtnincele.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(460, 24);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(474, 53);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "E-mail :";
            // 
            // txtkullanıcı
            // 
            txtkullanıcı.Location = new Point(544, 25);
            txtkullanıcı.Name = "txtkullanıcı";
            txtkullanıcı.Size = new Size(234, 23);
            txtkullanıcı.TabIndex = 4;
            // 
            // txteposta
            // 
            txteposta.Location = new Point(544, 54);
            txteposta.Name = "txteposta";
            txteposta.Size = new Size(234, 23);
            txteposta.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Location = new Point(12, 519);
            button1.Name = "button1";
            button1.Size = new Size(166, 62);
            button1.TabIndex = 6;
            button1.Text = "OYUNU OYNA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BTNGUNCELLE
            // 
            BTNGUNCELLE.BackColor = Color.DarkSalmon;
            BTNGUNCELLE.Location = new Point(809, 25);
            BTNGUNCELLE.Name = "BTNGUNCELLE";
            BTNGUNCELLE.Size = new Size(144, 46);
            BTNGUNCELLE.TabIndex = 8;
            BTNGUNCELLE.Text = "GÜNCELLE";
            BTNGUNCELLE.UseVisualStyleBackColor = false;
            BTNGUNCELLE.Click += BTNGUNCELLE_Click;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(544, 83);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(234, 23);
            txtsifre.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(489, 82);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 10;
            label3.Text = "Şifre :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(474, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 350);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "KULLANICININ OYUN GEÇMİŞİ";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(15, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(458, 302);
            dataGridView2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(473, 115);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 13;
            label4.Text = "ERİŞİM :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(544, 118);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "ADMİNLİK YETKİSİ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.Location = new Point(809, 103);
            button2.Name = "button2";
            button2.Size = new Size(144, 46);
            button2.TabIndex = 15;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(975, 593);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(txtsifre);
            Controls.Add(BTNGUNCELLE);
            Controls.Add(button1);
            Controls.Add(txteposta);
            Controls.Add(txtkullanıcı);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetim";
            FormClosed += Yönetim_FormClosed;
            Load += Yönetim_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtkullanıcı;
        private TextBox txteposta;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn btnsil;
        private DataGridViewButtonColumn İbtnincele;
        private Button button1;
        private Button BTNGUNCELLE;
        private TextBox txtsifre;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Label label4;
        private CheckBox checkBox1;
        private Button button2;
    }
}