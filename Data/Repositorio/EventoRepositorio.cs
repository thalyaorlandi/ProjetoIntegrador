using ProjetoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoIntegrador.Data.Repositorio
{
    public class EventoRepositorio : IEventoRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public EventoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<EventoModel> BuscarEventos()
        {
            return _bancoContexto.Eventos.Where(e => e.DataEvento > DateTime.Now && e.Status == Status.Ativo).ToList();
        }

        public void Inserir(EventoModel evento)
        {
            _bancoContexto.Eventos.Add(evento);
            _bancoContexto.SaveChanges();
        }
    }
}
