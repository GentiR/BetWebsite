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
    public class SeriaAController : ControllerBase{

        private BettingWebsiteContext context;
        public SeriaAController(){
            context = new BettingWebsiteContext();
        }
        
        [HttpGet]
        public IEnumerable<SeriaA> Get(){
            return context.SeriaAs.ToList();
        }

        [HttpPost("insertBett")]
        public async Task<ActionResult<SeriaA>> insertBett(SeriaA betts){
            try{
                context.SeriaAs.Add(betts);
                await context.SaveChangesAsync();
            }catch(Exception e){
                return new JsonResult(e.Message);
            }
            return new JsonResult("Basti u shtua me sukses");
        }

        [HttpDelete("deleteBett/{id}")]
        public async Task<ActionResult<SeriaA>> deleteBett(int id){
            try{
                var bett = await context.SeriaAs.FindAsync(id);
                context.SeriaAs.Remove(bett);
                await context.SaveChangesAsync();
            }catch(Exception e){
                return new JsonResult(e.Message);
            }
            return new JsonResult("Basti u fshi me sukses");
        }

        [HttpPut("editBett/{id}")]

        public async Task<ActionResult<SeriaA>> editBett(int id, SeriaA seriaA){
            try{
                context.Entry(seriaA).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            catch(Exception e){
                return new JsonResult(e.Message);
            }

            return new JsonResult("Editmi perfundoj me sukses");

        }

    }
};