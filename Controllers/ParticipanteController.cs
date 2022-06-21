using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Data.Repositorio;
using ProjetoIntegrador.Models;
using System;

namespace ProjetoIntegrador.Controllers
{
    public class ParticipanteController : Controller
    {
        private readonly IParticipanteRepositorio _participanteRepositorio;
        private readonly IParticipanteEventoRepositorio _participanteEventoRepositorio;

        public ParticipanteController(IParticipanteRepositorio participanteRepositorio, IParticipanteEventoRepositorio participanteEventoRepositorio)
        {
            _participanteRepositorio = participanteRepositorio;
            _participanteEventoRepositorio = participanteEventoRepositorio;
        }

        public IActionResult Inscrever(int idEvento)
        {
            return View(idEvento);
        }

        public IActionResult Gravar(ParticipanteModel participante, int idEvento)
        {
            _participanteRepositorio.Inserir(participante);

            var participanteEvento = new ParticipanteEventoModel();
            participanteEvento.DataCadastro = DateTime.Now;
            participanteEvento.IdEvento = idEvento;
            participanteEvento.IdParticipante = participante.Id;

            _participanteEventoRepositorio.Inserir(participanteEvento);

            return View("Cadastrado");
        }
    }
}
