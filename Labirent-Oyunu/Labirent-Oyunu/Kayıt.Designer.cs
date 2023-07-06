namespace Labirent_Oyunu
{
    partial class Kayıt
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
            kullanıcıadi = new TextBox();
            txtsifre = new TextBox();
            label1 = new Label();
            button1 = new Button();
            txtsifretekrar = new TextBox();
            txteposta = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // kullanıcıadi
            // 
            kullanıcıadi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kullanıcıadi.Location = new Point(76, 101);
            kullanıcıadi.Name = "kullanıcıadi";
            kullanıcıadi.PlaceholderText = "KULLANICI ADI";
            kullanıcıadi.Size = new Size(233, 29);
            kullanıcıadi.TabIndex = 3;
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsifre.Location = new Point(76, 173);
            txtsifre.Name = "txtsifre";
            txtsifre.PasswordChar = '*';
            txtsifre.PlaceholderText = "ŞİFRE";
            txtsifre.Size = new Size(233, 29);
            txtsifre.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(121, 26);
            label1.Name = "label1";
            label1.Size = new Size(150, 44);
            label1.TabIndex = 5;
            label1.Text = "KAYIT";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Location = new Point(76, 278);
            button1.Name = "button1";
            button1.Size = new Size(233, 43);
            button1.TabIndex = 6;
            button1.Text = "KAYIT OL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtsifretekrar
            // 
            txtsifretekrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtsifretekrar.Location = new Point(76, 208);
            txtsifretekrar.Name = "txtsifretekrar";
            txtsifretekrar.PasswordChar = '*';
            txtsifretekrar.PlaceholderText = "ŞİFRE TEKRAR";
            txtsifretekrar.Size = new Size(233, 29);
            txtsifretekrar.TabIndex = 7;
            txtsifretekrar.TextChanged += txtsifretekrar_TextChanged;
            // 
            // txteposta
            // 
            txteposta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txteposta.Location = new Point(76, 136);
            txteposta.Name = "txteposta";
            txteposta.PlaceholderText = "E-MAİL";
            txteposta.Size = new Size(233, 29);
            txteposta.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 249);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 9;
            // 
            // Kayıt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(384, 361);
            Controls.Add(label2);
            Controls.Add(txteposta);
            Controls.Add(txtsifretekrar);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtsifre);
            Controls.Add(kullanıcıadi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Kayıt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt";
            FormClosed += Kayıt_FormClosed;
            Load += Kayıt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox kullanıcıadi;
        private TextBox txtsifre;
        private Label label1;
        private Button button1;
        private TextBox txtsifretekrar;
        private TextBox txteposta;
        private Label label2;
    }
}