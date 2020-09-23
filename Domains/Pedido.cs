using System;
using System.Collections.Generic;


namespace Senai.EfCore.Tarde.Domains
{
    public class Pedido : BaseDomain
    {
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }

        public List<PedidoItem> PedidosItens { get; set; }

        public Pedido()
        {
            PedidosItens = new List<PedidoItem>();

        }

    }
}
