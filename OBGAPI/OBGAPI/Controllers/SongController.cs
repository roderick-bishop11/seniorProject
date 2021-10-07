using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBGAPI.Repos;
using OBGAPI.DataModels;

namespace OBGAPI.Controllers {
    
    [Route("api/[controller]")] //should be api/song
    [ApiController]
    public class SongController: ControllerBase {

            private readonly songRepo ISongRepo

            public SongController( ISongRepo songRepo){
                this. songRepo = songRepo
            }

            //returns a single SONG entity at random
            [HttpGet]
            public Song Get (){
                return songRepo.Get();
            }
            

            //returns a single SONG entity by an artist
            [HttpGet]
            public Song Get (string artist){
                return songRepo.GetUsingArtist(artist);
            }

            //returns a single SONG entity that comes from a studio
            [HttpGet]
            public Song Get (string studio){
                return songRepo.GetUsingStudio(studio);
            }
            

            // [HttpPost]
            // public Song Post (Song song [FromBody]){
            //     return songRepo.Post()
            // }

        
    }
}
