using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBGAPI.Repos;
using OBGAPI.DataModels;
using OBGAPI.Service;

namespace OBGAPI.Controllers
{
    [Route("api/[controller]/[action]")] //creates a route for
    [ApiController]
    public class FigureController : ControllerBase {

        //class variables
        private readonly IFigureRepo figureRep;
        List<Figure> testFigure = new List<Figure>();


        public FigureController(IFigureRepo figureRep) {
            this.figureRep = figureRep;
        }

        //returns a single FIGURE entity at random
        [HttpGet]
        public Figure Get() {

            testFigure.Add(new Figure(1, "elbert smith", 1, new DateTime(2008, 6, 1, 1, 5, 0), new DateTime(2016, 9, 8, 4, 7, 0), "St. Louis", "000x45sd"));
            return SelectSingle.singleFigure(figureRep.Get());

        }

        //returns a single FIGURE entity that works in the supplied field 
        [HttpGet("{field}")]
        public Figure GetField(string field){
            return SelectSingle.singleFigure(figureRep.GetField(field));

        }

        //returns a single FIGURE entity from the supplied city
        [HttpGet("{city}")]
        public Figure GetCity(string city){
            return SelectSingle.singleFigure(figureRep.GetCity(city));

        }

        
        // [HttpPost]
        // public Figure Post(Figure figure [FromBody]){
        //     return figureRep.Post(figure);

        // }


    }
}