using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina_10._0_Projeto_Final
{
    public partial class ProdutosP�g4 : Form
    {
        private ProdutosP�g1 produtosP�g1;
        private ProdutosP�g3 produtosP�g3;
        private Balc�o balc�o;
        private Cozinha cozinha;
        private Tela_Chamada tela_chamada;
        private Estoque estoque;
        private Gest�o_de_Produtos gest�o_De_Produtos;

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

        public ProdutosP�g4(Balc�o balc�o)
        {
            InitializeComponent();
            this.balc�o = balc�o;
        }

        public ProdutosP�g4(Cozinha cozinha)
        {
            InitializeComponent();
            this.cozinha = cozinha;
        }
        public ProdutosP�g4(Tela_Chamada tela_chamada)
        {
            InitializeComponent();
            this.tela_chamada = tela_chamada;
        }

        public ProdutosP�g4(Estoque estoque)
        {
            InitializeComponent();
            this.estoque = estoque;
        }

        public ProdutosP�g4(Gest�o_de_Produtos gest�o_De_Produtos)
        {
            InitializeComponent();
            this.gest�o_De_Produtos = gest�o_De_Produtos;
        }

        private void AdicionarAoCarrinho(int index, int quantidade)
        {
            Produtos produto = Produtos.ListaProdutos[index];
            if (produto.Estoque >= quantidade)
            {
                double total = produto.Pre�o * quantidade;
                Carrinho.Itens.Add((produto, quantidade));
                carrinhoListBox4.Items.Add($"{produto.Descri�ao} - R${total.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))} x{quantidade}");
                extratoListBox.Items.Add($"{produto.Descri�ao} - R${total.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))} x{quantidade}");
                produto.Estoque -= quantidade;
            }
            else
            {
                MessageBox.Show($"Estoque insuficiente para {produto.Descri�ao}.\nDispon�vel: {produto.Estoque}", "Erro");
            }
        }

        public void AtualizarTotal()
        {
            double total = 0;

            foreach (var item in Carrinho.Itens)
            {
                total += item.produto.Pre�o * item.quantidade;
            }

            pre�oTotalCarrinhoLabel.Text = "R$" + total.ToString("F2").Replace('.', ',');
            precoPagarLabel.Text = "R$" + total.ToString("F2").Replace('.', ',');
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
            pre�oTotalCarrinhoLabel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pre�oTotalCarrinhoLabel.Text = "R$00,00";
            precoPagarLabel.Text = "R$00,00";
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
            var produto = Produtos.ListaProdutos[9];
            if (produto.Estoque >= quantidade)
            {
                AdicionarAoCarrinho(9, quantidade);
                AtualizarTotal();
                quantidadeAguaLabel.Text = "1";
                if (quantidade == 1)
                {
                    MessageBox.Show($"x{quantidade} �gua mineral adicionada ao carrinho", "Confirma��o");
                }
                else
                {
                    MessageBox.Show($"x{quantidade} �guas minerais adicionadas ao carrinho", "Confirma��o");
                }
            }
            else
            {
                MessageBox.Show($"Estoque insuficiente para {produto.Descri�ao}.\nDispon�vel: {produto.Estoque}", "Erro");
                quantidadeAguaLabel.Text = "1";
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox7.Visible = true;
            carrinhoListBox4.Visible = true;
            finalizarButton.Visible = true;
            excluirItemButton.Visible = true;
            totalCarrinhoLabel.Visible = true;
            pre�oTotalCarrinhoLabel.Visible = true;
            pictureBox5.BringToFront();
            pictureBox7.BringToFront();
            finalizarButton.BringToFront();
            excluirItemButton.BringToFront();
            carrinhoListBox4.BringToFront();
            totalCarrinhoLabel.BringToFront();
            pre�oTotalCarrinhoLabel.BringToFront();
        }
        private void AtualizarCarrinho()
        {
            carrinhoListBox4.Items.Clear();
            extratoListBox.Items.Clear();

            foreach (var item in Carrinho.Itens)
            {
                double total = item.produto.Pre�o * item.quantidade;
                carrinhoListBox4.Items.Add($"{item.produto.Descri�ao} - R${total.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))} x{item.quantidade}");
                extratoListBox.Items.Add($"{item.produto.Descri�ao} - R${total.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))} x{item.quantidade}");
            }
        }

        private void excluirItemButton_Click(object sender, EventArgs e)
        {
            if (carrinhoListBox4.SelectedIndex != -1)
            {
                Carrinho.Itens.RemoveAt(carrinhoListBox4.SelectedIndex);
                AtualizarCarrinho();
                AtualizarTotal();
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover", "Erro");
            }
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            if (Carrinho.Itens.Count == 0)
            {
                MessageBox.Show("Carrinho vazio", "Erro");
            }
            else
            {
                fundoPagamentoPictureBox.Visible = true;
                formasPagamentoLabel.Visible = true;
                extratoListBox.Visible = true;
                totalLabell.Visible = true;
                precoPagarLabel.Visible = true;
                comboBox1.Visible = true;
                voltarPicture.Visible = true;
                voltarLabel.Visible = true;
                pagarAgoraPicture.Visible = true;
                pagarAgoraLabel.Visible = true;
                formasLabel.Visible = true;
                nomeTextBox.Visible = true;
                nomeLabel.Visible = true;
                viagemCheckBox.Visible = true;
                fundoPagamentoPictureBox.BringToFront();
                formasPagamentoLabel.BringToFront();
                extratoListBox.BringToFront();
                totalLabell.BringToFront();
                precoPagarLabel.BringToFront();
                comboBox1.BringToFront();
                voltarPicture.BringToFront();
                voltarLabel.BringToFront();
                pagarAgoraPicture.BringToFront();
                pagarAgoraLabel.BringToFront();
                formasLabel.BringToFront();
                nomeLabel.BringToFront();
                nomeTextBox.BringToFront();
                viagemCheckBox.BringToFront();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                valorLabel.Visible = true;
                textBox1.Visible = true;
                trocoLabel.Visible = true;
                trocoTextBox.Visible = true;
                valorLabel.BringToFront();
                textBox1.BringToFront();
                trocoLabel.BringToFront();
                trocoTextBox.BringToFront();
            }
            else
            {
                valorLabel.Visible = false;
                textBox1.Visible = false;
                trocoLabel.Visible = false;
                trocoTextBox.Visible = false;
            }
        }

        private void voltarLabel_Click(object sender, EventArgs e)
        {
            PagPagamentoInvisivel();
        }

        private void voltarPicture_Click(object sender, EventArgs e)
        {
            PagPagamentoInvisivel();
        }

        private void precoPagarLabel_Click(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void pagarAgoraLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomeTextBox.Text))
            {
                MessageBox.Show("Por favor digite seu nome", "Erro");
                return;
            }
            else if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor adicione uma forma de pagamento", "Erro");
                return;
            }

            string formaPagamento = comboBox1.SelectedItem.ToString();
            string totalStr = precoPagarLabel.Text.Replace("R$", "").Trim().Replace(',', '.');
            double total = double.Parse(totalStr, System.Globalization.CultureInfo.InvariantCulture);
            if (formaPagamento == "Dinheiro")
            {
                if (!double.TryParse(textBox1.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double valorPago))
                {
                    MessageBox.Show("Por favor digite um valor v�lido", "Erro");
                    return;
                }

                if (valorPago < total)
                {
                    MessageBox.Show("Valor pago insuficiente", "Erro");
                    return;
                }

                else if (viagemCheckBox.Checked && valorPago >= total)
                {
                    string carrinho = string.Join("\n", Carrinho.Itens.Select(item => $"   - {item.produto.Descri�ao} | R${(item.produto.Pre�o * item.quantidade):F2} x{item.quantidade}"));
                    string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    AtualizarBalcao();

                    MessageBox.Show(
                        $"Data: {dataHora}\n" +
                        "----------------------------------------------------------------\n" +
                        $"                 Extrato          \n" +
                        "----------------------------------------------------------------\n" +
                        $"{carrinho}\n" +
                        "----------------------------------------------------------------\n" +
                        $"Pedido para viagem\n" +
                        "----------------------------------------------------------------\n" +
                        $"Agradecemos pelo pedido, {nomeTextBox.Text}!\n" +
                        "Por favor aguarde o seu pedido no balc�o.",
                        "Pedido Finalizado"
                        );
                    Carrinho.Itens.Clear();
                    AtualizarCarrinho();
                    AtualizarTotal();
                    nomeTextBox.Text = "";
                    comboBox1.SelectedIndex = -1;
                    textBox1.Text = "";
                    trocoTextBox.Text = "";
                    PagPagamentoInvisivel();
                }

                else if (valorPago >= total)
                {
                    PedidoFinalizado();
                    PagPagamentoInvisivel();
                }
            }

            else if (viagemCheckBox.Checked)
            {
                string carrinho = string.Join("\n", Carrinho.Itens.Select(item => $"   - {item.produto.Descri�ao} | R${(item.produto.Pre�o * item.quantidade):F2} x{item.quantidade}"));
                string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                AtualizarBalcao();

                MessageBox.Show(
                    $"Data: {dataHora}\n" +
                    "----------------------------------------------------------------\n" +
                    $"                 Extrato          \n" +
                    "----------------------------------------------------------------\n" +
                    $"{carrinho}\n" +
                    "----------------------------------------------------------------\n" +
                    $"Pedido para viagem\n" +
                    "----------------------------------------------------------------\n" +
                    $"Agradecemos pelo pedido, {nomeTextBox.Text}!\n" +
                    "Por favor aguarde o seu pedido no balc�o.",
                    "Pedido Finalizado"
                );
                Carrinho.Itens.Clear();
                AtualizarCarrinho();
                AtualizarTotal();
                nomeTextBox.Text = "";
                comboBox1.SelectedIndex = -1;
                textBox1.Text = "";
                trocoTextBox.Text = "";
                PagPagamentoInvisivel();
            }
            else
            {
                PedidoFinalizado();
                PagPagamentoInvisivel();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double valorPago))
            {
                string totalStr = precoPagarLabel.Text.Replace("R$", "").Trim().Replace(',', '.');
                double total = double.Parse(totalStr, System.Globalization.CultureInfo.InvariantCulture);

                if (valorPago >= total)
                {
                    double troco = valorPago - total;
                    trocoTextBox.Text = troco.ToString("F2").Replace('.', ',');
                }
                else
                {
                    trocoTextBox.Text = "";
                }
            }
            else
            {
                trocoTextBox.Text = "";
            }
        }
        public void PedidoFinalizado()
        {
            string carrinho = string.Join("\n", Carrinho.Itens.Select(item => $"   - {item.produto.Descri�ao} | R${(item.produto.Pre�o * item.quantidade):F2} x{item.quantidade}"));
            string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            AtualizarBalcao();

            MessageBox.Show(
                $"Data: {dataHora}\n" +
                "------------------------------\n" +
                $"\n               Extrato          \n" +
                "------------------------------\n" +
                $"{carrinho}\n" +
                "------------------------------\n" +
                $"Agradecemos pelo pedido, {nomeTextBox.Text}!\n" +
                "Por favor aguarde o seu pedido no balc�o.",
                "Pedido Finalizado"
            );
            Carrinho.Itens.Clear();
            AtualizarCarrinho();
            AtualizarTotal();
            nomeTextBox.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
            trocoTextBox.Text = "";
            PagPagamentoInvisivel();
        }

        public void PagPagamentoInvisivel()
        {

            viagemCheckBox.Checked = false;
            fundoPagamentoPictureBox.Visible = false;
            formasPagamentoLabel.Visible = false;
            extratoListBox.Visible = false;
            totalLabell.Visible = false;
            precoPagarLabel.Visible = false;
            formasLabel.Visible = false;
            viagemCheckBox.Visible = false;
            nomeLabel.Visible = false;
            comboBox1.Visible = false;
            nomeTextBox.Visible = false;
            valorLabel.Visible = false;
            textBox1.Visible = false;
            trocoLabel.Visible = false;
            trocoTextBox.Visible = false;
            voltarLabel.Visible = false;
            voltarPicture.Visible = false;
            pagarAgoraLabel.Visible = false;
            pagarAgoraPicture.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (menuOpcoes.Visible)
            {
                menuOpcoes.Visible = false;
                produtosLabel.Visible = false;
                linha1.Visible = false;
                balcaoLabel.Visible = false;
                linha2.Visible = false;
                cozinhaLabel.Visible = false;
                linha3.Visible = false;
                label9.Visible = false;
                linha4.Visible = false;
                estoqueLabel.Visible = false;
                linha5.Visible = false;
                gest�oDeProdutosLabel.Visible = false;
            }
            else
            {
                menuOpcoes.Visible = true;
                produtosLabel.Visible = true;
                linha1.Visible = true;
                balcaoLabel.Visible = true;
                linha2.Visible = true;
                cozinhaLabel.Visible = true;
                linha3.Visible = true;
                label9.Visible = true;
                linha4.Visible = true;
                estoqueLabel.Visible = true;
                linha5.Visible = true;
                gest�oDeProdutosLabel.Visible = true;

                menuOpcoes.BringToFront();
                linha1.BringToFront();
                linha2.BringToFront();
                linha3.BringToFront();
                linha4.BringToFront();
                linha5.BringToFront();
                produtosLabel.BringToFront();
                balcaoLabel.BringToFront();
                cozinhaLabel.BringToFront();
                label9.BringToFront();
                estoqueLabel.BringToFront();
                gest�oDeProdutosLabel.BringToFront();
            }
        }

        private void produtosLabel_Click(object sender, EventArgs e)
        {
            menuOpcoes.Visible = false;
            produtosLabel.Visible = false;
            linha1.Visible = false;
            balcaoLabel.Visible = false;
            linha2.Visible = false;
            cozinhaLabel.Visible = false;
            linha3.Visible = false;
            label9.Visible = false;
            linha4.Visible = false;
            estoqueLabel.Visible = false;
            linha5.Visible = false;
            gest�oDeProdutosLabel.Visible = false;
        }

        private void balcaoLabel_Click(object sender, EventArgs e)
        {
            Balc�o balc�o = new Balc�o(this);
            this.Hide();
            balc�o.ShowDialog();
        }

        public void AtualizarBalcao()
        {
            var produtosNaoChapa = Carrinho.Itens.Where(p => !p.produto.Chapa).ToList();
            if (produtosNaoChapa.Any())
            {
                var pedidoNaoChapa = new Pedidos(nomeTextBox.Text, comboBox1.SelectedItem.ToString(), viagemCheckBox.Checked, produtosNaoChapa);
                PedidosPersistencia.pedidosNaoChapa.Add(pedidoNaoChapa);
            }

            var produtosDeChapa = Carrinho.Itens.Where(p => p.produto.Chapa).ToList();
            if (produtosDeChapa.Any())
            {
                var pedidoDeChapa = new Pedidos(nomeTextBox.Text, comboBox1.SelectedItem.ToString(), viagemCheckBox.Checked, produtosDeChapa);
                PedidosPersistencia.pedidosDeChapa.Add(pedidoDeChapa);
            }
        }

        private void cozinhaLabel_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha(this);
            this.Hide();
            cozinha.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Tela_Chamada tela_Chamada = new Tela_Chamada(this);
            this.Hide();
            tela_Chamada.ShowDialog();
        }

        private void estoqueLabel_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque(this);
            this.Hide();
            estoque.ShowDialog();
        }

        private void gest�oDeProdutosLabel_Click(object sender, EventArgs e)
        {
            Gest�o_de_Produtos gest�o_De_Produtos = new Gest�o_de_Produtos(this);
            this.Hide();
            gest�o_De_Produtos.ShowDialog();
        }

        private void menuOpcoes_Click(object sender, EventArgs e)
        {

        }
    }
}
