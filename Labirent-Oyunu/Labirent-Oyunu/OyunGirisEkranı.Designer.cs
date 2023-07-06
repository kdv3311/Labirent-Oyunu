namespace Labirent_Oyunu
{
    partial class OyunGirisEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunGirisEkranı));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            lbloturumsahibi = new Label();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.FlatAppearance.BorderColor = Color.Brown;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(318, 38);
            button1.Name = "button1";
            button1.Size = new Size(186, 61);
            button1.TabIndex = 0;
            button1.Text = "BAŞLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(300, 482);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 113);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 2;
            label1.Text = "Oturum sahibi :";
            // 
            // lbloturumsahibi
            // 
            lbloturumsahibi.AutoSize = true;
            lbloturumsahibi.Location = new Point(422, 113);
            lbloturumsahibi.Name = "lbloturumsahibi";
            lbloturumsahibi.Size = new Size(38, 15);
            lbloturumsahibi.TabIndex = 3;
            lbloturumsahibi.Text = "label2";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(408, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(82, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Oyun Kuralları";
            linkLabel1.MouseLeave += linkLabel1_MouseLeave;
            linkLabel1.MouseHover += linkLabel1_MouseHover;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ScrollBar;
            listBox1.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(513, 169);
            listBox1.TabIndex = 5;
            // 
            // OyunGirisEkranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(516, 506);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(lbloturumsahibi);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "OyunGirisEkranı";
            Text = "OyunGirisEkranı";
            FormClosed += OyunGirisEkranı_FormClosed;
            Load += OyunGirisEkranı_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label lbloturumsahibi;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
    }
}