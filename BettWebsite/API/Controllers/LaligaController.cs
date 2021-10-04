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
    public class LaligaController : ControllerBase{
        private BettingWebsiteContext context;
        public LaligaController(){
            context = new BettingWebsiteContext();
        }
        
        [HttpGet]
        public IEnumerable<Laliga> Get(){
            return context.Laligas.ToList();
        }

        [HttpPost("insertBett")]
        public async Task<ActionResult<Laliga>> insertBett(Laliga betts){
            try{
                context.Laligas.Add(betts);
                await context.SaveChangesAsync();
            }catch(Exception e){
                return new JsonResult(e.Message);
            }
            return new JsonResult("Basti u shtua me sukses");
        }

        [HttpDelete("deleteBett/{id}")]
        public async Task<ActionResult<Laliga>> deleteBett(int id){
            try{
                var bett = await context.Laligas.FindAsync(id);
                context.Laligas.Remove(bett);
                await context.SaveChangesAsync();
            }catch(Exception e){
                return new JsonResult(e.Message);
            }
            return new JsonResult("Basti u fshi me sukses");
        }

        [HttpPut("editBett/{id}")]

        public async Task<ActionResult<Laliga>> editBett(int id, Laliga laliga){
            try{
                context.Entry(laliga).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            catch(Exception e){
                return new JsonResult(e.Message);
            }

            return new JsonResult("Editmi perfundoj me sukses");

        }

    }
};