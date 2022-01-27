using OrdemPedido.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemPedido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;
            Client cliente = new Client("Carlos", "carlos-84@live.com", data);

            Console.WriteLine("digite seu nome: ");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("Sua data de nascimento (DD/MM/YYYY)");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu email: ");
            string emailCliente = Console.ReadLine();

            Console.WriteLine("Digite a quantidades de produtos a comprar");
            int qtdeProdutos = int.Parse(Console.ReadLine());

            Order ordem = new Order();

            for (int i = 0; i < qtdeProdutos; i++)
            {
                Console.WriteLine("Digite o nome do produto " + (i + 1) + ": ");
                string nomeProduto = Console.ReadLine();

                Console.WriteLine("Digite o valor do produto " + (i + 1) + ": ");
                double valorProduto = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade de produtos " + (i+1) + ": ");
                int quantidadeProduto = int.Parse(Console.ReadLine());
               

                Product prod = new Product(nomeProduto, valorProduto);

                OrderItem itens = new OrderItem(quantidadeProduto, valorProduto, prod);
                ordem.addItem(itens);
                
            }
              

             Console.WriteLine("Nome do cliente: " + nomeCliente);
             Console.WriteLine("Email do cleinte: " + emailCliente);
             Console.WriteLine("Data de nascimento: " + dataNascimento);
             Console.WriteLine("Quantos itens voce comprou: " + qtdeProdutos);   
             Console.WriteLine(ordem);
            Console.WriteLine("Quantidade de produtos comprados: ");
            //Console.WriteLine(itens.subTotal());

        }
    }
    
}
