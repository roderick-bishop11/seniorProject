using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBGAPI.Repos;
using OBGAPI.DataModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OBGAPI.Controllers
{
    [Route("api/[controller]")] //creates a route for
    [ApiController]
    public class FactsController : ControllerBase

    {
        private readonly IFactRepo factRepo;


        public FactsController(IFactRepo factRepo)
        {
            this.factRepo = factRepo;
        }
        
  
        // GET api/fact -> will return the fact of the day. 
        [HttpGet]
        public async Task<ActionResult<Fact>> Get()
        {

            return await factRepo.Get();
        }

        [HttpPost]
        public async Task<ActionResult<Fact>> Post([FromBody]Fact fact)
        {
            var newFact = await factRepo.Create(fact);
            return CreatedAtAction(nameof(Get), newFact);

        }
    }
}
