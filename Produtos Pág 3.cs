using System.Globalization;

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
        private void AdicionarAoCarrinho(int index, int quantidade)
        {
            Produtos produto = Produtos.ListaProdutos[index];
            double total = produto.Pre�o * quantidade;
            carrinhoListBox3.Items.Add($"{produto.Descri�ao} - R${total.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))} x{quantidade}");
        }
        public void AtualizarTotal()
        {
            double total = 0;

            foreach (var item in carrinhoListBox3.Items)
            {
                string texto = item.ToString();

                int indiceX = texto.LastIndexOf('x');
                if (indiceX == -1) continue;

                if (!int.TryParse(texto.Substring(indiceX + 1).Trim(), out int quantidade))
                    quantidade = 1;

                int indiceR = texto.IndexOf("R$");
                if (indiceR == -1) continue;

                string precoStr = texto.Substring(indiceR + 2, indiceX - (indiceR + 2)).Trim();
                precoStr = precoStr.Replace(',', '.');

                if (double.TryParse(precoStr, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double preco))
                {
                    total += preco;
                }
            }

            pre�oTotalCarrinhoLabel.Text = "R$" + total.ToString("F2").Replace('.', ',');
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
            carrinhoListBox3.Visible = true;
            finalizarButton.Visible = true;
            excluirItemButton.Visible = true;
            totalCarrinhoLabel.Visible = true;
            pre�oTotalCarrinhoLabel.Visible = true;
            pictureBox5.BringToFront();
            pictureBox7.BringToFront();
            finalizarButton.BringToFront();
            excluirItemButton.BringToFront();
            carrinhoListBox3.BringToFront();
            totalCarrinhoLabel.BringToFront();
            pre�oTotalCarrinhoLabel.BringToFront();
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
            carrinhoListBox3.Visible = false;
            totalCarrinhoLabel.Visible = false;
            pre�oTotalCarrinhoLabel.Visible = false;
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
            int quantidade = int.Parse(quantidadeHamburguerQueijoLabel.Text);
            quantidade++;
            quantidadeHamburguerQueijoLabel.Text = quantidade.ToString();
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

        private void menosButtonHamburguerSimp_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeHamburguerSimpLabel.Text);

            if (quantidade > 1)
            {
                quantidade--;
                quantidadeHamburguerSimpLabel.Text = quantidade.ToString();
            }
        }

        private void maisButtonHamburguerSimp_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeHamburguerSimpLabel.Text);
            quantidade++;
            quantidadeHamburguerSimpLabel.Text = quantidade.ToString();
        }

        private void adicionarHamburguerSimp_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeHamburguerSimpLabel.Text);
            AdicionarAoCarrinho(6, quantidade);
            AtualizarTotal();
        }

        private void menosButtonHamburguerQueijo_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeHamburguerQueijoLabel.Text);

            if (quantidade > 1)
            {
                quantidade--;
                quantidadeHamburguerQueijoLabel.Text = quantidade.ToString();
            }
        }

        private void adicionarHamburguerQueijo_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeHamburguerQueijoLabel.Text);
            AdicionarAoCarrinho(7, quantidade);
            AtualizarTotal();
        }

        private void maisButtonXTudo_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeXTudoLabel.Text);
            quantidade++;
            quantidadeXTudoLabel.Text = quantidade.ToString();
        }

        private void menosButtonXTudo_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeXTudoLabel.Text);

            if (quantidade > 1)
            {
                quantidade--;
                quantidadeXTudoLabel.Text = quantidade.ToString();
            }
        }

        private void adicionarXTudo_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeXTudoLabel.Text);
            AdicionarAoCarrinho(8, quantidade);
            AtualizarTotal();
        }
    }
}
