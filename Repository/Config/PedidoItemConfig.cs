using Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Config
{
    public class PedidoItemConfig : EntityTypeConfiguration<PedidoItem>
    {
        public PedidoItemConfig()
        {
            HasKey(c => c.Id_PedidoItem);

            Property(p => p.Quantidade)
                .IsRequired();

            this.HasRequired(h => h.Produto)
                .WithMany()
                .HasForeignKey(h => h.Produto_Id);

            this.HasRequired(h => h.Pedido)
                .WithMany()
                .HasForeignKey(h => h.Pedido_Id);

            Property(p => p.Produto_Id)
                .IsRequired()
                .HasColumnName("Produto_Id");

            Property(p => p.Pedido_Id)
                .IsRequired()
                .HasColumnName("Pedido_Id");
        }
    }
}