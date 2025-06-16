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

        public Estoque(Estoque_Pág_2 estoque_Pág_2)
        {
            InitializeComponent();
            this.estoque_Pág_2 = estoque_Pág_2;
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
    }
}
