using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public delegate int BizRulesDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer{ City = "Phoenix", FirstName = "John", LastName = "Doe", ID = 1},
                new Customer{ City = "Phoenis", FirstName = "Jane", LastName = "Doe", ID = 500},
                new Customer{ City = "Seatle", FirstName = "Suki", LastName = "Pizzoro", ID = 3},
                new Customer{ City = "New York City", FirstName = "Michelle", LastName = "Smith", ID = 4},
            };

            var phxCus = customers.Where(x => x.City == "Phoenix");




            var data = new ProcessData();
            data.Process(2, 3, (x, y) => x + y);

            Action<int, int> myAction = (x, y) => { Console.WriteLine(x + y); };
            data.ProcessAction(12, 3, myAction);

            var worker = new Worker();

            worker.WorkCompleted += Worker_WorkCompleted;
            //worker.WorkPerformed += Worker_WorkPerformed;
            worker.WorkPerformed += (s, e) => { Console.WriteLine($"{e.WorkType} for hours {e.Hours}"); };
            worker.DoWork(5, WorkType.DoCode);

            worker.WorkCompleted -= Worker_WorkCompleted;
            //worker.WorkPerformed -= Worker_WorkPerformed;
            //var del1 = new WorkPerformedHandler(WorkPerformed1);
            //var del2 = new WorkPerformedHandler(WorkPerformed2);

            ////del1(5, WorkType.DoCode);
            ////del2(3, WorkType.WriteDocumentations);
            //del1 += del2;

            //var finalHours = del1(4, WorkType.DoCode);
            //Console.WriteLine($"{finalHours}");
            ////DoWork(del1);

            Console.Read();
        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"{e.WorkType} for hours {e.Hours}");
        }

        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work completed");
        }

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.DoCode);
        //}

        //static int WorkPerformed1(int h, WorkType wt)
        //{
        //    Console.WriteLine($"WorkPerformed1 called {h} {wt}");
        //    return h + 1;
        //}

        //static int WorkPerformed2(int h, WorkType wt)
        //{
        //    Console.WriteLine($"WorkPerformed2 called {h} {wt}");
        //    return h + 2;
        //}
    }
}
