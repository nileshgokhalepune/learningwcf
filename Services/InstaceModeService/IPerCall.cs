using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InstaceModeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPerCall" in both code and config file together.
    [ServiceContract]
    public interface IPerCall
    {
        [OperationContract]
        int PerCallIntance();
    }

    [ServiceContract]
    public interface IPerSession
    {
        [OperationContract]
        int PerSessionInstance();
    }

    [ServiceContract]
    public interface ISingleCall
    {
        [OperationContract]
        int SingleCallInstance(); 
    }
}
