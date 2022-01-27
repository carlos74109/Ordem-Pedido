using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemPedido.Entidades
{
    internal class Order
    {
        public DateTime moment;
        List<OrderItem> items { get; set; } = new List<OrderItem>();
        public void addItem(OrderItem item)
        {
            items.Add(item);
        }

        public double total()
        {
            double soma = 0;
            foreach (OrderItem item in items)
            {
                soma += item.subTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            
                    
            return "O valor total da sua compra foi: R$"+total().ToString();
        }

    }
}
