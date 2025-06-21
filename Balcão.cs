using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_10._0_Projeto_Final
{
    public partial class Balcão : Form
    {
        private ProdutosPág1 produtosPág1;
        private ProdutosPág2 produtosPág2;
        private ProdutosPág3 produtosPág3;
        private ProdutosPág4 produtosPág4;
        private Cozinha cozinha;
        private Chamada chamada;
        private Tela_Chamada tela_Chamada;
        private Estoque estoque;
        private Gestão_de_Produtos gestão_De_Produtos;

        public ListBox balcaoPublic
        {
            get { return balcaoListBox; }
        }

        public Balcão(ProdutosPág1 produtosPág1)
        {
            InitializeComponent();
            this.produtosPág1 = produtosPág1;
        }

        public Balcão(ProdutosPág2 produtosPág2)
        {
            InitializeComponent();
            this.produtosPág2 = produtosPág2;
        }

        public Balcão(ProdutosPág3 produtosPág3)
        {
            InitializeComponent();
            this.produtosPág3 = produtosPág3;
        }

        public Balcão(ProdutosPág4 produtosPág4)
        {
            InitializeComponent();
            this.produtosPág4 = produtosPág4;
        }

        public Balcão(Cozinha cozinha)
        {
            InitializeComponent();
            this.cozinha = cozinha;
        }

        public Balcão(Chamada chamada)
        {
            InitializeComponent();
            this.chamada = chamada;
        }

        public Balcão(Tela_Chamada tela_Chamada)
        {
            InitializeComponent();
            this.tela_Chamada = tela_Chamada;
        }

        public Balcão(Estoque estoque)
        {
            InitializeComponent();
            this.estoque = estoque;
        }

        public Balcão(Gestão_de_Produtos gestão_De_Produtos)
        {
            InitializeComponent();
            this.gestão_De_Produtos = gestão_De_Produtos;
        }

        public Balcão()
        {
            InitializeComponent();
            balcaoListBox.SelectedIndexChanged += balcaoListBox_SelectedIndexChanged;
        }

        private void balcaoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = balcaoListBox.SelectedIndex;
            if (indice >= 0 && indice < PedidosPersistencia.pedidosNaoChapa.Count)
            {
                detalhesPedidoListBox.Items.Clear();
                var pedido = PedidosPersistencia.pedidosNaoChapa[indice];
                detalhesPedidoListBox.Items.Add($"Cliente: {pedido.nomeCliente}");
                detalhesPedidoListBox.Items.Add("Produtos:");
                foreach (var item in pedido.itensPedidos)
                {
                    detalhesPedidoListBox.Items.Add($"x{item.quantidade} - {item.produto.Descriçao}");
                }
                detalhesPedidoListBox.Items.Add($"Pagamento: {pedido.formaPagamento}");
                string viagem = pedido.isViagem ? "Para viagem" : "Consumir no local";
                detalhesPedidoListBox.Items.Add($"Status: {viagem}");
            }
        }

        private void Balcão_Load(object sender, EventArgs e)
        {

        }

        private void AtualizarCarrinho()
        {

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

        private void produtosLabel_Click(object sender, EventArgs e)
        {
            ProdutosPág1 produtosPág1 = new ProdutosPág1(this);
            this.Hide();
            produtosPág1.ShowDialog();
        }

        private void balcaoLabel_Click(object sender, EventArgs e)
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

        private void Balcão_Load_1(object sender, EventArgs e)
        {
            AtualizarListaPedidos();
        }

        public void AtualizarListaPedidos()
        {
            balcaoListBox.Items.Clear();
            historicoListBox.Items.Clear();

            foreach (var pedido in PedidosPersistencia.pedidosNaoChapa)
            {
                balcaoListBox.Items.Add(pedido.nomeCliente);
            }

            foreach (var historico in PedidosPersistencia.historicoPedidos)
            {
                historicoListBox.Items.Add($"Cliente: {historico.nomeCliente}");
                historicoListBox.Items.Add("Produtos:");
                foreach (var p in historico.itensPedidos)
                {
                    historicoListBox.Items.Add($"x{p.quantidade} - {p.produto.Descriçao}");
                }
                historicoListBox.Items.Add($"Pagamento: {historico.formaPagamento}");
                string viagem = historico.isViagem ? "Para viagem" : "Consumir no local";
                historicoListBox.Items.Add($"Status: {viagem}");
                historicoListBox.Items.Add("-----------------------------------------------------");
            }
        }

        private void menuOpcoes_Click(object sender, EventArgs e)
        {

        }

        private void excluirLabel_Click(object sender, EventArgs e)
        {
            if (balcaoListBox.SelectedIndex != -1)
            {
                if (balcaoListBox.SelectedIndex != -1)
                {
                    var pedidoBalcao = PedidosPersistencia.pedidosNaoChapa[balcaoListBox.SelectedIndex];
                    PedidosPersistencia.pedidosNaoChapa.RemoveAt(balcaoListBox.SelectedIndex);
                    balcaoListBox.Items.RemoveAt(balcaoListBox.SelectedIndex);
                    detalhesPedidoListBox.Items.Clear();
                    MessageBox.Show("Pedido excluído!", "Aviso");
                    var pedidoCozinha = PedidosPersistencia.pedidosDeChapa.FirstOrDefault(p => p.nomeCliente.Trim() == pedidoBalcao.nomeCliente.Trim());
                    if (pedidoCozinha != null)
                    {
                        PedidosPersistencia.pedidosDeChapa.Remove(pedidoCozinha);
                        AtualizarListaPedidosCozinha();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para remover", "Erro");
            }
        }

        public void AtualizarListaPedidosCozinha()
        {
            if (cozinha != null)
            {
                cozinha.CozinhaListBox.Items.Clear();
                foreach (var pedido in PedidosPersistencia.pedidosDeChapa)
                {
                    if (pedido.itensPedidos != null && pedido.itensPedidos.Count > 0)
                    {
                        cozinha.CozinhaListBox.Items.Add(pedido.nomeCliente);
                    }
                }
            }
        }


        private void historicoButton_Click(object sender, EventArgs e)
        {
            historiclabel.Visible = true;
            pictureBox4.Visible = true;
            historicoListBox.Visible = true;
            pictureBox7.Visible = true;
            pictureBox4.BringToFront();
            historiclabel.BringToFront();
            historicoListBox.BringToFront();
            pictureBox7.BringToFront();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            historiclabel.Visible = false;
            pictureBox4.Visible = false;
            historicoListBox.Visible = false;
            pictureBox7.Visible = false;
        }

        private void historicoLabel_Click(object sender, EventArgs e)
        {
            historiclabel.Visible = true;
            pictureBox4.Visible = true;
            historicoListBox.Visible = true;
            pictureBox7.Visible = true;
            pictureBox4.BringToFront();
            historiclabel.BringToFront();
            historicoListBox.BringToFront();
            pictureBox7.BringToFront();
        }

        private void historicoPicture_Click(object sender, EventArgs e)
        {
            historiclabel.Visible = true;
            pictureBox4.Visible = true;
            historicoListBox.Visible = true;
            pictureBox7.Visible = true;
            pictureBox4.BringToFront();
            historiclabel.BringToFront();
            historicoListBox.BringToFront();
            pictureBox7.BringToFront();
        }

        private void excluirPicture_Click(object sender, EventArgs e)
        {

        }

        private void entregarLabel_Click(object sender, EventArgs e)
        {
            int indice = balcaoListBox.SelectedIndex;
            if (indice >= 0 && indice < PedidosPersistencia.pedidosNaoChapa.Count)
            {
                var pedido = PedidosPersistencia.pedidosNaoChapa[indice];
                bool pedidoChapaPendente = PedidosPersistencia.pedidosDeChapa.Any(p => p.nomeCliente == pedido.nomeCliente);
                if (pedidoChapaPendente)
                {
                    MessageBox.Show("Aguardando o pedido do cliente na cozinha", "Erro");
                    return;
                }
                PedidosPersistencia.historicoPedidos.Add(pedido);
                PedidosPersistencia.pedidosNaoChapa.RemoveAt(indice);
                balcaoListBox.Items.RemoveAt(indice);
                detalhesPedidoListBox.Items.Clear();
                AtualizarHistorico();
                Chamada chamada = new Chamada(this);
                this.Hide();
                chamada.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um pedido para entregar", "Erro");
            }
        }

        public void AtualizarHistorico()
        {
            historicoListBox.Items.Clear();
            var ultimosPedidos = PedidosPersistencia.historicoPedidos.TakeLast(5);
            foreach (var pedido in ultimosPedidos)
            {
                historicoListBox.Items.Add($"Cliente: {pedido.nomeCliente}");
                historicoListBox.Items.Add("Produtos:");
                foreach (var p in pedido.itensPedidos)
                {
                    historicoListBox.Items.Add($"x{p.quantidade} - {p.produto.Descriçao}");
                }
                historicoListBox.Items.Add($"Pagamento: {pedido.formaPagamento}");
                string viagem = pedido.isViagem ? "Para viagem" : "Consumir no local";
                historicoListBox.Items.Add($"Status: {viagem}");
                historicoListBox.Items.Add("-----------------------------------------------------");
            }
        }

        private void Balcão_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cozinhaLabel_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha(this);
            this.Hide();
            cozinha.ShowDialog();
        }

        private void entregarPicture_Click(object sender, EventArgs e)
        {

        }

        private void historicoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Tela_Chamada tela_Chamada = new Tela_Chamada(this);
            this.Hide();
            tela_Chamada.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void estoqueLabel_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque(this);
            this.Hide();
            estoque.ShowDialog();
        }

        private void gestãoDeProdutosLabel_Click(object sender, EventArgs e)
        {
            Gestão_de_Produtos gestão_De_Produtos = new Gestão_de_Produtos(this);
            this.Hide();
            gestão_De_Produtos.ShowDialog();
        }
    }
}
