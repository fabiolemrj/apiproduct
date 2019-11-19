using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using musicmanager.Data;
using musicmanager.Models;
using System.Linq;
using musicmanager.Enums;
using System;

namespace musicmanager.Controllers
{
      [ApiController]
    [Route("v1/musics")]
    public class MusicController:ControllerBase
    {
        private DataContext _context;

        public MusicController(DataContext context)
        {
            _context = context;
        }
    [HttpGet]
        [Route("str")]
   public ActionResult<string> Getstring ()
        {
            var str = "teste";
         return  str;
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Music>>> Get([FromServices] DataContext context)
        {
            var categories = await context.Musics.ToListAsync();
            return categories;
        }

        [HttpGet]
        [Route("{genre:int}")]
        public async Task<ActionResult<List<Music>>> GetByCaGenre([FromServices] DataContext context, int genre)
        {
            var products = await context.Musics
                        .AsNoTracking()
            .Where(x=>x.Genre == (ETypeGenreMusic)genre)
            .ToListAsync();
            return products;
        }

        [HttpGet]
        [Route("{name:string}")]
        public async Task<ActionResult<List<Music>>> GetByName([FromServices] DataContext context, string name)
        {
            var musics = await context.Musics
                        .AsNoTracking()
            .Where(x=>x.Name.Contains(name))
            .ToListAsync();
            return musics;
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<ActionResult<Music>> GetById([FromServices] DataContext context, Guid id)
        {
            var music = await context.Musics
            .AsNoTracking()            
            .FirstOrDefaultAsync(x=>x.Id==id);
            return music;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Music>> Post([FromServices] DataContext context, [FromBody]Music model){
           if(ModelState.IsValid){
               context.Musics.Add(model);
               await context.SaveChangesAsync();
               return model;
           } else{
               return BadRequest(ModelState);
           }

        }
        
    }
}