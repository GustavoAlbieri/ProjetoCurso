using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get() 
        {
            return new Evento[] {
                new Evento() {
                    EventoID = 1,
                    Local = "Irapuã",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Tema = "Terror",
                    NumeroPessoas = 25,
                    Lote = "1 - Lote",
                    ImagemURL = "Foto.png"
                },
                new Evento() {
                    EventoID = 2,
                    Local = "Sales",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Tema = "Animation",
                    NumeroPessoas = 264,
                    Lote = "1 - Lote",
                    ImagemURL = "Fotos.png"
                },
                new Evento() {
                    EventoID = 3,
                    Local = "Urupes",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Tema = "Testeeer",
                    NumeroPessoas = 64,
                    Lote = "4 - Lote",
                    ImagemURL = "Tester.png"
                }
            };
        }

        [HttpPost]
        public string Post() => "EXEMPLO DE POST";
    }
}
