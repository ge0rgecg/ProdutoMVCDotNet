using Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Config
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.Id_Cliente);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(255);

            Property(p => p.CPF)
                .IsRequired()
                .HasMaxLength(11);
        }
    }
}