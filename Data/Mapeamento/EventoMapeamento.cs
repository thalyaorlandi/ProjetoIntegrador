using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Data.Mapeamento
{
    public class EventoMapeamento : IEntityTypeConfiguration<EventoModel>
    {
        public void Configure(EntityTypeBuilder<EventoModel> builder)
        {
            builder.ToTable("Evento");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome).HasColumnType("varchar(100)");
            builder.Property(e => e.DataCadastro).HasColumnType("date");
            builder.Property(e => e.DataEvento).HasColumnType("date");
            builder.Property(e => e.DataTermino).HasColumnType("date");
            builder.Property(e => e.HorarioInicio).HasColumnType("time");
            builder.Property(e => e.HorarioTermino).HasColumnType("time");
            builder.Property(e => e.Descricao).HasColumnType("varchar(2000)");
            builder.Property(e => e.Endereco).HasColumnType("varchar(100)");
            builder.Property(e => e.Numero).HasColumnType("varchar(8)");
            builder.Property(e => e.Cidade).HasColumnType("varchar(100)");
            builder.Property(e => e.Estado).HasColumnType("varchar(100)");
            builder.Property(e => e.LotacaoMaxima).HasColumnType("int");
            builder.Property(e => e.Status).HasColumnType("int");
            builder.Property(e => e.Categoria).HasColumnType("int");
        }
    }
}
