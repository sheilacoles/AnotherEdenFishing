using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheila.AnotherEdenFishing.Models
{
    public class Pond:BaseModel
    {
        public IEnumerable<Fish> Fish { get; set; }
    }
}
