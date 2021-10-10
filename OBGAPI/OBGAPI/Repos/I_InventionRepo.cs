using System;
using System.Threading.Tasks;
using OBGAPI.DataModels;

namespace OBGAPI.Repos
{

    public interface I_inventionRepo 
    {
        List<Invention> Get();

        List<Invention> Get(string id);

        List<Invention> Get(string cat);


    }

}