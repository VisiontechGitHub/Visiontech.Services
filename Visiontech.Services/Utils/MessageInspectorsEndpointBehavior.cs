using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Visiontech.Services.Utils
{
    public class MessageInspectorsEndpointBehavior : IEndpointBehavior
    {

        public ICollection<IClientMessageInspector> MessageInspectors { get; set; }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            if (!(MessageInspectors is null))
            {
                PropertyInfo propertyInfo = clientRuntime.GetType().GetTypeInfo().GetDeclaredProperty("MessageInspectors");

                foreach (IClientMessageInspector MessageInspector in MessageInspectors)
                {
                    (propertyInfo.GetValue(clientRuntime) as ICollection<IClientMessageInspector>).Add(MessageInspector);
                }
            }
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
        }

        public void Validate(ServiceEndpoint endpoint)
        {
        }

    }
}
