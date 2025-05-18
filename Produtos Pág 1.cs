using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Cantina_10._0_Projeto_Final
{
    public partial class ProdutosP�g1 : Form
    {
        public List<string> pedido = new List<string>();
        double total = 00.00;
        private ProdutosP�g2 produtosP�g2;
        private ProdutosP�g4 produtosP�g4;

        public ProdutosP�g1()
        {
            InitializeComponent();
        }

        public ProdutosP�g1(ProdutosP�g2 produtosP�g2)
        {
            InitializeComponent();
            this.produtosP�g2 = produtosP�g2;
        }

        public ProdutosP�g1(ProdutosP�g4 produtosP�g4)
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
            carrinhoListBox1.Visible = true;
            finalizarButton.Visible = true;
            excluirItemButton.Visible = true;
            totalCarrinhoLabel.Visible = true;
            pre�oTotalCarrinhoLabel.Visible = true;
            pictureBox5.BringToFront();
            pictureBox7.BringToFront();
            finalizarButton.BringToFront();
            excluirItemButton.BringToFront();
            carrinhoListBox1.BringToFront();
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
            carrinhoListBox1.Visible = false;
            totalCarrinhoLabel.Visible = false;
            pre�oTotalCarrinhoLabel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pre�oTotalCarrinhoLabel.Text = "R$00,00";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ProdutosP�g2 produtosP�g2 = new ProdutosP�g2(this);
            this.Hide();
            produtosP�g2.ShowDialog();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ProdutosP�g4 produtosP�g4 = new ProdutosP�g4(this);
            this.Hide();
            produtosP�g4.ShowDialog();
        }

        private void AdicionarAoCarrinho(int index, int quantidade)
        {
            Produtos produto = Produtos.ListaProdutos[index];
            double total = produto.Pre�o * quantidade;
            carrinhoListBox1.Items.Add($"{produto.Descri�ao} - R${total.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))} x{quantidade}");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadePaoQueijoLabel.Text);
            AdicionarAoCarrinho(0, quantidade);
            AtualizarTotal();
        }

        private void label5_CursorChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_CursorChanged(object sender, EventArgs e)
        {

        }

        private void menosButtonPaodeQueijo_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadePaoQueijoLabel.Text);

            if (quantidade > 1)
            {
                quantidade--;
                quantidadePaoQueijoLabel.Text = quantidade.ToString();
            }
        }

        private void maisButtonPaodeQueijo_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadePaoQueijoLabel.Text);
            quantidade++;
            quantidadePaoQueijoLabel.Text = quantidade.ToString();
        }

        private void totalCarrinhoLabel_Click(object sender, EventArgs e)
        {

        }
        public void AtualizarTotal()
        {
            double total = 0;

            foreach (var item in carrinhoListBox1.Items)
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

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void adicionarCoxinha_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeCoxinhaLabel.Text);
            AdicionarAoCarrinho(1, quantidade);
            AtualizarTotal();
        }

        private void maisButtonCoxinha_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeCoxinhaLabel.Text);
            quantidade++;
            quantidadeCoxinhaLabel.Text = quantidade.ToString();
        }

        private void menosButtonCoxinha_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeCoxinhaLabel.Text);

            if (quantidade > 1)
            {
                quantidade--;
                quantidadeCoxinhaLabel.Text = quantidade.ToString();
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void menosButtonPastelCarne_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadePastelCarneLabel.Text);

            if (quantidade > 1)
            {
                quantidade--;
                quantidadePastelCarneLabel.Text = quantidade.ToString();
            }
        }

        private void maisButtonPastelCarne_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadePastelCarneLabel.Text);
            quantidade++;
            quantidadePastelCarneLabel.Text = quantidade.ToString();
        }

        private void quantidadePastelCarneLabel_Click(object sender, EventArgs e)
        {

        }

        private void quantidadePaoQueijoLabel_Click(object sender, EventArgs e)
        {

        }

        private void adicionarPastelCarne_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadePastelCarneLabel.Text);
            AdicionarAoCarrinho(2, quantidade);
            AtualizarTotal();
        }
    }
}
