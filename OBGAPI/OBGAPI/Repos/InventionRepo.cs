using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OBGAPI.DataModels;

namespace OBGAPI.Repos
{

    public class InventionRepo : I_InventionRepo
    {
        private readonly InventionContext _context; //db context

        public InventionRepo(InventionContext context){
            this._context = context;
        }

        
        public List<Invention> Get(){
            return new List<Invention>();
        }

        public List<Invention> GetUsingId(string id){
            return new List<Invention>();
        }

        public List<Invention> GetUsingCategory(int cat){
            return new List<Invention>();

        }





    }
}