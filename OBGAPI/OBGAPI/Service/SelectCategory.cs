using System;
using OBGAPI.Enums;
namespace OBGAPI.Service
{
    public class SelectCategory
    {
       
       
        public static Category categorySelector(int category)
        {

            switch (category)
            {
                case 1:
                    return Category.Science;
                case 2:
                    return Category.Literature;
                case 4:
                    return Category.Politics;
                case 5:
                    return Category.Art;
                case 6:
                    return Category.Music;
                case 7:
                    return Category.Education;
                case 8:
                    return Category.Civil_Rights;
                case 9:
                    return Category.Math;
                case 10:
                    return Category.Technology;
                case 11:
                    return Category.Medicine;
                case 12:
                    return Category.Philosophy;
                case 13:
                    return Category.Philanthropy;
                case 14:
                    return Category.Sports;
                case 15:
                    return Category.Entertainment;

                default:
                    return Category.other;

            }

        }



    }
}
