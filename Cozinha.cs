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
    public partial class Cozinha : Form
    {
        private ProdutosPág1 produtosPág1;
        private ProdutosPág2 produtosPág2;
        private ProdutosPág3 produtosPág3;
        private ProdutosPág4 produtosPág4;
        private Balcão balcão;

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

        public Cozinha()
        {
            InitializeComponent();
        }

        private void Cozinha_Load(object sender, EventArgs e)
        {

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

                menuOpcoes.BringToFront();
                linha1.BringToFront();
                linha2.BringToFront();
                linha3.BringToFront();
                produtosLabel.BringToFront();
                balcaoLabel.BringToFront();
                cozinhaLabel.BringToFront();
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

        }
    }
}
