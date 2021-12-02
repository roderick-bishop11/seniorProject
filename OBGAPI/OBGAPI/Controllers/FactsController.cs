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
    public class FactsController : ControllerBase

    {
        private readonly IFactRepo factRepo;
        List<Fact> testFacts = new List<Fact>
        {
            new Fact(DateTime.Today, "October 7. Toni Morrison was the first black American to win the Nobel Prize in Literature.", "https://www.fs.fed.us/people/aasg/calendar/timeline.html"),
            new Fact(DateTime.Today, "Something", "https://www.fs.fed.us/people/aasg/calendar/timeline.html"),
            new Fact(DateTime.Today, "Whoopty doo", "https://www.fs.fed.us/people/aasg/calendar/timeline.html")


    }; //testing


        public FactsController(IFactRepo factRepo)
            
        {
            Console.WriteLine("\n\n\nRan the constructor\n\n\n");
            this.factRepo = factRepo;

        }


        // //returns a single FACT entity at random
        // [HttpGet]
        // public async Task<ActionResult<Fact>> Get()
        // {

        //     return await factRepo.Get();
        // }

        [HttpGet]
        public List<Fact> Get(){
            Console.WriteLine("Ran the get method");
            return new List<Fact>
        {
            new Fact(DateTime.Today, "October 7. Toni Morrison was the first black American to win the Nobel Prize in Literature.", "https://www.fs.fed.us/people/aasg/calendar/timeline.html"),
            new Fact(DateTime.Today, "Something", "https://www.fs.fed.us/people/aasg/calendar/timeline.html"),
            new Fact(DateTime.Today, "Whoopty doo", "https://www.fs.fed.us/people/aasg/calendar/timeline.html")};
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
