namespace Cantina_10._0_Projeto_Final
{
    public partial class ProdutosP�g3 : Form
    {
        private ProdutosP�g2 produtosP�g2;
        private ProdutosP�g4 produtosP�g4;

        public ProdutosP�g3(ProdutosP�g2 produtosP�g2)
        {
            InitializeComponent();
            this.produtosP�g2 = produtosP�g2;
        }

        public ProdutosP�g3(ProdutosP�g4 produtosP�g4)
        {
            InitializeComponent();
            this.produtosP�g4 = produtosP�g4;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox7.Visible = true;
            carrinhoListBox.Visible = true;
            finalizarButton.Visible = true;
            excluirItemButton.Visible = true;
            pictureBox5.BringToFront();
            pictureBox7.BringToFront();
            finalizarButton.BringToFront();
            excluirItemButton.BringToFront();
            carrinhoListBox.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox7.Visible = false;
            finalizarButton.Visible = false;
            excluirItemButton.Visible = false;
            carrinhoListBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProdutosP�g3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ProdutosP�g2 produtosP�g2 = new ProdutosP�g2(this);
            this.Hide();
            produtosP�g2.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ProdutosP�g4 produtosP�g4 = new ProdutosP�g4(this);
            this.Hide();
            produtosP�g4.ShowDialog();
        }
    }
}
