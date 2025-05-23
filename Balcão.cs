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
        public Balcão(ProdutosPág1 produtosPág1)
        {
            InitializeComponent();
            this.produtosPág1 = produtosPág1;
        }

        private void balcaoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Balcão_Load(object sender, EventArgs e)
        {

        }

        private void AtualizarCarrinho()
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            menuOpcoes.Visible = true;
            produtosLabel.Visible = true;
            linha1.Visible = true;
            balcaoLabel.Visible = true;
            linha2.Visible = true;
            menuOpcoes.BringToFront();
            linha1.BringToFront();
            linha2.BringToFront();
            produtosLabel.BringToFront();
            balcaoLabel.BringToFront();
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
        }
    }
}
