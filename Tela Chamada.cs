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
    public partial class Tela_Chamada : Form
    {
        private ProdutosPág1 produtosPág1;
        private ProdutosPág2 produtosPág2;
        private ProdutosPág3 produtosPág3;
        private ProdutosPág4 produtosPág4;
        private Balcão balcão;
        private Cozinha cozinha;
        private Estoque estoque;
        private Gestão_de_Produtos gestão_De_Produtos;

        public Tela_Chamada(ProdutosPág1 produtosPág1)
        {
            InitializeComponent();
            this.produtosPág1 = produtosPág1;
        }

        public Tela_Chamada(ProdutosPág2 produtosPág2)
        {
            InitializeComponent();
            this.produtosPág2 = produtosPág2;
        }

        public Tela_Chamada(ProdutosPág3 produtosPág3)
        {
            InitializeComponent();
            this.produtosPág3 = produtosPág3;
        }

        public Tela_Chamada(ProdutosPág4 produtosPág4)
        {
            InitializeComponent();
            this.produtosPág4 = produtosPág4;
        }

        public Tela_Chamada(Balcão balcão)
        {
            InitializeComponent();
            this.balcão = balcão;
        }

        public Tela_Chamada(Cozinha cozinha)
        {
            InitializeComponent();
            this.cozinha = cozinha;
        }

        public Tela_Chamada(Estoque estoque)
        {
            InitializeComponent();
            this.estoque = estoque;
        }
        public Tela_Chamada(Gestão_de_Produtos gestão_De_Produtos)
        {
            InitializeComponent();
            this.gestão_De_Produtos = gestão_De_Produtos;
        }

        public Tela_Chamada()
        {
            InitializeComponent();
        }

        private void Tela_Chamada_Load(object sender, EventArgs e)
        {
            AtualizarChamada();
        }

        private void Tela_Chamada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void produtosLabel_Click(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
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
            gestãoDeProdutosLabel.Visible = false;
        }

        private void menuPicture_Click(object sender, EventArgs e)
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
                gestãoDeProdutosLabel.Visible = false;
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
                gestãoDeProdutosLabel.Visible = true;

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
                gestãoDeProdutosLabel.BringToFront();
            }
        }

        public void AtualizarChamada()
        {
            {
                preparandoListBox.Items.Clear();
                prontosListBox.Items.Clear();

                var pedidosPreparando = PedidosPersistencia.pedidosNaoChapa.Select(p => p.nomeCliente).Concat(PedidosPersistencia.pedidosDeChapa.Select(p => p.nomeCliente)).Distinct();
                foreach (var preparandoPedido in pedidosPreparando)
                {
                    preparandoListBox.Items.Add(preparandoPedido);
                }
                foreach (var pedidoPronto in PedidosPersistencia.historicoPedidos)
                {
                    prontosListBox.Items.Add(pedidoPronto.nomeCliente);
                }
            }
        }

        private void estoqueLabel_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            this.Hide();
            estoque.ShowDialog();
        }

        private void prontosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void preparandoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gestãoDeProdutosLabel_Click(object sender, EventArgs e)
        {
            Gestão_de_Produtos gestão_De_Produtos = new Gestão_de_Produtos();
            this.Hide();
            gestão_De_Produtos.ShowDialog();
        }
    }
}
