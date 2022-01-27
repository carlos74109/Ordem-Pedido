using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemPedido.Entidades
{
    internal class Product
    {
        public string nome;
        public double preco;

        public Product(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
    }
}
