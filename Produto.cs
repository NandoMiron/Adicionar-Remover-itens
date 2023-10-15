using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula42
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        
        public double ValorTotalEmEstoque()
        {
            
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome + ", R$ : " + Preco.ToString("F2",CultureInfo.InvariantCulture) +", "+ Quantidade + " unidades , Total : R$ "+ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int novaQuantidade)
        {
            Quantidade = Quantidade + novaQuantidade;
        }

        public void RemoverProdutos(int novaQuantidade)
        {
            Quantidade = Quantidade - novaQuantidade;
        }
    }
}
