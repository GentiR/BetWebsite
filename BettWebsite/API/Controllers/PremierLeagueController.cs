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
    public class PremierLeagueController : ControllerBase{
        private BettingWebsiteContext context;
        public PremierLeagueController(){
            context = new BettingWebsiteContext();
        }
        
        [HttpGet]
        public IEnumerable<PremierLeague> Get(){
            return context.PremierLeagues.ToList();
        }

        [HttpPost("insertBett")]
        public async Task<ActionResult<PremierLeague>> insertBett(PremierLeague betts){
            try{
                context.PremierLeagues.Add(betts);
                await context.SaveChangesAsync();
            }catch(Exception e){
                return new JsonResult(e.Message);
            }
            return new JsonResult("Basti u shtua me sukses");
        }

        [HttpDelete("deleteBett/{id}")]
        public async Task<ActionResult<PremierLeague>> deleteBett(int id){
            try{
                var bett = await context.PremierLeagues.FindAsync(id);
                context.PremierLeagues.Remove(bett);
                await context.SaveChangesAsync();
            }catch(Exception e){
                return new JsonResult(e.Message);
            }
            return new JsonResult("Basti u fshi me sukses");
        }

        [HttpPut("editBett/{id}")]

        public async Task<ActionResult<PremierLeague>> editBett(int id, PremierLeague premierLeague){
            try{
                context.Entry(premierLeague).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            catch(Exception e){
                return new JsonResult(e.Message);
            }

            return new JsonResult("Editmi perfundoj me sukses");

        }

    }
};