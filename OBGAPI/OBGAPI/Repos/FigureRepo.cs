using System;
using System.Threading.Tasks;
using OBGAPI.DataModels;

namespace OBGAPI.Repos
{

    public class FactRepo : IFactRepo
    {
        //class memebers
        private readonly FigureContext _context;

        //contructor
        public FactRepo(FigureContext context){
            this._context = context;
        }


// These will likely accept a list from the db and at random select a singel one out of the list. 

        public List<Figure> Get(){
        }

        public List<Figure> Get(string field){

        }

        public List<Figure> Get(string city){

        }
    }   
}