namespace Labirent_Oyunu
{
    partial class Kurtarma
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
            kodg = new Button();
            textkurtarma = new TextBox();
            label1 = new Label();
            btnkod = new Button();
            SuspendLayout();
            // 
            // kodg
            // 
            kodg.BackColor = Color.OrangeRed;
            kodg.Location = new Point(66, 144);
            kodg.Name = "kodg";
            kodg.Size = new Size(156, 40);
            kodg.TabIndex = 0;
            kodg.Text = "KODU GÖNDER";
            kodg.UseVisualStyleBackColor = false;
            kodg.Click += button1_Click;
            // 
            // textkurtarma
            // 
            textkurtarma.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textkurtarma.Location = new Point(52, 93);
            textkurtarma.Name = "textkurtarma";
            textkurtarma.PlaceholderText = "E-MAİL GİRİNİZ";
            textkurtarma.Size = new Size(182, 27);
            textkurtarma.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 20);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 2;
            label1.Text = "KURTARMA";
            // 
            // btnkod
            // 
            btnkod.BackColor = Color.LawnGreen;
            btnkod.Location = new Point(94, 190);
            btnkod.Name = "btnkod";
            btnkod.Size = new Size(96, 35);
            btnkod.TabIndex = 3;
            btnkod.Text = "ONAYLA";
            btnkod.UseVisualStyleBackColor = false;
            btnkod.Click += btnkod_Click;
            // 
            // Kurtarma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(284, 261);
            Controls.Add(btnkod);
            Controls.Add(label1);
            Controls.Add(textkurtarma);
            Controls.Add(kodg);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Kurtarma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KurtarmaEkranı";
            FormClosed += Kurtarma_FormClosed;
            Load += Kurtarma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kodg;
        private TextBox textkurtarma;
        private Label label1;
        private Button btnkod;
    }
}