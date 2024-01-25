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
    public class EdituraController : ControllerBase
    {
        private readonly TestContext _context;
        private readonly IMapper _mapper;
        public EdituraController(TestContext Editura, IMapper mapper)
        {
            this._context = Editura;
            this._mapper = mapper;
        }
        [HttpGet("Editura")]
        public async Task<ActionResult<List<Editura>>> IndexAsync()
        {
            var edituri = _context.Editura.ToList();
            return edituri;
        }
        [HttpGet("by/{id}")]
        public ActionResult<Editura> Detalii(int id)
        {
            var editura = _context.Editura.Find(id);
            if (editura == null)
                return NotFound();
            else
                return editura;
        }
        [HttpPost]
        public async Task<IActionResult> Post(PostEdituraDTO e)
        {
            var editura = new Editura()
            {
                name = e.name,
            };
            _context.Add(editura);
            await _context.SaveChangesAsync();
            //var stire = (await _repository.PostStireAsync(_mapper.Map<Stire>(s)));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Put(int id, PostEdituraDTO editura)
        {
            if (editura == null || id == 0)
                return BadRequest();

            var _editura = await _context.Editura.FirstOrDefaultAsync(e => e.id == id);
            if (_editura == null)
                return NotFound();
            _editura.name = editura.name;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
