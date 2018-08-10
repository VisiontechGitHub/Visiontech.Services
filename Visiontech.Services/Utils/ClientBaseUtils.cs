using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Visiontech.Services.Utils
{
    public class ClientBaseUtils
    {

        public static S InitClientBase<I, S>(IServiceProvider serviceProvider, EndpointAddress endpoint) where S : ClientBase<I> where I : class
        {
            var binding = new BasicHttpBinding
            {
                MaxReceivedMessageSize = 2147483647
            };
            binding.Security.Mode = BasicHttpSecurityMode.Transport;

            S soapClient = Activator.CreateInstance(typeof(S), binding, endpoint) as S;

            IEndpointBehavior endpointBehavior = new MessageInspectorsEndpointBehavior()
            {
                MessageInspectors = new Collection<IClientMessageInspector>() { serviceProvider.GetService(typeof(IAuthenticatingMessageInspector)) as IAuthenticatingMessageInspector, new LoggingMessageInspector() }
            };

            (soapClient.Endpoint.GetType().GetTypeInfo().GetDeclaredProperty("Behaviors").GetValue(soapClient.Endpoint) as KeyedByTypeCollection<IEndpointBehavior>).Add(endpointBehavior);

            return soapClient;
        }

    }
}
