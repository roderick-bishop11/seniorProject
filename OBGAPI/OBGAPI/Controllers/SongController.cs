using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBGAPI.Repos;
using OBGAPI.DataModels;
using OBGAPI.Service;

namespace OBGAPI.Controllers {
    
    [Route("api/[controller]/[action]")] //should be api/song
    [ApiController]
    public class SongController: ControllerBase {

            private readonly ISongRepo songRepo;
        List<Song> testSong = new List<Song>();

            public SongController( ISongRepo songRepo){
            this.songRepo = songRepo;
            }

            //returns a single SONG entity at random
            [HttpGet]
            public Song Get (){

            testSong.Add(new Song(1, new List<string> {"Usher", "T-pain"}, 2007, "elbert smith", "LA", "link"));
                return SelectSingle.singleSong(songRepo.Get());
            }
            

            //returns a single SONG entity by an artist
            [HttpGet("{artist}")]
            public Song GetUsingArtist(string artist){

                //since our repo is set to query and get back a list, we're gonna select a single using our service.
                return SelectSingle.singleSong(songRepo.GetUsingArtist(artist));
            }

            //returns a single SONG entity that comes from a studio
            [HttpGet("{studio}")]
            public Song GetUsingStutio(string studio){
                return SelectSingle.singleSong(songRepo.GetUsingStudio(studio));
            }
            

            // [HttpPost]
            // public Song Post (Song song [FromBody]){
            //     return songRepo.Post()
            // }

        
    }
}
