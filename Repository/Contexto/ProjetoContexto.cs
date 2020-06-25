using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Dominio;
using Repository.Config;

namespace Repository.Contexto
{
    public class ProjetoContexto : DbContext
    {
        public ProjetoContexto()
            : base("bancoProva")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }
        public DbSet<Pedido> Pedido { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == "Id_" + p.ReflectedType.Name )
                .Configure(p => p.IsKey());
            
            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
            modelBuilder.Configurations.Add(new PedidoItemConfig());
            modelBuilder.Configurations.Add(new PedidoConfig());

        }
    }
}
