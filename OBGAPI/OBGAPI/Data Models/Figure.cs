using System;
using OBGAPI.Enums;


namespace OBGAPI.DataModels
{
    public class Figure
    {
        private int id { get; set; }
        private string name { get; set; }
        private Category category { get; set; }
        private DateTime birthDate { get; set; }
        private DateTime deathDate { get; set; }
        private string bio { get; set; }
        private string city { get; set; }



        public Figure(int id, string name, Category category, DateTime birthDate, DateTime deathDate, string bio, string city)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.birthDate = birthDate;
            this.deathDate = deathDate;
            this.bio = bio;
            this.city = city;
        }
    }

}