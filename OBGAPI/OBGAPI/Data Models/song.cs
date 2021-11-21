using System;
using System.Collections.Generic;

namespace OBGAPI.DataModels
{
    public class Song {

        private string id {get;set;}
        private List<string> artists {get; set;}
        private DateTime year { get; set; }
        private string name { get; set; }
        private string studio { get; set; }
    }
}