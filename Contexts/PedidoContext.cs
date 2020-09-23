using Microsoft.EntityFrameworkCore;
using Senai.EfCore.Tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.EfCore.Tarde.Contexts
{
    public class PedidoContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Pedido> Produtos { get; set; }
        public DbSet<Pedido> PedidosItens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=LAB105801\SQLEXPRESS2;Initial Catalog=Db_Senai_Pedidos_Tarde_Dev; user ID=sa;Password=sa132");
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
