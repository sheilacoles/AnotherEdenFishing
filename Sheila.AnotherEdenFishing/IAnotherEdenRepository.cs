using Sheila.AnotherEdenFishing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheila.AnotherEdenFishing
{
    public interface IAnotherEdenRepository
    { 
        void Add<T>(T entity) where T : class; 

        IEnumerable<Fish> GetAll();
    }
}
