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
    public partial class Chamada : Form
    {
        private Balcão balcão;

        public Chamada(Balcão balcão)
        {
            InitializeComponent();
            this.balcão = balcão;
        }

        public Chamada()
        {
            InitializeComponent();
        }

        private void Chamada_Load(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void Chamada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void AtualizarTela()
        {
            var ultimosPedidos = PedidosPersistencia.historicoPedidos.TakeLast(1);
            foreach (var pedido in ultimosPedidos)
            {
                nomeClienteChamada.Text = pedido.nomeCliente;
            }
        }

        private void entregarLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido entregue!", "Confirmação");
            Balcão balcão = new Balcão(this);
            this.Hide();
            balcão.ShowDialog();
        }
    }
}
