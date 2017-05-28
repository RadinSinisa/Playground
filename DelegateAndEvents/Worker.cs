using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateAndEvents
{

    //public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e);

    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public virtual void DoWork(int hours, WorkType workType)
        {
            var e = new WorkPerformedEventArgs();
            for (int i = 1; i <= hours; i++)
            {
                Thread.Sleep(2000);
                e.Hours = i;
                e.WorkType = workType;
                OnWorkPerformed(e);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(WorkPerformedEventArgs e)
        {
            WorkPerformed?.Invoke(this, e);
        }

        protected virtual void OnWorkCompleted()
        {
            WorkCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
