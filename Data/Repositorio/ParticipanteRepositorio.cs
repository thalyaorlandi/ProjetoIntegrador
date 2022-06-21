using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Data.Repositorio
{
    public class ParticipanteRepositorio : IParticipanteRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public ParticipanteRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public void Inserir(ParticipanteModel participante)
        {
            _bancoContexto.Participantes.Add(participante);
            _bancoContexto.SaveChanges();
        }
    }
}
