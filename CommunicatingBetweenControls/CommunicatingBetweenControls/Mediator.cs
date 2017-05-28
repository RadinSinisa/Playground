using CommunicatingBetweenControls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicatingBetweenControls
{
    public sealed class Mediator
    {
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { }
        
        public static Mediator GetInstance()
        {
            return _Instance;
        }

        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChainged(object sender, Job job)
        {
            JobChanged?.Invoke(sender, new JobChangedEventArgs() { Job = job });
        }
    }
}
