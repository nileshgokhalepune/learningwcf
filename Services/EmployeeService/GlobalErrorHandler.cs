using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace EmployeeService
{
    public class GlobalErrorHandler : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            if (error is FaultException)
                return;

            FaultException faultException = new FaultException("A general service error occured");
            MessageFault messageFault = faultException.CreateMessageFault();
            fault = Message.CreateMessage(version, messageFault, null);
            
        }
    }

    public class GlobalErrorHandlerBehaviourAttribute : Attribute, IServiceBehavior
    {
        private readonly Type errorHandlerType;
        public GlobalErrorHandlerBehaviourAttribute(Type errorHandlerType)
        {
            this.errorHandlerType = errorHandlerType;
        }

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
            
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            IErrorHandler handler = (IErrorHandler)Activator.CreateInstance(this.errorHandlerType);
            foreach (ChannelDispatcherBase channelDispatcherBase in serviceHostBase.ChannelDispatchers)
            {
                ChannelDispatcher channelDispatcher = channelDispatcherBase as ChannelDispatcher;
                if (channelDispatcher != null)
                    channelDispatcher.ErrorHandlers.Add(handler);
            }
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            
        }
    }

}
