using System;
using System.Threading.Tasks;
using OBGAPI.DataModels;

namespace OBGAPI.Repos{

    public interface ISongRepo{

        List<Song> Get();
        List<Song> Get(string artist);
        List<Song> Get(string studio);
    }
}