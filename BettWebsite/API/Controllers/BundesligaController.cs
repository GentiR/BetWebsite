using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BundesligaController : ControllerBase{
        private BettingWebsiteContext context;
        public BundesligaController(){
            context = new BettingWebsiteContext();
        }
        
        [HttpGet]
        public IEnumerable<Bundesliga> Get(){
            return context.Bundesligas.ToList();
        }

        [HttpPost("insertBett")]
        public async Task<ActionResult<Bundesliga>> insertBett(Bundesliga betts){
            try{
                context.Bundesligas.Add(betts);
                await context.SaveChangesAsync();
            }catch(Exception e){
                return new JsonResult(e.Message);
            }
            return new JsonResult("Basti u shtua me sukses");
        }

        [HttpDelete("deleteBett/{id}")]
        public async Task<ActionResult<Bundesliga>> deleteBett(int id){
            try{
                var bett = await context.Bundesligas.FindAsync(id);
                context.Bundesligas.Remove(bett);
                await context.SaveChangesAsync();
            }catch(Exception e){
                return new JsonResult(e.Message);
            }
            return new JsonResult("Basti u fshi me sukses");
        }

        [HttpPut("editBett/{id}")]

        public async Task<ActionResult<Bundesliga>> editBett(int id, Bundesliga bundesliga){
            try{
                context.Entry(bundesliga).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            catch(Exception e){
                return new JsonResult(e.Message);
            }

            return new JsonResult("Editmi perfundoj me sukses");

        }

    }
};