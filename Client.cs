using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemPedido.Entidades
{
    internal class Client
    {
        public string nome;
        public string email;
        public DateTime data;

        public Client(string nome, string email, DateTime data)
        {
            this.nome = nome;
            this.email = email;
            this.data = data;
        }
    }
}
