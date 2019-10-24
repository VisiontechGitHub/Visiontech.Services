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

        public static S InitClientBase<I, S>(EndpointAddress endpoint, BasicHttpSecurityMode mode, HttpClientCredentialType type, ICollection<IClientMessageInspector> inspectors = default(Collection<IClientMessageInspector>)) where S : ClientBase<I> where I : class
        {
            var binding = new BasicHttpBinding
            {
                MaxReceivedMessageSize = 2147483647
            };
            binding.Security.Mode = mode;
            binding.Security.Transport.ClientCredentialType = type;

            S soapClient = Activator.CreateInstance(typeof(S), binding, endpoint) as S;

            IEndpointBehavior endpointBehavior = new MessageInspectorsEndpointBehavior()
            {
                MessageInspectors = inspectors is object ? inspectors: new Collection<IClientMessageInspector>()
            };

            (soapClient.Endpoint.GetType().GetTypeInfo().GetDeclaredProperty("Behaviors").GetValue(soapClient.Endpoint) as KeyedByTypeCollection<IEndpointBehavior>).Add(endpointBehavior);

            return soapClient;
        }

    }
}
