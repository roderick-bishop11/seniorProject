using System;
namespace OBGAPI.DataModels
{
    public class Fact
    {
      public DateTime date { get; set; } //need to find some proper formats for this
        public string fact { get; set; }
        public string link { get; set; }
        //public something image { get; set; }

        public Fact(DateTime date, string fact, string link){
          this.date = date;
          this.fact = fact;
          this.link = link;
        }
    }
}
