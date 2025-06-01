using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_10._0_Projeto_Final
{
    internal class Pedidos
    {
        private List<(Produtos produto, int quantidade)> ItensPedidos;
        private string NomeCliente;
        private string FormaPagamento;
        private bool IsViagem;

        public Pedidos()
        {
            ItensPedidos = new List<(Produtos produto, int quantidade)>();
            NomeCliente = "";
            FormaPagamento = "";
            IsViagem = false;
        }

        public Pedidos (string nomeCliente, string formaPagamento, bool isViagem, List<(Produtos produto, int quantidade)> itensPedidos)
        {
            this.ItensPedidos = itensPedidos;
            this.NomeCliente = nomeCliente;
            this.FormaPagamento = formaPagamento;
            this.IsViagem = isViagem;
        }

        public string nomeCliente
        {
            get { return NomeCliente; }
            set { NomeCliente = value; }
        }

        public string formaPagamento
        {
            get { return FormaPagamento; }
            set { FormaPagamento = value; }
        }

        public bool isViagem
        {
            get { return IsViagem; }
            set { IsViagem = value; }
        }
        public List<(Produtos produto, int quantidade)> itensPedidos
        {
            get { return ItensPedidos; }
            set { ItensPedidos = value; }
        }
    }
}
