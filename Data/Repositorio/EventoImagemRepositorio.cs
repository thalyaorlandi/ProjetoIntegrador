using ProjetoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Data.Repositorio
{
    public class EventoImagemRepositorio : IEventoImagemRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public EventoImagemRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public void Inserir(EventoImagemModel eventoImagem)
        {
            _bancoContexto.EventoImagens.Add(eventoImagem);
            _bancoContexto.SaveChanges();
        }
    }
}
