using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {        
        public EventoController()
        {            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento []
            {
                new Evento {
                    EventoId = 1, 
                    Tema = "Angular 11 e .Net 5", 
                    Local = "Belo Horizonte", 
                    Lote = "1º Lote", 
                    QauntidadePessoas = "250", 
                    DataEvento = DateTime.Now.add(2).ToString(),
                    ImagemURL = "foto.png"
                },                
                new Evento {
                    EventoId = 1, 
                    Tema = "Angular 11 e .Net 5", 
                    Local = "Belo Horizonte", 
                    Lote = "1º Lote", 
                    QauntidadePessoas = "250", 
                    DataEvento = DateTime.Now.add(2).ToString(),
                    ImagemURL = "foto.png"
                },
            };
        }
    }
}
