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
    }
}
