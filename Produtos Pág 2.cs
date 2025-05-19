using System.Globalization;

namespace Cantina_10._0_Projeto_Final
{
    public partial class ProdutosPág2 : Form
    {
        private ProdutosPág1 produtosPág1;
        private ProdutosPág3 produtosPág3;

        public ProdutosPág2(ProdutosPág1 produtosPág1)
        {
            InitializeComponent();
            this.produtosPág1 = produtosPág1;
        }

        public ProdutosPág2(ProdutosPág3 produtosPág3)
        {
            InitializeComponent();
            this.produtosPág3 = produtosPág3;
        }
        private void AdicionarAoCarrinho(int index, int quantidade)
        {
            Produtos produto = Produtos.ListaProdutos[index];
            double total = produto.Preço * quantidade;
            carrinhoListBox2.Items.Add($"{produto.Descriçao} - R${total.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))} x{quantidade}");
        }
        public void AtualizarTotal()
        {
            double total = 0;

            foreach (var item in carrinhoListBox2.Items)
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

            preçoTotalCarrinhoLabel.Text = "R$" + total.ToString("F2").Replace('.', ',');
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
            carrinhoListBox2.Visible = true;
            finalizarButton.Visible = true;
            excluirItemButton.Visible = true;
            totalCarrinhoLabel.Visible = true;
            preçoTotalCarrinhoLabel.Visible = true;
            pictureBox5.BringToFront();
            pictureBox7.BringToFront();
            finalizarButton.BringToFront();
            excluirItemButton.BringToFront();
            carrinhoListBox2.BringToFront();
            totalCarrinhoLabel.BringToFront();
            preçoTotalCarrinhoLabel.BringToFront();
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
            carrinhoListBox2.Visible = false;
            totalCarrinhoLabel.Visible = false;
            preçoTotalCarrinhoLabel.Visible = false;
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
            int quantidade = int.Parse(quantidadeSucoLabel.Text);
            quantidade++;
            quantidadeSucoLabel.Text = quantidade.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProdutosPág2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ProdutosPág1 produtosPág1 = new ProdutosPág1(this);
            this.Hide();
            produtosPág1.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ProdutosPág3 produtosPág3 = new ProdutosPág3(this);
            this.Hide();
            produtosPág3.ShowDialog();
        }

        private void menosButtonPastelQueijo_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadePastelQueijoLabel.Text);

            if (quantidade > 1)
            {
                quantidade--;
                quantidadePastelQueijoLabel.Text = quantidade.ToString();
            }
        }

        private void maisButtonPastelQueijo_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadePastelQueijoLabel.Text);
            quantidade++;
            quantidadePastelQueijoLabel.Text = quantidade.ToString();
        }

        private void adicionarPastelQueijo_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadePastelQueijoLabel.Text);
            AdicionarAoCarrinho(3, quantidade);
            AtualizarTotal();
        }

        private void carrinhoListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menosButtonSuco_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeSucoLabel.Text);

            if (quantidade > 1)
            {
                quantidade--;
                quantidadeSucoLabel.Text = quantidade.ToString();
            }
        }

        private void adicionarSuco_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeSucoLabel.Text);
            AdicionarAoCarrinho(4, quantidade);
            AtualizarTotal();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeRefriLabel.Text);

            if (quantidade > 1)
            {
                quantidade--;
                quantidadeRefriLabel.Text = quantidade.ToString();
            }
        }

        private void maisButtonRefri_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeRefriLabel.Text);
            quantidade++;
            quantidadeRefriLabel.Text = quantidade.ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeRefriLabel.Text);
            AdicionarAoCarrinho(5, quantidade);
            AtualizarTotal();
        }

        private void excluirItemButton_Click(object sender, EventArgs e)
        {

        }
    }
}
