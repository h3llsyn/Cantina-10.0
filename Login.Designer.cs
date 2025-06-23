namespace Cantina_10._0_Projeto_Final
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            digiteLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-435, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1344, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 77;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(95, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(197, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 78;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(147, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(500, 420);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 79;
            pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(124, 122, 106);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(254, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 23);
            textBox1.TabIndex = 80;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(124, 122, 106);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(254, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(287, 23);
            textBox2.TabIndex = 81;
            // 
            // digiteLabel
            // 
            digiteLabel.AutoSize = true;
            digiteLabel.BackColor = Color.FromArgb(124, 122, 106);
            digiteLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digiteLabel.Location = new Point(257, 215);
            digiteLabel.Name = "digiteLabel";
            digiteLabel.Size = new Size(194, 21);
            digiteLabel.TabIndex = 82;
            digiteLabel.Text = "Digite o nome de usuário";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(800, 450);
            Controls.Add(digiteLabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Login_FormClosed;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label digiteLabel;
    }
}