using System.Collections.Generic;
using OBGAPI.Enums;
namespace OBGAPI.DataModels
{
    public class Invention
    {
        private int id;
        private string patentId;
        private string inventionName;
        private string desc;
        private Category category;
        private List<Figure> inventors;

        public Invention(int id, string patentId, string inventionName, string desc, Category category, List<Figure> inventors)
        {
            this.id = id;
            this.patentId = patentId;
            this.inventionName = inventionName;
            this.desc = desc;
            this.category = category;
            this.inventors = inventors;
        }
    }
 


}