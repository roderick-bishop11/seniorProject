using System;
using OBGAPI.DataModels;

namespace OBGAPI.Repos{

    public class SongRepo : ISongRepo{

        private readonly SongContext cont;

        public SongRepo(SongContext context){
            this.cont = context;
        }


        public List<Song> Get(){

        }

        public List<Song> Get(string artist){

        }

        
        public List<Song> Get(string studio){

        }
    }
}
