using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemPedido.Entidades
{
    internal class OrderItem
    {
        public int quantidade;
        public double price;
        Product produto;

        public OrderItem()
        {
        }

        public OrderItem(int quantidade, double price, Product produto)
        {
            this.quantidade = quantidade;
            this.price = price;
            this.produto = produto;
        }

        public double subTotal()
        {
            return quantidade * price;
        }

    }
}
