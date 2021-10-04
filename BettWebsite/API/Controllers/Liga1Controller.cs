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
    public class Liga1Controller : ControllerBase{
        private BettingWebsiteContext context;
        public Liga1Controller(){
            context = new BettingWebsiteContext();
        }
        
        [HttpGet]
        public IEnumerable<Liga1> Get(){
            return context.Liga1s.ToList();
        }

        [HttpPost("insertBett")]
        public async Task<ActionResult<Liga1>> insertBett(Liga1 betts){
            try{
                context.Liga1s.Add(betts);
                await context.SaveChangesAsync();
            }catch(Exception e){
                return new JsonResult(e.Message);
            }
            return new JsonResult("Basti u shtua me sukses");
        }

        [HttpDelete("deleteBett/{id}")]
        public async Task<ActionResult<Liga1>> deleteBett(int id){
            try{
                var bett = await context.Liga1s.FindAsync(id);
                context.Liga1s.Remove(bett);
                await context.SaveChangesAsync();
            }catch(Exception e){
                return new JsonResult(e.Message);
            }
            return new JsonResult("Basti u fshi me sukses");
        }

        [HttpPut("editBett/{id}")]

        public async Task<ActionResult<Liga1>> editBett(int id, Liga1 Liga1){
            try{
                context.Entry(Liga1).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            catch(Exception e){
                return new JsonResult(e.Message);
            }

            return new JsonResult("Editmi perfundoj me sukses");

        }

    }
};