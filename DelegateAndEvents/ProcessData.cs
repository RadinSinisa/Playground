using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public class ProcessData
    {
        public int Process(int x, int y, BizRulesDelegate del)
        {
            var result =  del(x, y);
            Console.WriteLine(result);
            return result;
        }

        public void ProcessAction(int x, int y, Action<int,int> action)
        {
            action(x, y);
        }
    }
}
