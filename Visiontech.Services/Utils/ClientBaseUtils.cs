﻿using SoapClientService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Visiontech.Services.Utils
{
    public class ClientBaseUtils
    {

        public static I InitClientBase<I, S>(EndpointAddress endpoint, BasicHttpSecurityMode mode, HttpClientCredentialType type, ICollection<IClientMessageInspector> inspectors = default(Collection<IClientMessageInspector>), ICollection<Action<HttpWebResponse>> handlers = default(Collection<Action<HttpWebResponse>>)) where S : ClientBase<I>, I where I : class
        {
            BasicHttpBinding binding = new BasicHttpBinding
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

            return HttpWebResponseInterceptorProxy<I>.Create(soapClient, handlers is object ? handlers : new Collection<Action<HttpWebResponse>>());
        }

    }
}
