using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Data.Mapeamento
{
    public class ParticipanteMapeamento : IEntityTypeConfiguration<ParticipanteModel>
    {
        public void Configure(EntityTypeBuilder<ParticipanteModel> builder)
        {
            builder.ToTable("Participante");

            builder.HasKey(e => e.Id);

            
            builder.Property(e => e.Nome).HasColumnType("varchar(200)");
            builder.Property(e => e.Email).HasColumnType("varchar(200)");   
        }
    }
}
