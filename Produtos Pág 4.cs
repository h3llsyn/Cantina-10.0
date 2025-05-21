using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina_10._0_Projeto_Final
{
    public partial class ProdutosPág4 : Form
    {
        private ProdutosPág1 produtosPág1;
        private ProdutosPág3 produtosPág3;

        public ProdutosPág4(ProdutosPág1 produtosPág1)
        {
            InitializeComponent();
            this.produtosPág1 = produtosPág1;
        }

        public ProdutosPág4(ProdutosPág3 produtosPág3)
        {
            InitializeComponent();
            this.produtosPág3 = produtosPág3;
        }
        private void AdicionarAoCarrinho(int index, int quantidade)
        {
            Produtos produto = Produtos.ListaProdutos[index];
            double total = produto.Preço * quantidade;
            Produtos produtos = Produtos.ListaProdutos[index];
            Carrinho.Itens.Add((produto, quantidade));
            carrinhoListBox4.Items.Add($"{produto.Descriçao} - R${total.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))} x{quantidade}");
        }
        public void AtualizarTotal()
        {
            double total = 0;

            foreach (var item in carrinhoListBox4.Items)
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
            carrinhoListBox4.Visible = false;
            totalCarrinhoLabel.Visible = false;
            preçoTotalCarrinhoLabel.Visible = false;
            comboBox1.Visible = false;
            label9.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarCarrinho();
            AtualizarTotal();
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

        private void ProdutosPág4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ProdutosPág3 produtosPág3 = new ProdutosPág3(this);
            this.Hide();
            produtosPág3.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ProdutosPág1 produtosPág1 = new ProdutosPág1(this);
            this.Hide();
            produtosPág1.ShowDialog();
        }

        private void menosButtonAgua_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeAguaLabel.Text);

            if (quantidade > 1)
            {
                quantidade--;
                quantidadeAguaLabel.Text = quantidade.ToString();
            }
        }

        private void maisButtonAgua_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeAguaLabel.Text);
            quantidade++;
            quantidadeAguaLabel.Text = quantidade.ToString();
        }

        private void adicionarAgua_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(quantidadeAguaLabel.Text);
            AdicionarAoCarrinho(9, quantidade);
            AtualizarTotal();
            quantidadeAguaLabel.Text = "1";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox7.Visible = true;
            carrinhoListBox4.Visible = true;
            finalizarButton.Visible = true;
            excluirItemButton.Visible = true;
            totalCarrinhoLabel.Visible = true;
            preçoTotalCarrinhoLabel.Visible = true;
            comboBox1.Visible = true;
            label9.Visible = true;
            pictureBox5.BringToFront();
            pictureBox7.BringToFront();
            finalizarButton.BringToFront();
            excluirItemButton.BringToFront();
            carrinhoListBox4.BringToFront();
            totalCarrinhoLabel.BringToFront();
            preçoTotalCarrinhoLabel.BringToFront();
            comboBox1.BringToFront();
            label9.BringToFront();
        }
        private void AtualizarCarrinho()
        {
            carrinhoListBox4.Items.Clear();

            foreach (var item in Carrinho.Itens)
            {
                double total = item.produto.Preço * item.quantidade;
                carrinhoListBox4.Items.Add($"{item.produto.Descriçao} - R${total.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))} x{item.quantidade}");
            }
        }

        private void excluirItemButton_Click(object sender, EventArgs e)
        {
            if (carrinhoListBox4.SelectedIndex != -1)
            {
                carrinhoListBox4.Items.Remove(carrinhoListBox4.SelectedItem);
                AtualizarTotal();
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover", "Erro");
            }
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                MessageBox.Show($"\n Agradecemos pela sua compra _Nome de Usuário_! \n O seu pedido está sendo preparado, por favor aguarde no balcão.", "Pedido Finalizado");
            }
            else
            {
                MessageBox.Show("Adicione uma forma de pagamento", "Erro");
            }
        }
    }
}
