using EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace Hosts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the service name from the list(Report, Download, Employee, PerCall, PerSession, SinglCall)");
            var service = Console.ReadLine(); 
            if (service.Equals("Report"))
            {
                StartReportService();
            }
            else if (service.Equals("Employee"))
            {
                StartEmployeeService();
            }
            else if (service.Equals("Download"))
            {
                StartDownloadService();
            }
            else if (service.Equals("PerCall"))
            {
                StartPerCallService();
            }else if (service.Equals("PerSession"))
            {
                StartPerSessionService();
            }
            else if (service.Equals("SingleCall"))
            {
                StartSingleCallService();
            }
        }
        static void StartSingleCallService()
        {
            using (ServiceHost host = new ServiceHost(typeof(InstaceModeService.SingleCall)))
            {
                host.Open();
                Console.WriteLine("Singell call Service started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
        static void StartPerSessionService()
        {
            using (ServiceHost host = new ServiceHost(typeof(InstaceModeService.PerSession)))
            {
                host.Open();
                Console.WriteLine("Per Session Service started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
        static void StartPerCallService()
        {
            using (ServiceHost host = new ServiceHost(typeof(InstaceModeService.PerCall)))
            {
                host.Open();
                Console.WriteLine("Per Call Service started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
        static void StartDownloadService()
        {
            using (ServiceHost host = new ServiceHost(typeof(DownloadService.DownloadService)))
            {
                host.Open();
                Console.WriteLine("Download Service started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
        static void StartReportService()
        {

            using (ServiceHost host = new ServiceHost(typeof(ReportService.ReportService)))
            {
                host.Open();
                Console.WriteLine("Report Service started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
        static void StartEmployeeService()
        {

            using (ServiceHost host = new ServiceHost(typeof(EmployeeService.EmployeeService)))
            {
                host.Open();
                Console.WriteLine("Employee Service started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }


        static void Main1(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(EmployeeService.EmployeeService)))
            {
                ServiceMetadataBehavior behavior = new ServiceMetadataBehavior()
                {
                    HttpGetEnabled = true
                };
                host.Description.Behaviors.Add(behavior);
                ContractDescription description = ContractDescription.GetContract(typeof(IPublicEmployeeService));
                description.ContractType = typeof(IPublicEmployeeService);
                ServiceEndpoint endpoint = new ServiceEndpoint(description, new BasicHttpBinding(), new EndpointAddress(new Uri(host.BaseAddresses.First().AbsoluteUri + "/EmployeeService")));
                endpoint.Behaviors.Add(new SoapMessageViewBehavior());
                host.AddServiceEndpoint(endpoint);
                description = ContractDescription.GetContract(typeof(IPrivateEmployeeService));
                endpoint = new ServiceEndpoint(description, new NetTcpBinding(), new EndpointAddress(new Uri(host.BaseAddresses[1].AbsoluteUri + "EmployeeService")));
                endpoint.Behaviors.Add(new SoapMessageViewBehavior());
                host.AddServiceEndpoint(endpoint);
                host.Open();
                Console.WriteLine("Employee Service started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
