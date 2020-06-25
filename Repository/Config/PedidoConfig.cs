using Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Config
{
    public class PedidoConfig : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfig()
        {
            HasKey(c => c.Id_Pedido);

            Property(p => p.DataEntrega)
                .IsRequired();

            HasOptional(o => o.Cliente)
                .WithMany()
                .HasForeignKey(f => f.Cliente_Id);

            Property(p => p.Cliente_Id)
                .HasColumnName("Cliente_Id");

            HasMany(h => h.ListaProduto).WithRequired(w => w.Pedido);

        }
    }
}