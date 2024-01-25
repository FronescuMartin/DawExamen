using AutoMapper;
using examen.ContextModels;
using examen.Entities;
using examen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace examen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly TestContext _context;
        private readonly IMapper _mapper;
        public AutorController(TestContext Autor, IMapper mapper)
        {
            this._context = Autor;
            this._mapper = mapper;
        }
        [HttpGet("Autori")]
        public async Task<ActionResult<List<Autor>>> IndexAsync()
        {
            var autori = _context.Autor.ToList();
            return autori;
        }
        [HttpGet("{id}")]
        public ActionResult<Autor> Detalii(int id)
        {
            var autor = _context.Autor.Find(id);
            if (autor == null)
                return NotFound();
            else
                return autor;
        }
        [HttpPost]
        public async Task<IActionResult> Post(PostAutorDTO a)
        {
            var autor = new Autor()
            {
                name = a.name,
                editura_id = a.editura_id
            };
            _context.Add(autor);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, PostAutorDTO autor)
        {
            if (autor == null || id == 0)
                return BadRequest();

            var _autor = await _context.Autor.FirstOrDefaultAsync(a => a.id == id);
            if (_autor == null)
                return NotFound();
            _autor.name = autor.name;
            _autor.editura_id = autor.editura_id;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
