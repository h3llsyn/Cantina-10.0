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
    public partial class Estoque : Form
    {
        private Estoque_Pág_2 estoque_Pág_2;
        private ProdutosPág1 produtosPág1;
        private ProdutosPág2 produtosPág2;
        private ProdutosPág3 produtosPág3;
        private ProdutosPág4 produtosPág4;
        private Balcão balcão;
        private Cozinha cozinha;
        private Tela_Chamada tela_Chamada;

        public Estoque(Estoque_Pág_2 estoque_Pág_2)
        {
            InitializeComponent();
            this.estoque_Pág_2 = estoque_Pág_2;
        }

        public Estoque(ProdutosPág1 produtosPág1)
        {
            InitializeComponent();
            this.produtosPág1 = produtosPág1;
        }

        public Estoque(ProdutosPág2 produtosPág2)
        {
            InitializeComponent();
            this.produtosPág2 = produtosPág2;
        }

        public Estoque(ProdutosPág3 produtosPág3)
        {
            InitializeComponent();
            this.produtosPág3 = produtosPág3;
        }

        public Estoque(ProdutosPág4 produtosPág4)
        {
            InitializeComponent();
            this.produtosPág4 = produtosPág4;
        }

        public Estoque(Balcão balcão)
        {
            InitializeComponent();
            this.balcão = balcão;
        }

        public Estoque(Cozinha cozinha)
        {
            InitializeComponent();
            this.cozinha = cozinha;
        }

        public Estoque(Tela_Chamada tela_Chamada)
        {
            InitializeComponent();
            this.tela_Chamada = tela_Chamada;
        }

        public Estoque()
        {
            InitializeComponent();
        }

        private void setaDireita_Click(object sender, EventArgs e)
        {
            Estoque_Pág_2 estoque_Pág_2 = new Estoque_Pág_2(this);
            this.Hide();
            estoque_Pág_2.ShowDialog();
        }

        private void Estoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {

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

                menuOpcoes.BringToFront();
                linha1.BringToFront();
                linha2.BringToFront();
                linha3.BringToFront();
                linha4.BringToFront();
                produtosLabel.BringToFront();
                balcaoLabel.BringToFront();
                cozinhaLabel.BringToFront();
                label9.BringToFront();
                estoqueLabel.BringToFront();
            }
        }

        private void produtosLabel_Click(object sender, EventArgs e)
        {
            ProdutosPág1 produtosPág1 = new ProdutosPág1();
            this.Hide();
            produtosPág1.ShowDialog();
        }

        private void balcaoLabel_Click(object sender, EventArgs e)
        {
            Balcão balcão = new Balcão();
            this.Hide();
            balcão.ShowDialog();
        }

        private void cozinhaLabel_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha();
            this.Hide();
            cozinha.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Tela_Chamada tela_Chamada = new Tela_Chamada();
            this.Hide();
            tela_Chamada.ShowDialog();
        }

        private void estoqueLabel_Click(object sender, EventArgs e)
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
        }
    }
}
