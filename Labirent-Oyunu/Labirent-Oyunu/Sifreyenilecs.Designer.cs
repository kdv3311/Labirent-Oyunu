namespace Labirent_Oyunu
{
    partial class Sifreyenilecs
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
            txtsifre = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(47, 99);
            txtsifre.Name = "txtsifre";
            txtsifre.PlaceholderText = "YENİ ŞİFRE";
            txtsifre.Size = new Size(186, 23);
            txtsifre.TabIndex = 0;
            txtsifre.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(71, 155);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 2;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(71, 38);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 3;
            label1.Text = "YENİ ŞİFRE";
            // 
            // Sifreyenilecs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(284, 261);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtsifre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Sifreyenilecs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sifreyenilecs";
            FormClosed += Sifreyenilecs_FormClosed;
            Load += Sifreyenilecs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsifre;
        private Button button1;
        private Label label1;
    }
}