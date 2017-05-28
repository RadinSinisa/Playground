using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBuilder
{
    public class Builder
    {
        //TODO Igrati se sa groupBy

        public IEnumerable<int> BuilderIntegerSequence()
        {
            var integers = Enumerable.Range(0, 10);
            return integers;
        }
    }
}
