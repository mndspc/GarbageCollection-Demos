using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorDemo
{
    internal class Employee:IDisposable
    {
        public int EmpCode { get; set; }

        public string  EmpName { get; set; }
        public Employee()
        {

        }

        //  Destructor also called as Findalize method.
        ~Employee()
        {
            GC.Collect();
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.WriteLine("Destructor Invoked");
        }

        public void Dispose()
        {
           GC.SuppressFinalize(this);
        }
    }
}
