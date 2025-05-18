using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_10._0_Projeto_Final
{
    internal class Produtos
    {
        private string descriçao;
        private double preço;

        public Produtos()
        {
            descriçao = string.Empty;
            preço = 0;
        }

        public Produtos(string descriçao, double preço)
        {
            this.descriçao = descriçao;
            this.preço = preço;
        }

        public string Descriçao
        {
            get {return descriçao;}
            set {descriçao=value;}
        }

        public double Preço
        {
            get { return preço; }
            set { preço = value;}
        }

        public override string ToString()
        {
            return descriçao + " - R$" + preço.ToString("F2");
        }

        public static List<Produtos> ListaProdutos = new List<Produtos>()
        {
            new Produtos("Pão de Queijo", 3.50),
            new Produtos("Coxinha", 5.00),
            new Produtos("Pastel de Carne", 6.00),
            new Produtos("Pastel de Queijo", 5.50),
            new Produtos("Suco Natural (300ml)", 5.00),
            new Produtos("Refrigerante Lata", 4.50),
            new Produtos("Hambúrguer Simples", 8.00),
            new Produtos("Hambúrguer Com Queijo", 9.00),
            new Produtos("X-Tudo", 12.00),
            new Produtos("Água Mineral (500ml)", 2.50)
        };
    }
}
