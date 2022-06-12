using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Data.Repositorio
{
    public class ParticipanteEventoRepositorio : IParticipanteEventoRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public ParticipanteEventoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public void Inserir(ParticipanteEventoModel participanteEvento)
        {
            _bancoContexto.ParticipantesEvento.Add(participanteEvento);
            _bancoContexto.SaveChanges();
        }
    }
}
