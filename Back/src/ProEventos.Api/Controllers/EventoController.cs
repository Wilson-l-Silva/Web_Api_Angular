using Microsoft.AspNetCore.Mvc;

namespace ProEventos.Api.Controllers;

[ApiController]
[Route("api/eventos")]
public class EventoContoller : ControllerBase
{
    public EventoContoller()
    {
        
    }

    [HttpGet]
    public string Get()
    {
       return "Exemplo de Get";
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
