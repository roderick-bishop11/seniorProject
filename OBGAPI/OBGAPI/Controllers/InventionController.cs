using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBGAPI.Repos;
using OBGAPI.DataModels;

namespace OBGAPI.Controllers {

    [Route("api/[controller]")] //creates a route for
    [ApiController]

    public class InventionController : ControllerBase {

        private readonly I_InventionRepo IRepo;

        public InventionController(I_InventionRepo repo){
            this.IRepo = repo;
        }

        //returns a single SONG entity at random
        [HttpGet]
        public Invention Get(){
            return IRepo.Get();
        }

        //returns a single INVENTION entity given the unique id/patentNo.
        [HttpGet]
        public Invention Get(string id){
            return IRepo.Get(id);
        }

        //returns a single INVENTION entity from the category
        [HttpGet]
        public Invention Get(string cat){
            return IRepo.Get(cat);
        }

        // [HttpPost]
        // public void Post([FromBody] Invention invention){
        //     return IRepo.Post(invention);

        // }

    }
}