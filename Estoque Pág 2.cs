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
    public partial class Estoque_Pág_2 : Form
    {
        private Estoque estoque;

        public Estoque_Pág_2(Estoque estoque)
        {
            InitializeComponent();
            this.estoque = estoque;
        }

        public Estoque_Pág_2()
        {
            InitializeComponent();
        }

        private void setaEsquerda_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque(this);
            this.Hide();
            estoque.ShowDialog();
        }

        private void Estoque_Pág_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void Estoque_Pág_2_Load(object sender, EventArgs e)
        {
            AtualizarTelaEstoque2();
            numericHamburguerSimples.Maximum = decimal.MaxValue;
            numericHamburguerComQueijo.Maximum = decimal.MaxValue;
            numericXTudo.Maximum = decimal.MaxValue;
            numericAguaMineral.Maximum = decimal.MaxValue;
        }

        private void atualizarHamburguerSimplesLabel_Click(object sender, EventArgs e)
        {
            Produtos.ListaProdutos[6].Estoque += (int)numericHamburguerSimples.Value;
            MessageBox.Show($"Estoque de hambúrguer simples atualizado para {Produtos.ListaProdutos[6].Estoque}!", "Estoque atualizado");
            AtualizarTelaEstoque2();
            numericHamburguerSimples.Value = 0;
        }

        private void atualizarHamburguerComQueijoLabel_Click(object sender, EventArgs e)
        {
            Produtos.ListaProdutos[7].Estoque += (int)numericHamburguerComQueijo.Value;
            MessageBox.Show($"Estoque de hambúrguer com queijo atualizado para {Produtos.ListaProdutos[7].Estoque}!", "Estoque atualizado");
            AtualizarTelaEstoque2();
            numericHamburguerComQueijo.Value = 0;
        }

        private void atualizarXTudoLabel_Click(object sender, EventArgs e)
        {
            Produtos.ListaProdutos[8].Estoque += (int)numericXTudo.Value;
            MessageBox.Show($"Estoque de x-tudo atualizado para {Produtos.ListaProdutos[8].Estoque}!", "Estoque atualizado");
            AtualizarTelaEstoque2();
            numericXTudo.Value = 0;
        }

        private void atualizarAguaMineralLabel_Click(object sender, EventArgs e)
        {
            Produtos.ListaProdutos[9].Estoque += (int)numericAguaMineral.Value;
            MessageBox.Show($"Estoque de água mineral atualizado para {Produtos.ListaProdutos[9].Estoque}!", "Estoque atualizado");
            AtualizarTelaEstoque2();
            numericAguaMineral.Value = 0;
        }

        public void AtualizarTelaEstoque2()
        {
            int estoqueHamburguerSimples = Produtos.ListaProdutos[6].Estoque;
            estoqueTotalHamburguerSimples.Text = estoqueHamburguerSimples.ToString();
            int estoqueHamburguerQueijo = Produtos.ListaProdutos[7].Estoque;
            estoqueTotalHamburguerComQueijo.Text = estoqueHamburguerQueijo.ToString();
            int estoqueXTudo = Produtos.ListaProdutos[8].Estoque;
            estoqueTotalXTudo.Text = estoqueXTudo.ToString();
            int estoqueAguaMineral = Produtos.ListaProdutos[9].Estoque;
            estoqueTotalAguaMineral.Text = estoqueAguaMineral.ToString(); 
        }

        private void diminuirHamburguerSimples_Click(object sender, EventArgs e)
        {
            int estoqueHamburguerSimples = Produtos.ListaProdutos[6].Estoque;
            if (estoqueHamburguerSimples >= numericHamburguerSimples.Value)
            {
                Produtos.ListaProdutos[6].Estoque -= (int)numericHamburguerSimples.Value;
                MessageBox.Show($"Estoque de hambúrguer simples atualizado para {Produtos.ListaProdutos[6].Estoque}!", "Estoque atualizado");
                AtualizarTelaEstoque2();
                numericHamburguerSimples.Value = 0;
            }
            else
            {
                MessageBox.Show("Valor inválido", "Erro");
                numericHamburguerSimples.Value = 0;
            }
        }

        private void diminuirHamburguerComQueijo_Click(object sender, EventArgs e)
        {
            int estoqueHamburguerComQueijo = Produtos.ListaProdutos[7].Estoque;
            if (estoqueHamburguerComQueijo >= numericHamburguerComQueijo.Value)
            {
                Produtos.ListaProdutos[7].Estoque -= (int)numericHamburguerComQueijo.Value;
                MessageBox.Show($"Estoque de hambúrguer com queijo atualizado para {Produtos.ListaProdutos[7].Estoque}!", "Estoque atualizado");
                AtualizarTelaEstoque2();
                numericHamburguerComQueijo.Value = 0;
            }
            else
            {
                MessageBox.Show("Valor inválido", "Erro");
                numericHamburguerComQueijo.Value = 0;
            }
        }

        private void diminuirXTudo_Click(object sender, EventArgs e)
        {
            int estoqueXTudo = Produtos.ListaProdutos[8].Estoque;
            if (estoqueXTudo >= numericXTudo.Value)
            {
                Produtos.ListaProdutos[8].Estoque -= (int)numericXTudo.Value;
                MessageBox.Show($"Estoque de x-tudo atualizado para {Produtos.ListaProdutos[8].Estoque}!", "Estoque atualizado");
                AtualizarTelaEstoque2();
                numericXTudo.Value = 0;
            }
            else
            {
                MessageBox.Show("Valor inválido", "Erro");
                numericXTudo.Value = 0;
            }
        }

        private void diminuirAguaMineral_Click(object sender, EventArgs e)
        {
            int estoqueAguaMineral = Produtos.ListaProdutos[9].Estoque;
            if(estoqueAguaMineral >= numericAguaMineral.Value)
            {
                Produtos.ListaProdutos[9].Estoque -= (int)numericAguaMineral.Value;
                MessageBox.Show($"Estoque de água mineral atualizado para {Produtos.ListaProdutos[9].Estoque}!", "Estoque atualizado");
                AtualizarTelaEstoque2();
                numericAguaMineral.Value = 0;
            }
            else
            {
                MessageBox.Show("Valor inválido", "Erro");
                numericAguaMineral.Value = 0;
            }
        }
    }
}
