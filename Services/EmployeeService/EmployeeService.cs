using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    [GlobalErrorHandlerBehaviour(typeof(GlobalErrorHandler))]
    public class EmployeeService : IPrivateEmployeeService
    {
        private static List<Employee> Employees { get; set; }

        public EmployeeService()
        {
            Employees = CreateEmployees();
        }

        private List<Employee> CreateEmployees()
        {
            return new List<Employee>()
            {
                new PermanantEmployee { Id=1, Name="Nilesh Gokhale", DateOfBirth=DateTime.Parse("10/03/1978"), Gender="Male", Type= EmployeeType.PermanantEmployee },
                new ContractEmployee { Id=2, Name="Priti Gokhale", DateOfBirth=DateTime.Parse("10/03/1980"), Gender="Female", Type= EmployeeType.ContractEmployye },
            };
        }

        public Employee GetEmployee(int id)
        {
           
            var emp = Employees.Where(x => x.Id == id).FirstOrDefault();
            if (emp == null) throw new FaultException("Not found");
            return emp;
        }

        public List<Employee> GetEmployees(EmployeeType type)
        {
            var emplst = Employees.Where(x => x.Type == type).ToList();
            if (!emplst.Any()) throw new FaultException("No employees with specified type found");
            return emplst;
        }

        public void SaveEmployee(Employee emp)
        {
            if (emp == null) throw new FaultException("Employee cannot be null");
            var maxId = Employees.Max(x => x.Id);
            emp.Id = maxId + 1;

            Employees.Add(emp);
        }

        public void OnewayOperation_throwsExpcetion()
        {
            throw new NotImplementedException();
        }

        public void OneWayOperation()
        {
            Thread.Sleep(2000);
            return;
        }

        public string RequestReply()
        {
            Thread.Sleep(3000);
            return "Complete";
        }
    }

    public class EmployeeMessageInspector : IDispatchMessageInspector
    {
        public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            if (request != null)
            {
                MessageBuffer buffer = request.CreateBufferedCopy(Int32.MaxValue);
                var msgCopy = buffer.CreateMessage();
                request = buffer.CreateMessage();
                var strData = buffer.CreateMessage().ToString();

                var xmlDAta = msgCopy.GetReaderAtBodyContents();
                var bodyData = xmlDAta.ReadOuterXml();
                strData = strData.Replace("... stream ...", bodyData);
                Console.WriteLine("Received:\n{0}\n", strData);
            }
            return null;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
            if (reply != null)
            {
                MessageBuffer buffer = reply.CreateBufferedCopy(Int32.MaxValue);
                var msgCopy = buffer.CreateMessage();
                reply = buffer.CreateMessage();
                var strData = buffer.CreateMessage().ToString();

                Console.WriteLine("Sent:\n{0}\n", strData);
            }
        }
    }

    public class SoapMessageViewBehavior : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {

        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {

        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            EmployeeMessageInspector inspector = new EmployeeMessageInspector();
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(inspector);
        }

        public void Validate(ServiceEndpoint endpoint)
        {

        }
    }

    public class SoapMessageViewBehaviorConfigurationSection : BehaviorExtensionElement, IServiceBehavior
    {
        public override Type BehaviorType
        {
            get
            {
                return typeof(SoapMessageViewBehavior);
            }
        }

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }

        protected override object CreateBehavior()
        {
            return new SoapMessageViewBehavior();
        }

    }
}
