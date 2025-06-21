using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_10._0_Projeto_Final
{
    public class Produtos
    {
        private string descriçao;
        private double preço;
        private bool chapa;
        private int estoque;

        public Produtos()
        {
            descriçao = string.Empty;
            preço = 0;
            estoque = 0;
        }

        public Produtos(string descriçao, double preço, bool chapa, int estoque)
        {
            this.descriçao = descriçao;
            this.preço = preço;
            this.chapa = chapa;
            this.estoque = estoque;
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

        public bool Chapa
        {
            get { return chapa;}
            set { chapa=value;}
        }

        public int Estoque
        {
            get { return estoque;}
            set { estoque = value;}
        }

        public override string ToString()
        {
            return descriçao + " - R$" + preço.ToString("F2");
        }

        public string DetalhesCompletos()
        {
            return $"{descriçao} - R${preço:F2} | {(chapa ? "Chapa" : "Não Chapa")} | Estoque: {estoque}";
        }

        public static List<Produtos> ListaProdutos = new List<Produtos>()
        {
            new Produtos("Pão de Queijo", 3.50, false, 0),
            new Produtos("Coxinha", 5.00, false, 0),
            new Produtos("Pastel de Carne", 6.00, true, 0),
            new Produtos("Pastel de Queijo", 5.50, true, 0),
            new Produtos("Suco Natural (300ml)", 5.00, false, 0),
            new Produtos("Refrigerante Lata", 4.50, false, 0),
            new Produtos("Hambúrguer Simples", 8.00, true, 0),
            new Produtos("Hambúrguer Com Queijo", 9.00, true, 0),
            new Produtos("X-Tudo", 12.00, true, 0),
            new Produtos("Água Mineral (500ml)", 2.50, false, 0)
        };
    }
}
