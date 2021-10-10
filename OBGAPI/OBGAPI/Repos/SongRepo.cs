using System;
using OBGAPI.DataModels;

namespace OBGAPI.Repos{

    public class SongRepo : ISongRepo{

        private readonly SongContext _context;

        public SongRepo(SongContext cont){
            this._context = cont;
        }


        public List<Song> Get(){

        }

        public List<Song> Get(string artist){

        }

        
        public List<Song> Get(string studio){

        }
    }
}
