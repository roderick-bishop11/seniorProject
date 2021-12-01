using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBGAPI.Repos;
using OBGAPI.DataModels;

namespace OBGAPI.Controllers{

    public class FigureController : ControllerBase {

        //class variables
        private readonly IFigureRepo figureRep;
        List<Figure> testFigure = new List<Figure>();



        public FigureController(IFigureRepo figureRep){
            this.figureRep = figureRep;
        }

        //returns a single FIGURE entity at random
        [HttpGet]
        public Figure Get(){

            testFigure.add("science", "elbert smith", "this guy did something", new Date(2008, 6, 1, 1, 5, 0), new Date(2016, 9, 8, 4, 7,0), "St. Louis", "000x45sd")
            return figureRep.Get();

        }

        //returns a single FIGURE entity that works in the supplied field 
        [HttpGet]
        public Figure Get(string field){
            return figureRep.Get(field);

        }

        //returns a single FIGURE entity from the supplied city
        [HttpGet]
        public Figure Get(string city){
            return figureRep.Get(city);

        }

        
        // [HttpPost]
        // public Figure Post(Figure figure [FromBody]){
        //     return figureRep.Post(figure);

        // }


    }
}