﻿using System;
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
    public partial class Cozinha : Form
    {
        private ProdutosPág1 produtosPág1;
        private ProdutosPág2 produtosPág2;
        private ProdutosPág3 produtosPág3;
        private ProdutosPág4 produtosPág4;
        private Balcão balcão;
        private Tela_Chamada tela_Chamada;
        private Estoque estoque;
        private Gestão_de_Produtos gestão_De_Produtos;

        public ListBox CozinhaListBox
        {
            get { return cozinhaListBox; }
        }

        public Cozinha(ProdutosPág1 produtosPág1)
        {
            InitializeComponent();
            this.produtosPág1 = produtosPág1;
        }

        public Cozinha(ProdutosPág2 produtosPág2)
        {
            InitializeComponent();
            this.produtosPág2 = produtosPág2;
        }

        public Cozinha(ProdutosPág3 produtosPág3)
        {
            InitializeComponent();
            this.produtosPág3 = produtosPág3;
        }

        public Cozinha(ProdutosPág4 produtosPág4)
        {
            InitializeComponent();
            this.produtosPág4 = produtosPág4;
        }

        public Cozinha(Balcão balcão)
        {
            InitializeComponent();
            this.balcão = balcão;
        }
        public Cozinha(Tela_Chamada tela_Chamada)
        {
            InitializeComponent();
            this.tela_Chamada = tela_Chamada;
        }

        public Cozinha(Estoque estoque)
        {
            InitializeComponent();
            this.estoque = estoque;
        }

        public Cozinha(Gestão_de_Produtos gestão_De_Produtos)
        {
            InitializeComponent();
            this.gestão_De_Produtos = gestão_De_Produtos;
        }

        public Cozinha()
        {
            InitializeComponent();
            cozinhaListBox.SelectedIndexChanged += cozinhaListBox_SelectedIndexChanged;
        }

        private void Cozinha_Load(object sender, EventArgs e)
        {
            AtualizarListaPedidosCozinha();
        }

        public void AtualizarListaPedidos()
        {

        }

        private void cozinhaLabel_Click(object sender, EventArgs e)
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

        private void Cozinha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cozinhaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cozinhaListBox.SelectedIndex;
            if (indice >= 0 && indice < PedidosPersistencia.pedidosDeChapa.Count)
            {
                var pedido = PedidosPersistencia.pedidosDeChapa[indice];
                cozinhaDetalhesListBox.Items.Clear();
                foreach (var item in pedido.itensPedidos)
                {
                    cozinhaDetalhesListBox.Items.Add($"x{item.quantidade} - {item.produto.Descriçao}");
                }
            }
        }

        public void AtualizarListaPedidosCozinha()
        {
            cozinhaListBox.Items.Clear();

            foreach (var pedido in PedidosPersistencia.pedidosDeChapa)
            {
                if (pedido.itensPedidos != null && pedido.itensPedidos.Count > 0)
                {
                    cozinhaListBox.Items.Add(pedido.nomeCliente);
                }
            }
        }

        public void AtualizarListaPedidosChapa()
        {
            cozinhaListBox.Items.Clear();

            foreach (var pedido in PedidosPersistencia.pedidosDeChapa)
            {
                cozinhaListBox.Items.Add(pedido.nomeCliente);
            }
        }

        private void enviarPedidoBalcaoPictureBox_Click(object sender, EventArgs e)
        {
            int indice = cozinhaListBox.SelectedIndex;
            if (indice >= 0 && indice < PedidosPersistencia.pedidosDeChapa.Count)
            {
                var pedidoChapa = PedidosPersistencia.pedidosDeChapa[indice];

                var pedidoExistente = PedidosPersistencia.pedidosNaoChapa
                    .FirstOrDefault(p => p.nomeCliente.Trim() == pedidoChapa.nomeCliente.Trim());

                if (pedidoExistente != null)
                {
                    pedidoExistente.itensPedidos.AddRange(pedidoChapa.itensPedidos);
                }
                else
                {
                    PedidosPersistencia.pedidosNaoChapa.Add(pedidoChapa);
                }
                PedidosPersistencia.pedidosDeChapa.RemoveAt(indice);
                cozinhaListBox.Items.RemoveAt(indice);
                cozinhaDetalhesListBox.Items.Clear();
                AtualizarListaPedidosChapa();
            }
        }

        private void enviarPedidoBalcaoLabel_Click(object sender, EventArgs e)
        {
            int indice = cozinhaListBox.SelectedIndex;
            if (indice >= 0 && indice < PedidosPersistencia.pedidosDeChapa.Count)
            {
                var pedidoChapa = PedidosPersistencia.pedidosDeChapa[indice];
                var pedidoExistente = PedidosPersistencia.pedidosNaoChapa.FirstOrDefault(p => p.nomeCliente.Trim() == pedidoChapa.nomeCliente.Trim());
                if (pedidoExistente != null)
                {
                    pedidoExistente.itensPedidos.AddRange(pedidoChapa.itensPedidos);
                    MessageBox.Show("Pedido enviado ao balcão!", "Confirmação");
                }
                else
                {
                    PedidosPersistencia.pedidosNaoChapa.Add(pedidoChapa);
                    MessageBox.Show("Pedido enviado ao balcão!", "Confirmação");
                }
                PedidosPersistencia.pedidosDeChapa.RemoveAt(indice);
                cozinhaListBox.Items.RemoveAt(indice);
                cozinhaDetalhesListBox.Items.Clear();
                AtualizarListaPedidosChapa();
            }
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

        private void gestãoDeProdutosLabel_Click(object sender, EventArgs e)
        {
            Gestão_de_Produtos gestão_De_Produtos = new Gestão_de_Produtos(this);
            this.Hide();
            gestão_De_Produtos.ShowDialog();
        }
    }
}
