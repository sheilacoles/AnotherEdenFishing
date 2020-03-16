using Sheila.AnotherEdenFishing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheila.AnotherEdenFishing
{
    public class AnotherEdenRepository : IAnotherEdenRepository
    {
        private AnotherEdenFishingDbContext _context;

        public AnotherEdenRepository()
        {
            _context = new AnotherEdenFishingDbContext();
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<Fish> GetAll()
        {
            return _context.Fish;
        }
    }
}
