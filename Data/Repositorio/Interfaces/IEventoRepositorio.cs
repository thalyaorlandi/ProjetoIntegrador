using ProjetoIntegrador.Models;
using System.Collections.Generic;

namespace ProjetoIntegrador.Data.Repositorio
{
    public interface IEventoRepositorio
    {
        void Inserir(EventoModel evento);
        List<EventoModel> BuscarEventos();
    }
}
