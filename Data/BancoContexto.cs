using Microsoft.EntityFrameworkCore;
using ProjetoIntegrador.Data.Mapeamento;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Data
{
    public class BancoContexto : DbContext
    {
        public DbSet<EventoModel> Eventos { get; set; }
        public DbSet<ParticipanteModel> Participantes { get; set; }
        public DbSet<ParticipanteEventoModel> ParticipantesEvento { get; set; }
        public DbSet<EventoImagemModel> EventoImagens { get; set; }

        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EventoMapeamento());
            modelBuilder.ApplyConfiguration(new ParticipanteMapeamento());
            modelBuilder.ApplyConfiguration(new ParticipanteEventoMapeamento());
            modelBuilder.ApplyConfiguration(new EventoImagemMapeamento());
        }
    }
}
