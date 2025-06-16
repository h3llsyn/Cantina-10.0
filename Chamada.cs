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
            CentralizarNome();
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
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

        private void CentralizarNome()
        {
            using (Graphics g = CreateGraphics())
            {
                SizeF tamanhoTexto = g.MeasureString(nomeClienteChamada.Text, nomeClienteChamada.Font);

                int novaPosX = (this.ClientSize.Width - (int)tamanhoTexto.Width) / 2;
                int novaPosY = (this.ClientSize.Height - (int)tamanhoTexto.Height) / 2 + 50;

                nomeClienteChamada.Location = new Point(novaPosX, novaPosY);
            }
        }


        private void entregarLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Balcão balcão = new Balcão(this);
            this.Hide();
            balcão.ShowDialog();
        }
    }
}
