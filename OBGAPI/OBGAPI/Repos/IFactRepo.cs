using System;
using System.Threading.Tasks;
using OBGAPI.DataModels;
namespace OBGAPI.Repos
{
    public interface IFactRepo
    {
        Task<Fact> Get(); //the only thing we want this endpint to do is return a single fact object.

        Task<Fact> Create(Fact fact);

        Task Delete(DateTime date);
    }
}
