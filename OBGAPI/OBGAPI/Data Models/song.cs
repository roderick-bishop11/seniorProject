using System;
using System.Collections.Generic;

namespace OBGAPI.DataModels
{
    public class Song {

        private int id {get;set;}
        private List<string> artists {get; set;}
        private int year;
        private string name {get; set;}
        private string studio {get; set;}
        private string link  {get; set;}


        public Song(int id, List<string> artists, int year, string name, string studio, string link)
        {
            this.id = id;
            this.artists = artists;
            this.year = year;
            this.name = name;
            this.studio = studio;
            this.link = link;
        }

    }

}