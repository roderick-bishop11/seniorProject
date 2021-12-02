using System;
using System.Threading.Tasks;
using OBGAPI.DataModels;
using System.Collections.Generic;


namespace OBGAPI.Repos
{

    public class FigureRepo : IFigureRepo
    {
        //class memebers
        private readonly FigureContext _context;

        //contructor
        public FigureRepo(FigureContext context){
            _context = context;
        }


        // These will likely accept a list from the db and at random select a single one out of the list. 

        public List<Figure> Get()
        {
            return new List<Figure>();
        }

        public List<Figure> GetField(string field)
        {
            return new List<Figure>();
        }

        public List<Figure> GetCity(string city)
        {
            return new List<Figure>();


        }
    }   
}