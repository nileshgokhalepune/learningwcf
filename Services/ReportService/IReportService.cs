using System.ServiceModel;

namespace ReportService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReportService" in both code and config file together.
    
    [ServiceContract(CallbackContract = typeof(IReportServiceCallback))]
    public interface IReportService
    {
        ///[OperationContract(IsOneWay =true)]4
        [OperationContract]
        void ProcessReport();
    }

    public interface IReportServiceCallback
    {
        //[OperationContract(IsOneWay =true)]
        [OperationContract]
        void Progress(int precentCompleted);
    }
}
