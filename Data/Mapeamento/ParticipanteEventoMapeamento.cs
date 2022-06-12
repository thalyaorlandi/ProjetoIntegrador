using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Data.Mapeamento
{
    public class ParticipanteEventoMapeamento : IEntityTypeConfiguration<ParticipanteEventoModel>
    {
        public void Configure(EntityTypeBuilder<ParticipanteEventoModel> builder)
        {
            builder.ToTable("ParticipanteEvento");

            builder.HasKey("IdEvento", "IdParticipante");

            builder.Property(p => p.DataCadastro).HasColumnType("date");
        }
    }
}
