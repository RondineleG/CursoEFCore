using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoEFCore.Data.Configurations
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> produto)
        {
            produto.ToTable("Produto");
            produto.HasKey(x => x.Id);
            produto.Property(x => x.CodigoBarras).HasColumnType("VARCHAR(14)").IsRequired();
            produto.Property(x => x.Descricao).HasColumnType("VARCHAR(60)");
            produto.Property(x => x.Valor).IsRequired();
            produto.Property(x => x.TipoProduto).HasConversion<string>();
        }
    }
}