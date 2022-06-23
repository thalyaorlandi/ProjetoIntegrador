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

        public List<EventoModel> BuscarEventos(EventoModel filtroEvento)
        {
            var consulta = _bancoContexto.Eventos
                .Where(e => e.DataEvento >= DateTime.Now && e.Status == Status.Ativo)
                .Include(e =>e.EventoImagem).AsQueryable();

            if(filtroEvento.DataEvento != DateTime.MinValue)
            {
                consulta = consulta.Where(e => e.DataEvento >= filtroEvento.DataEvento);
            }

            if (filtroEvento.DataTermino != DateTime.MinValue)
            {
                consulta = consulta.Where(e => e.DataEvento <= filtroEvento.DataTermino);
            }

            if (!string.IsNullOrWhiteSpace(filtroEvento.Estado))
            {
                consulta = consulta.Where(e => e.Estado.ToUpper() == filtroEvento.Estado.ToUpper());
            }
            if (!string.IsNullOrWhiteSpace(filtroEvento.Nome))
            {
                consulta = consulta.Where(e => EF.Functions.Like(e.Nome, $"%{filtroEvento.Nome}%"));
            }

            return consulta.Include(e => e.EventoImagem).ToList();
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
