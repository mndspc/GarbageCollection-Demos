using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To create quickly disposable object
            using (Employee employee = new Employee { EmpCode=100,EmpName="Scott"})
            {
                Console.WriteLine($"Code={employee.EmpCode}\t Name={employee.EmpName}");
            }

           
                Console.ReadLine();
        }
    }
}
