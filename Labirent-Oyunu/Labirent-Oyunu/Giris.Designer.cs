namespace Labirent_Oyunu
{
    partial class Giris
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            kullanıcıadi = new TextBox();
            txtsifre = new TextBox();
            label1 = new Label();
            linkLabel2 = new LinkLabel();
            checkBox1 = new CheckBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Location = new Point(142, 313);
            button1.Name = "button1";
            button1.Size = new Size(233, 43);
            button1.TabIndex = 0;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(142, 234);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 17);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            linkLabel1.VisitedLinkColor = Color.Cyan;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // kullanıcıadi
            // 
            kullanıcıadi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kullanıcıadi.Location = new Point(142, 130);
            kullanıcıadi.Name = "kullanıcıadi";
            kullanıcıadi.PlaceholderText = "KULLANICI ADI";
            kullanıcıadi.Size = new Size(233, 29);
            kullanıcıadi.TabIndex = 2;
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsifre.Location = new Point(142, 186);
            txtsifre.Name = "txtsifre";
            txtsifre.PlaceholderText = "PAROLA";
            txtsifre.Size = new Size(233, 29);
            txtsifre.TabIndex = 3;
            txtsifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(199, 64);
            label1.Name = "label1";
            label1.Size = new Size(121, 44);
            label1.TabIndex = 4;
            label1.Text = "GİRİŞ";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(317, 234);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(58, 17);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Kayıt Ol";
            linkLabel2.VisitedLinkColor = Color.Cyan;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(142, 276);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(508, 450);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel2);
            Controls.Add(label1);
            Controls.Add(txtsifre);
            Controls.Add(kullanıcıadi);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            FormClosed += Giris_FormClosed;
            Load += Giris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private LinkLabel linkLabel1;
        private TextBox kullanıcıadi;
        private TextBox txtsifre;
        private Label label1;
        private LinkLabel linkLabel2;
        private CheckBox checkBox1;
        private ContextMenuStrip contextMenuStrip1;


    }
}