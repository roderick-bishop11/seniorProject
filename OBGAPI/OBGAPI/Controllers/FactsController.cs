using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBGAPI.Repos;
using OBGAPI.DataModels;
using OBGAPI.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OBGAPI.Controllers
{
    [Route("api/[controller]")] //creates a route for
    [ApiController]
    public class FactsController : Controller

    {
        private readonly IFactRepo factRepo;
        List<Fact> testFacts = new List<Fact>();
     
      

        public FactsController(IFactRepo factRepo)
            
        {
            Console.WriteLine("\n\n\nRan the constructor\n\n\n");
            this.factRepo = factRepo;
        }

        public FactsController()

        {
            Console.WriteLine("\n\n\nRan the constructor\n\n\n");
            testFacts.Add(new Fact(DateTime.Today, "Something", "https://www.fs.fed.us/people/aasg/calendar/timeline.html"));
            testFacts.Add(new Fact(DateTime.Today, "Whoopty doo", "https://www.fs.fed.us/people/aasg/calendar/timeline.html"));

        }

        // //returns a single FACT entity at random
        // [HttpGet]
        // public async Task<ActionResult<Fact>> Get()
        // {

        //     return await factRepo.Get();
        // }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            Console.WriteLine("Ran the get method");
            //return testFacts;
            return new string[] { "hello", "world" };
        }



        //[HttpGet]
        //public Fact GetSingle(){
        //    return SelectSingle.singleFact(testFacts);
        //}


        //[HttpPost]
        //public async Task<ActionResult<Fact>> Post([FromBody]Fact fact)
        //{
        //    var newFact = await factRepo.Create(fact);
        //    return CreatedAtAction(nameof(Get), newFact);

        //}
    }
}
