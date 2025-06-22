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
        private Gestão_de_Produtos gestão_De_Produtos;

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

        public Estoque(Gestão_de_Produtos gestão_De_Produtos)
        {
            InitializeComponent();
            this.gestão_De_Produtos = gestão_De_Produtos;
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
            AtualizarTelaEstoque1();
            AtualizarProdutosEdicao();
            numericPaoDeQueijo.Maximum = decimal.MaxValue;
            numericCoxinha.Maximum = decimal.MaxValue;
            numericPastelDeCarne.Maximum = decimal.MaxValue;
            numericPastelDeQueijo.Maximum = decimal.MaxValue;
            numericSucoNatural.Maximum = decimal.MaxValue;
            numericRefrigeranteLata.Maximum = decimal.MaxValue;
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
            linha5.Visible = false;
            gestãoDeProdutosLabel.Visible = false;
        }

        private void atualizarPaoDeQueijoLabel_Click(object sender, EventArgs e)
        {
            Produtos.ListaProdutos[0].Estoque += (int)numericPaoDeQueijo.Value;
            MessageBox.Show($"Estoque de pão de queijo atualizado para {Produtos.ListaProdutos[0].Estoque}!", "Estoque atualizado");
            AtualizarTelaEstoque1();
            numericPaoDeQueijo.Value = 0;
        }

        private void atualizarCoxinhaLabel_Click(object sender, EventArgs e)
        {
            Produtos.ListaProdutos[1].Estoque += (int)numericCoxinha.Value;
            MessageBox.Show($"Estoque de coxinha atualizada para {Produtos.ListaProdutos[1].Estoque}!", "Estoque atualizado");
            AtualizarTelaEstoque1();
            numericCoxinha.Value = 0;
        }

        private void atualizarPastelDeCarneLabel_Click(object sender, EventArgs e)
        {
            Produtos.ListaProdutos[2].Estoque += (int)numericPastelDeCarne.Value;
            MessageBox.Show($"Estoque de pastel de carne atualizado para {Produtos.ListaProdutos[2].Estoque}!", "Estoque atualizado");
            AtualizarTelaEstoque1();
            numericPastelDeCarne.Value = 0;
        }

        private void atualizarPastelDeQueijoLabel_Click(object sender, EventArgs e)
        {
            Produtos.ListaProdutos[3].Estoque += (int)numericPastelDeQueijo.Value;
            MessageBox.Show($"Estoque de pastel de queijo atualizado para {Produtos.ListaProdutos[3].Estoque}!", "Estoque atualizado");
            AtualizarTelaEstoque1();
            numericPastelDeQueijo.Value = 0;
        }

        private void atualizarSucoNaturalLabel_Click(object sender, EventArgs e)
        {
            Produtos.ListaProdutos[4].Estoque += (int)numericSucoNatural.Value;
            MessageBox.Show($"Estoque de suco natural atualizado para {Produtos.ListaProdutos[4].Estoque}!", "Estoque atualizado");
            AtualizarTelaEstoque1();
            numericSucoNatural.Value = 0;
        }

        private void atualizarRefrigeranteLataLabel_Click(object sender, EventArgs e)
        {
            Produtos.ListaProdutos[5].Estoque += (int)numericRefrigeranteLata.Value;
            MessageBox.Show($"Estoque de refrigerante lata atualizado para {Produtos.ListaProdutos[5].Estoque}!", "Estoque atualizado");
            AtualizarTelaEstoque1();
            numericRefrigeranteLata.Value = 0;
        }

        public void AtualizarTelaEstoque1()
        {
            int estoquePaoQueijo = Produtos.ListaProdutos[0].Estoque;
            estoqueTotalPaoQueijo.Text = estoquePaoQueijo.ToString();
            int estoqueCoxinha = Produtos.ListaProdutos[1].Estoque;
            estoqueTotalCoxinha.Text = estoqueCoxinha.ToString();
            int estoquePastelCarne = Produtos.ListaProdutos[2].Estoque;
            estoqueTotalPastelCarne.Text = estoquePastelCarne.ToString();
            int estoquePastelQueijo = Produtos.ListaProdutos[3].Estoque;
            estoqueTotalPastelQueijo.Text = estoquePastelQueijo.ToString();
            int estoqueSucoNatural = Produtos.ListaProdutos[4].Estoque;
            estoqueTotalSucoNatural.Text = estoqueSucoNatural.ToString();
            int estoqueRefrigeranteLata = Produtos.ListaProdutos[5].Estoque;
            estoqueTotalRefrigeranteLata.Text = estoqueRefrigeranteLata.ToString();
        }

        private void diminuirPastelQueijo_Click(object sender, EventArgs e)
        {
            int estoquePastelDeQueijo = Produtos.ListaProdutos[3].Estoque;
            if (estoquePastelDeQueijo >= numericPastelDeQueijo.Value)
            {
                Produtos.ListaProdutos[3].Estoque -= (int)numericPastelDeQueijo.Value;
                MessageBox.Show($"Estoque de pastel de queijo atualizado para {Produtos.ListaProdutos[3].Estoque}!", "Estoque atualizado");
                AtualizarTelaEstoque1();
                numericPastelDeQueijo.Value = 0;
            }
            else
            {
                MessageBox.Show("Valor inválido", "Erro");
                numericPastelDeQueijo.Value = 0;
            }
        }

        private void diminuirPastelCarne_Click(object sender, EventArgs e)
        {
            int estoquePastelDeCarne = Produtos.ListaProdutos[2].Estoque;
            if (estoquePastelDeCarne >= numericPastelDeCarne.Value)
            {
                Produtos.ListaProdutos[2].Estoque -= (int)numericPastelDeCarne.Value;
                MessageBox.Show($"Estoque de pastel de carne atualizado para {Produtos.ListaProdutos[2].Estoque}!", "Estoque atualizado");
                AtualizarTelaEstoque1();
                numericPastelDeCarne.Value = 0;
            }
            else
            {
                MessageBox.Show("Valor inválido", "Erro");
                numericPastelDeCarne.Value = 0;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            int estoqueCoxinha = Produtos.ListaProdutos[1].Estoque;
            if (estoqueCoxinha >= numericCoxinha.Value)
            {
                Produtos.ListaProdutos[1].Estoque -= (int)numericCoxinha.Value;
                MessageBox.Show($"Estoque de coxinha atualizada para {Produtos.ListaProdutos[1].Estoque}!", "Estoque atualizado");
                AtualizarTelaEstoque1();
                numericCoxinha.Value = 0;
            }
            else
            {
                MessageBox.Show("Valor inválido", "Erro");
                numericCoxinha.Value = 0;
            }
        }

        private void diminuirPaoDeQueijo_Click(object sender, EventArgs e)
        {
            int estoquePaoDeQueijo = Produtos.ListaProdutos[0].Estoque;
            if (estoquePaoDeQueijo >= numericPaoDeQueijo.Value)
            {
                Produtos.ListaProdutos[0].Estoque -= (int)numericPaoDeQueijo.Value;
                MessageBox.Show($"Estoque de pão de queijo atualizado para {Produtos.ListaProdutos[0].Estoque}!", "Estoque atualizado");
                AtualizarTelaEstoque1();
                numericPaoDeQueijo.Value = 0;
            }
            else
            {
                MessageBox.Show("Valor inválido", "Erro");
                numericPaoDeQueijo.Value = 0;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void diminuirSucoNatural_Click(object sender, EventArgs e)
        {
            int estoqueSucoNatural = Produtos.ListaProdutos[4].Estoque;
            if (estoqueSucoNatural >= numericSucoNatural.Value)
            {
                Produtos.ListaProdutos[4].Estoque -= (int)numericSucoNatural.Value;
                MessageBox.Show($"Estoque de suco natural atualizado para {Produtos.ListaProdutos[4].Estoque}!", "Estoque atualizado");
                AtualizarTelaEstoque1();
                numericSucoNatural.Value = 0;
            }
            else
            {
                MessageBox.Show("Valor inválido", "Erro");
                numericSucoNatural.Value = 0;
            }
        }

        private void diminuirRefrigeranteLata_Click(object sender, EventArgs e)
        {
            int estoqueRefrigeranteLata = Produtos.ListaProdutos[5].Estoque;
            if (estoqueRefrigeranteLata >= numericRefrigeranteLata.Value)
            {
                Produtos.ListaProdutos[5].Estoque -= (int)numericRefrigeranteLata.Value;
                MessageBox.Show($"Estoque de refrigerante lata atualizado para {Produtos.ListaProdutos[5].Estoque}!", "Estoque atualizado");
                AtualizarTelaEstoque1();
                numericRefrigeranteLata.Value = 0;
            }
            else
            {
                MessageBox.Show("Valor inválido", "Erro");
                numericRefrigeranteLata.Value = 0;
            }
        }

        private void gestãoDeProdutosLabel_Click(object sender, EventArgs e)
        {
            Gestão_de_Produtos gestão_De_Produtos = new Gestão_de_Produtos(this);
            this.Hide();
            gestão_De_Produtos.ShowDialog();
        }

        private void AtualizarProdutosEdicao()
        {
            List<Label> labelsProdutos = new List<Label> { label2, label3, label4, label5, label6, label7};
            for (int i = 0; i < labelsProdutos.Count && i < Produtos.ListaProdutos.Count; i++)
            {
                labelsProdutos[i].Text = Produtos.ListaProdutos[i].Descriçao;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
