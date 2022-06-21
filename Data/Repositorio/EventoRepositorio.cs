using ProjetoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            return _bancoContexto.Eventos
                .Where(e => e.DataEvento >= DateTime.Now && e.Status == Status.Ativo)
                .Include(e => e.EventoImagem)
                .ToList();
        }

        public EventoModel BuscarPorId(int idEvento)
        {
            return _bancoContexto.Eventos.Where(e => e.Id == idEvento).Include(e => e.EventoImagem).FirstOrDefault();
        }

        public void Inserir(EventoModel evento)
        {
            _bancoContexto.Eventos.Add(evento);
            _bancoContexto.SaveChanges();
        }
    }
}
