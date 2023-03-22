using System;
namespace OBGAPI.DataModels
{
    public class Fact
    {
        public DateTime date { get; set; }
        public string fact { get; set; }
        public string link { get; set; }

        public Fact(DateTime date, string fact, string link){
          this.date = date;
          this.fact = fact;
          this.link = link;
        }
    }
}
