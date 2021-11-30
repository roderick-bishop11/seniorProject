using systems;
using System.DateTime;


namespace OBGAPI.DataModels{

    public class Figure {

        private string category {get;set;}
        private string name {get; set;}
        private string bio {get; set;}
        private DateTime.Date birth {get; set}
        private DateTime.Date death {get; set}
        private string city {get; set;} 
        private string id {get; set;} 
    }

}