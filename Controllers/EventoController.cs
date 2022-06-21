using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Data.Repositorio;
using ProjetoIntegrador.Models;
using System;
using System.IO;

namespace ProjetoIntegrador.Controllers
{
    public class EventoController : Controller
    {
        private readonly IEventoRepositorio _eventoRepositorio;
        private readonly IEventoImagemRepositorio _eventoImagemRepositorio;

        public EventoController(IEventoRepositorio eventoRepositorio, IEventoImagemRepositorio eventoImagemRepositorio)
        {
            _eventoRepositorio = eventoRepositorio;
            _eventoImagemRepositorio = eventoImagemRepositorio;
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult AdicionarImagem()
        {
            return View();
        }

        public IActionResult GravarImagem(IFormFile file, int idEvento)
        {
            var eventoImagem = new EventoImagemModel();

            eventoImagem.IdEvento = idEvento;
            eventoImagem.Imagem = ConverterImagemEmArray(file);

            _eventoImagemRepositorio.Inserir(eventoImagem);

            return RedirectToAction("Index");
        }

        private string ConverterImagemEmArray(IFormFile file)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                file.CopyTo(stream);
                var array = stream.ToArray();

                string base64 = Convert.ToBase64String(array);
                return base64;
            }
        }

        public IActionResult Detalhes(int idEvento)
        {
            var evento = _eventoRepositorio.BuscarPorId(idEvento);

            return View(evento);
        }

        public IActionResult Index()
        {
            var eventos = _eventoRepositorio.BuscarEventos();
            return View(eventos);
        }

        public IActionResult Inserir(EventoModel evento)
        {
            evento.Status = Status.Ativo;
            evento.DataCadastro = DateTime.Now;

            _eventoRepositorio.Inserir(evento);

            var eventoImagem = new EventoImagemModel();
            eventoImagem.IdEvento = evento.Id;

            return View("AdicionarImagem", eventoImagem);
        }
    }
}
