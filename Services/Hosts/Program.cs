using EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Hosts
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(EmployeeService.EmployeeService)))
            {
                host.Open();
                Console.WriteLine("Employee Service started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
