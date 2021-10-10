using System;
using System.Threading.Tasks;
using OBGAPI.DataModels;

namespace OBGAPI.Repos
{
    public interface IFigureRepo
    {
        List<Figure> Get();
        List<Figure> Get(string field);
        List<Figure> Get(string city);

    }
}