namespace Cantina_10._0_Projeto_Final
{
    partial class Chamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chamada));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            nomeClienteChamada = new Label();
            pictureBox5 = new PictureBox();
            entregarLabel = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-435, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1344, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(95, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(197, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 48);
            label1.Name = "label1";
            label1.Size = new Size(315, 45);
            label1.TabIndex = 88;
            label1.Text = "Chamada De Cliente";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(95, 94);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(600, 350);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 89;
            pictureBox4.TabStop = false;
            // 
            // nomeClienteChamada
            // 
            nomeClienteChamada.AutoSize = true;
            nomeClienteChamada.BackColor = Color.FromArgb(202, 196, 183);
            nomeClienteChamada.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nomeClienteChamada.Location = new Point(348, 228);
            nomeClienteChamada.Name = "nomeClienteChamada";
            nomeClienteChamada.Size = new Size(90, 37);
            nomeClienteChamada.TabIndex = 90;
            nomeClienteChamada.Text = "label2";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(274, 335);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(240, 75);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 91;
            pictureBox5.TabStop = false;
            // 
            // entregarLabel
            // 
            entregarLabel.AutoSize = true;
            entregarLabel.BackColor = Color.FromArgb(124, 122, 106);
            entregarLabel.Cursor = Cursors.Hand;
            entregarLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entregarLabel.ForeColor = Color.White;
            entregarLabel.Location = new Point(300, 356);
            entregarLabel.Name = "entregarLabel";
            entregarLabel.Size = new Size(189, 32);
            entregarLabel.TabIndex = 92;
            entregarLabel.Text = "Entregar pedido";
            entregarLabel.Click += entregarLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(202, 196, 183);
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(290, 125);
            label2.Name = "label2";
            label2.Size = new Size(223, 45);
            label2.TabIndex = 93;
            label2.Text = "Pedido pronto";
            // 
            // Chamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(entregarLabel);
            Controls.Add(pictureBox5);
            Controls.Add(nomeClienteChamada);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Chamada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chamada De Cliente";
            FormClosed += Chamada_FormClosed;
            Load += Chamada_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox4;
        private Label nomeClienteChamada;
        private PictureBox pictureBox5;
        private Label entregarLabel;
        private Label label2;
    }
}