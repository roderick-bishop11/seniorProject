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

        private readonly ISongRepo songRepo;

        public InventionController(ISongRepo songRepo){
            this.songRepo = songRepo;
        }

        //returns a single SONG entity at random
        [HttpGet]
        public Song Get(){
            return songRepo.Get();
        }

        //returns a single SONG entity given the unique id.
        [HttpGet]
        public Song Get(string id){
            return songRepo.Get(id);
        }

        //returns a single SONG entity from the category
        [HttpGet]
        public Song Get(string cat){
            return songRepo.Get(cat);
        }

        // [HttpPost]
        // public void Post([FromBody] Song song){
        //     return figureRep.Post(song);

        // }

    }
}