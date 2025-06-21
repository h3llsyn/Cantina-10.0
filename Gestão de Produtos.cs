using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_10._0_Projeto_Final
{
    public partial class Gestão_de_Produtos : Form
    {
        private ProdutosPág1 produtosPág1;
        private ProdutosPág2 produtosPág2;
        private ProdutosPág3 produtosPág3;
        private ProdutosPág4 produtosPág4;
        private Balcão balcão;
        private Cozinha cozinha;
        private Tela_Chamada tela_chamada;
        private Estoque estoque;
        private Estoque_Pág_2 estoque_Pág_2;

        public Gestão_de_Produtos(ProdutosPág1 produtosPág1)
        {
            InitializeComponent();
            this.produtosPág1 = produtosPág1;
        }

        public Gestão_de_Produtos(ProdutosPág2 produtosPág2)
        {
            InitializeComponent();
            this.produtosPág2 = produtosPág2;
        }
        public Gestão_de_Produtos(ProdutosPág3 produtosPág3)
        {
            InitializeComponent();
            this.produtosPág3 = produtosPág3;
        }

        public Gestão_de_Produtos(ProdutosPág4 produtosPág4)
        {
            InitializeComponent();
            this.produtosPág4 = produtosPág4;
        }

        public Gestão_de_Produtos(Balcão balcão)
        {
            InitializeComponent();
            this.balcão = balcão;
        }

        public Gestão_de_Produtos(Cozinha cozinha)
        {
            InitializeComponent();
            this.cozinha = cozinha;
        }

        public Gestão_de_Produtos(Estoque estoque)
        {
            InitializeComponent();
            this.estoque = estoque;
        }

        public Gestão_de_Produtos(Estoque_Pág_2 estoque_Pág_2)
        {
            InitializeComponent();
            this.estoque_Pág_2 = estoque_Pág_2;
        }

        public Gestão_de_Produtos()
        {
            InitializeComponent();
            estoqueProdutoNumericUpDown.Maximum = decimal.MaxValue;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void Gestão_de_Produtos_Load(object sender, EventArgs e)
        {
            AtualizarListBox();
        }

        public void AtualizarListBox()
        {
            listBox1.Items.Clear();
            foreach (var produto in Produtos.ListaProdutos)
            {
                listBox1.Items.Add(produto);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produtoSelecionado = listBox1.SelectedItem as Produtos;
            if (produtoSelecionado != null)
            {
                nomeProdutoTextBox.Text = produtoSelecionado.Descriçao;
                precoProdutoTextBox.Text = produtoSelecionado.Preço.ToString("F2");
                éChapaCheckBox.Checked = produtoSelecionado.Chapa;
                estoqueProdutoNumericUpDown.Value = produtoSelecionado.Estoque;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string descricao = nomeProdutoTextBox.Text.Trim();
            string precoTexto = precoProdutoTextBox.Text.Trim();
            bool chapa = éChapaCheckBox.Checked;
            int estoque = (int)estoqueProdutoNumericUpDown.Value;
            decimal preco;

            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor digite uma descrição válida", "Erro");
                return;
            }

            if (!decimal.TryParse(precoTexto, out preco))
            {
                MessageBox.Show("Por favor digite um preço válido", "Erro");
                return;
            }

            bool produtoJaExiste = Produtos.ListaProdutos.Any(p => p.Descriçao.Equals(descricao, StringComparison.OrdinalIgnoreCase) && Math.Abs((decimal)p.Preço - preco) < 0.01m);

            if (produtoJaExiste)
            {
                MessageBox.Show("Esse produto já existe", "Erro");
                return;
            }

            Produtos novoProduto = new Produtos(descricao, (double)preco, chapa, estoque);
            Produtos.ListaProdutos.Add(novoProduto);

            AtualizarListBox();
            MessageBox.Show("Novo produto adicionado com sucesso!", "Confirmação");

            nomeProdutoTextBox.Clear();
            precoProdutoTextBox.Clear();
            éChapaCheckBox.Checked = false;
            estoqueProdutoNumericUpDown.Value = 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            var produtoSelecionado = listBox1.SelectedItem as Produtos;
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Por favor selecione um produto para editar", "Erro");
                return;
            }

            string novaDescricao = nomeProdutoTextBox.Text.Trim();
            string precoTexto = precoProdutoTextBox.Text.Trim();
            bool novaChapa = éChapaCheckBox.Checked;
            int novoEstoque = (int)estoqueProdutoNumericUpDown.Value;
            decimal novoPreco;

            if (string.IsNullOrWhiteSpace(novaDescricao))
            {
                MessageBox.Show("Por favor digite uma descriçao válida", "Erro");
                return;
            }

            else if (!decimal.TryParse(precoTexto, out novoPreco))
            {
                MessageBox.Show("Por favor digite um preço válido", "Erro");
                return;
            }

            bool mudou = produtoSelecionado.Descriçao != novaDescricao || produtoSelecionado.Preço != (double)novoPreco || produtoSelecionado.Chapa != novaChapa || produtoSelecionado.Estoque != novoEstoque;

            if (!mudou)
            {
                MessageBox.Show("Nenhuma alteração feita", "Atenção");
                return;
            }

            bool produtoJaExiste = Produtos.ListaProdutos.Any(p => p != produtoSelecionado && p.Descriçao.Equals(novaDescricao, StringComparison.OrdinalIgnoreCase) && Math.Abs((decimal)p.Preço - novoPreco) < 0.01m && p.Chapa == novaChapa && p.Estoque == novoEstoque);

            if (produtoJaExiste)
            {
                MessageBox.Show("Esse produto já existe", "Erro");
                return;
            }

            produtoSelecionado.Descriçao = novaDescricao;
            produtoSelecionado.Preço = (double)novoPreco;
            produtoSelecionado.Chapa = novaChapa;
            produtoSelecionado.Estoque = novoEstoque;

            AtualizarListBox();

            MessageBox.Show("Produto atualizado com sucesso!", "Confirmação");
            nomeProdutoTextBox.Clear();
            precoProdutoTextBox.Clear();
            éChapaCheckBox.Checked = false;
            estoqueProdutoNumericUpDown.Value = 0;
        }

        private void historicoButton_Click(object sender, EventArgs e)
        {
            nomeProdutoTextBox.Clear();
            precoProdutoTextBox.Clear();
            éChapaCheckBox.Checked = false;
            estoqueProdutoNumericUpDown.Value = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            nomeProdutoTextBox.Clear();
            precoProdutoTextBox.Clear();
            éChapaCheckBox.Checked = false;
            estoqueProdutoNumericUpDown.Value = 0;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            nomeProdutoTextBox.Clear();
            precoProdutoTextBox.Clear();
            éChapaCheckBox.Checked = false;
            estoqueProdutoNumericUpDown.Value = 0;
        }

        private void Gestão_de_Produtos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuPicture_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Visible)
            {
                pictureBox9.Visible = false;
                label9.Visible = false;
                linha1.Visible = false;
                balcaoLabel.Visible = false;
                linha2.Visible = false;
                cozinhaLabel.Visible = false;
                linha3.Visible = false;
                label10.Visible = false;
                linha4.Visible = false;
                estoqueLabel.Visible = false;
                linha5.Visible = false;
                gestãoDeProdutosLabel.Visible = false;
            }
            else
            {
                pictureBox9.Visible = true;
                label9.Visible = true;
                linha1.Visible = true;
                balcaoLabel.Visible = true;
                linha2.Visible = true;
                cozinhaLabel.Visible = true;
                linha3.Visible = true;
                label10.Visible = true;
                linha4.Visible = true;
                estoqueLabel.Visible = true;
                linha5.Visible = true;
                gestãoDeProdutosLabel.Visible = true;

                pictureBox9.BringToFront();
                linha1.BringToFront();
                linha2.BringToFront();
                linha3.BringToFront();
                linha4.BringToFront();
                linha5.BringToFront();
                label9.BringToFront();
                balcaoLabel.BringToFront();
                cozinhaLabel.BringToFront();
                label10.BringToFront();
                estoqueLabel.BringToFront();
                gestãoDeProdutosLabel.BringToFront();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ProdutosPág1 produtosPág1 = new ProdutosPág1(this);
            this.Hide();
            produtosPág1.ShowDialog();
        }

        private void balcaoLabel_Click(object sender, EventArgs e)
        {
            Balcão balcão = new Balcão(this);
            this.Hide();
            balcão.ShowDialog();
        }

        private void cozinhaLabel_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha(this);
            this.Hide();
            cozinha.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
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

        private void gestãoDeProdutosLabel_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            label9.Visible = false;
            linha1.Visible = false;
            balcaoLabel.Visible = false;
            linha2.Visible = false;
            cozinhaLabel.Visible = false;
            linha3.Visible = false;
            label10.Visible = false;
            linha4.Visible = false;
            estoqueLabel.Visible = false;
            linha5.Visible = false;
            gestãoDeProdutosLabel.Visible = false;
        }
    }
}
