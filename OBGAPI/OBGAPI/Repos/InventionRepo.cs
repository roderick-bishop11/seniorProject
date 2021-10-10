using System;
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

        }

        public List<Invention> Get(string id){

        }

        public List<Invention> Get(string cat){

        }





    }
}