using Microsoft.AspNetCore.Mvc;
using ProEventos.Api.Models;

namespace ProEventos.Api.Controllers;

[ApiController]
[Route("api/eventos")]
public class EventoContoller : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]
       {
           new Evento()
           {
           EventoId = 1,
           Tema = "Angular 11 e .NET 5",
           Local = "Belo Horizonte",
           Lote = "1 Lote",
           QtdPessoas = 250,
           DataEvento = DateTime.Now.AddDays(2).ToString(),
           ImagemURL = "imagem.png",
           },

           new Evento()
           {
           EventoId = 2,
           Tema = "Angular 11 e .NET 5",
           Local = "São Paulo",
           Lote = "2 Lote",
           QtdPessoas = 350,
           DataEvento = DateTime.Now.AddDays(3).ToString(),
           ImagemURL = "imagem.png",
           }
       };
    public EventoContoller()
    {
        
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return _evento;
       
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete com id = {id}";
    }
}
