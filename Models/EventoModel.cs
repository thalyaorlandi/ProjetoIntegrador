using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace ProjetoIntegrador.Models
{
    public class EventoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataEvento { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public TimeSpan HorarioTermino { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int LotacaoMaxima { get; set; }
        public Status Status { get; set; }
        public Categoria Categoria { get; set; }
    }
}
