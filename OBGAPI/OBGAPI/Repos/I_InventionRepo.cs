using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OBGAPI.DataModels;

namespace OBGAPI.Repos
{

    public interface I_InventionRepo 
    {
        List<Invention> Get();

        List<Invention> GetUsingId(string id);

        List<Invention> GetUsingCategory(int cat);


    }

}