using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    public enum EmployeeType
    {
        PermanantEmployee,
        ContractEmployye
    }

    [MessageContract]
    public class EmployeeRequest
    {
        [MessageHeader]
        public int Id { get; set; }
    }

    [MessageContract]
    public class EmployeeInfo
    {
        [MessageBodyMember]
        public int Id { get; set; }
        [MessageBodyMember]
        public string Name { get; set; }
        [MessageBodyMember]
        public string Gender { get; set; }
        [MessageBodyMember]
        public DateTime DateOfBirt { get; set; }
        [MessageBodyMember]
        public EmployeeType Type { get; set; }

    }

    [DataContract]
    [KnownType(typeof(PermanantEmployee))]
    [KnownType(typeof(ContractEmployee))]
    public abstract class Employee
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string Gender { get; set; }
        [DataMember(Order = 4)]
        public DateTime DateOfBirth { get; set; }
        [DataMember(Order = 5)]
        public EmployeeType Type { get; set; }
    }

    [DataContract]
    public class PermanantEmployee : Employee
    {
        [DataMember(Order = 1)]
        public int AnnualSalary { get; set; }
    }

    [DataContract]
    public class ContractEmployee : Employee
    {
        [DataMember(Order = 1)]
        public int HourlyWage { get; set; }
        [DataMember(Order = 2)]
        public int HoursWorked { get; set; }
    }
}
