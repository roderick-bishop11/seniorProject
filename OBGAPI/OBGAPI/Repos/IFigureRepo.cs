using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OBGAPI.DataModels;

namespace OBGAPI.Repos
{
    public interface IFigureRepo
    {
        List<Figure> Get();
        List<Figure> GetField(string field);
        List<Figure> GetCity(string city);

    }
}