using System;
using System.Collections.Generic;
using OBGAPI.DataModels;

namespace OBGAPI.Repos{

    public class SongRepo : ISongRepo{

        private readonly SongContext cont;

        public SongRepo(SongContext context){
            this.cont = context;
        }


        public List<Song> Get()
        {
            return new List<Song>();

        }

        public List<Song> GetUsingArtist(string artist)
        {
            return new List<Song>();

        }


        public List<Song> GetUsingStudio(string studio)
        {
            return new List<Song>();

        }
    }
}
