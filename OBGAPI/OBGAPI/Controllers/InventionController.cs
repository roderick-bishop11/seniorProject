using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBGAPI.Repos;
using OBGAPI.DataModels;
using OBGAPI.Service;

namespace OBGAPI.Controllers {

    [Route("api/[controller]/[action]")] //creates a route for
    [ApiController]

    public class InventionController : ControllerBase {

        private readonly I_InventionRepo IRepo;

        public InventionController(I_InventionRepo repo) {
            this.IRepo = repo;
        }

        //returns a single SONG entity at random
        [HttpGet]
        public Invention Get() {
            return SelectSingle.singleInv(IRepo.Get());
        }

        //returns a single INVENTION entity given the unique id/patentNo.
        [HttpGet("{id}")]
        public Invention Get(string id) {
            return SelectSingle.singleInv(IRepo.GetUsingId(id));
        }

        //returns a single INVENTION entity from the category
        [HttpGet("{cat}")]
        public Invention Get(int cat){
            return SelectSingle.singleInv(IRepo.GetUsingCategory(cat));
        }

        // [HttpPost]
        // public void Post([FromBody] Invention invention){
        //     return IRepo.Post(invention);

        // }

    }
}