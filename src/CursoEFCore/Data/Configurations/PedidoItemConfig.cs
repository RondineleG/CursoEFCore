using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoEFCore.Data.Configurations
{
    public class PedidoItemConfig : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> pedidoItem)
        {
            pedidoItem.ToTable("PedidoIten");
            pedidoItem.HasKey(x => x.Id);
            pedidoItem.Property(x => x.Quantidade).HasDefaultValue(0).IsRequired();
            pedidoItem.Property(x => x.Valor).HasDefaultValue(0).IsRequired();
            pedidoItem.Property(x => x.Desconto).HasDefaultValue(0).IsRequired();
        }
    }
}