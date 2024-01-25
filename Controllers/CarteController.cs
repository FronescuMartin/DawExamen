using AutoMapper;
using examen.ContextModels;
using examen.Entities;
using examen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace examen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarteController : ControllerBase
    {
        private readonly TestContext _context;
        private readonly IMapper _mapper;
        public CarteController(TestContext Carte, IMapper mapper)
        {
            this._context = Carte;
            this._mapper = mapper;
        }
        [HttpGet("Carti")]
        public async Task<ActionResult<List<GetCarteDTO>>> IndexAsync()
        {
            var carti=_context.Carte.Select(c=>new GetCarteDTO()
            {
                id = c.id,
                titlu = c.titlu
            }).ToList();
            return carti;
        }
        [HttpGet("/{id}")]
        public ActionResult<Carte> Detalii(int id)
        {
            var Carte = _context.Carte.Find(id);
            if (Carte == null)
                return NotFound();
            else
                return Carte;
        }
        [HttpPost]
        public async Task<IActionResult> Post(PostCarteDTO c)
        {
            var carte = new Carte()
            {
                titlu = c.titlu,
            };
            _context.Add(carte);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
