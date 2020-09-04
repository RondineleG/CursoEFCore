using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoEFCore.Data.Configurations
{
    public class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> pedido)
        {
            pedido.ToTable("Pedidos");
            pedido.HasKey(x => x.Id);
            pedido.Property(x => x.IniciadoEm).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            pedido.Property(x => x.Status).HasConversion<string>();
            pedido.Property(x => x.TipoFrete).HasConversion<int>();
            pedido.Property(x => x.Observacao).HasColumnType("VARCHAR(512)");

            pedido.HasMany(x => x.Itens)
                  .WithOne(x => x.Pedido)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}