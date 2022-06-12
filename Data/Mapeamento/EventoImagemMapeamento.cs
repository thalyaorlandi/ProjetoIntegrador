using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Data.Mapeamento
{
    public class EventoImagemMapeamento : IEntityTypeConfiguration<EventoImagemModel>
    {
        public void Configure(EntityTypeBuilder<EventoImagemModel> builder)
        {
            builder.ToTable("EventoImagem");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Imagem).HasColumnType("varchar(max)");
            builder.Property(e => e.IdEvento).HasColumnType("int");
        }
    }
}
