using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OBGAPI.DataModels;

namespace OBGAPI.Repos{

    public interface ISongRepo{

        List<Song> Get();
        List<Song> GetUsingArtist(string artist);
        List<Song> GetUsingStudio(string studio);
    }
}