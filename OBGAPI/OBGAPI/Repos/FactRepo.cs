using System;
using System.Threading.Tasks;
using OBGAPI.DataModels;

namespace OBGAPI.Repos
{
    public class FactRepo : IFactRepo
    {
        private readonly FactContext _context;  //db context

        //injects the context into the constructor
        public FactRepo(FactContext context)
        {
            _context = context;
        }

        public async Task<Fact> Create(Fact fact)
        {

            _context.Add(fact);
            await _context.SaveChangesAsync();

            return fact;

        }

        //Deletes a fact that is found on a specific date. 
        public async Task Delete(DateTime date)
        {
            var selectedFact = await _context.Facts.FindAsync(date);
            _context.Facts.Remove(selectedFact);
            await _context.SaveChangesAsync();

        }

        //returns fact of the day. 
        public async Task<Fact> Get()
        {
            var date = DateTime.Today;

            return await _context.Facts.FindAsync(date);
        }
    }
}
