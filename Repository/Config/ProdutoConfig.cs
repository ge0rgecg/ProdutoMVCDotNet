using Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Config
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(c => c.Id_Produto);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.Valor)
                .IsRequired();
        }
    }
}