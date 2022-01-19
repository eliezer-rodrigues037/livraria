using livraria.api.Buisness.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace livraria.api.Infrastructure.Data.Mappings
{
    public class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("tb_Livro");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Titulo);
            builder.Property(p => p.Sinopse);
            builder.Property(p => p.TipoLivro);
            builder.Property(p => p.CodigoISBN);
            builder.Property(p => p.Valor);

        }
    }

}
