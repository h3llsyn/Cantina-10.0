namespace Cantina_10._0_Projeto_Final
{
    public partial class ProdutosP�g4 : Form
    {
        private ProdutosP�g1 produtosP�g1;
        private ProdutosP�g3 produtosP�g3;

        public ProdutosP�g4(ProdutosP�g1 produtosP�g1)
        {
            InitializeComponent();
            this.produtosP�g1 = produtosP�g1;
        }

        public ProdutosP�g4(ProdutosP�g3 produtosP�g3)
        {
            InitializeComponent();
            this.produtosP�g3 = produtosP�g3;
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

        private void ProdutosP�g4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ProdutosP�g3 produtosP�g3 = new ProdutosP�g3(this);
            this.Hide();
            produtosP�g3.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ProdutosP�g1 produtosP�g1 = new ProdutosP�g1(this);
            this.Hide();
            produtosP�g1.ShowDialog();
        }
    }
}
