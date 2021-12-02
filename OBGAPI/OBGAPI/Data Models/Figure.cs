using System;
using OBGAPI.Enums;
using OBGAPI.Service;


namespace OBGAPI.DataModels
{
    public class Figure
    {

        //class members
        private int id { get; set; }
        private string name { get; set; }
        private Category category { get; set; }
        private DateTime birthDate { get; set; }
        private DateTime deathDate { get; set; }
        private string bio { get; set; }
        private string city { get; set; }


        //constructor
        public Figure(int id, string name, int temp, DateTime birthDate, DateTime deathDate, string bio, string city)
        {
            this.id = id;
            this.name = name;
            this.category = SelectCategory.categorySelector(temp);
            this.birthDate = birthDate;
            this.deathDate = deathDate;
            this.bio = bio;
            this.city = city;
        }

    }

}