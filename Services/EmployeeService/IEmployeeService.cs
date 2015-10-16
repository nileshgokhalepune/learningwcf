using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.

    [ServiceContract]
    public interface IPublicEmployeeService
    {
        [OperationContract(Name = "Get")]
        Employee GetEmployee(int id);
    }
    [ServiceContract]
    public interface IPrivateEmployeeService : IPublicEmployeeService
    {
        [OperationContract]
        void SaveEmployee(Employee emp);
        [OperationContract]
        List<Employee> GetEmployees(EmployeeType type);
    }

}
