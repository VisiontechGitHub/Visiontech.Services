using SoapClientService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Visiontech.Services.Utils
{
    public class ClientBaseUtils
    {

        public static I InitClientBase<I, S>(EndpointAddress endpoint, ICollection<IClientMessageInspector> inspectors = default(Collection<IClientMessageInspector>), ICollection<Action<HttpWebResponse>> handlers = default, ICollection<Action<FaultException>> faultHandlers = default, ICollection<Action<Exception>> genericHandlers = default, CookieContainer cookieContainer = default) where S : ClientBase<I>, I where I : class
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                MaxReceivedMessageSize = 2147483647,
                OpenTimeout = new TimeSpan(0, 10, 0),
                CloseTimeout = new TimeSpan(0, 10, 0),
                SendTimeout = new TimeSpan(0, 10, 0),
                ReceiveTimeout = new TimeSpan(0, 10, 0)
            };
            binding.Security.Mode = string.Equals(endpoint.Uri.Scheme, "https") ? BasicHttpSecurityMode.Transport : BasicHttpSecurityMode.None;
            binding.Security.Transport.ClientCredentialType = string.Equals(endpoint.Uri.Scheme, "https") ? HttpClientCredentialType.None : HttpClientCredentialType.Basic;
            binding.AllowCookies = cookieContainer is object;

            S soapClient = Activator.CreateInstance(typeof(S), binding, endpoint) as S;

            IEndpointBehavior endpointBehavior = new MessageInspectorsEndpointBehavior()
            {
                MessageInspectors = inspectors is object ? inspectors: new Collection<IClientMessageInspector>()
            };

            (soapClient.Endpoint.GetType().GetTypeInfo().GetDeclaredProperty("Behaviors").GetValue(soapClient.Endpoint) as KeyedByTypeCollection<IEndpointBehavior>).Add(endpointBehavior);

            if (soapClient.InnerChannel is object && soapClient.InnerChannel.GetProperty<IHttpCookieContainerManager>() is IHttpCookieContainerManager httpCookieContainerManager && cookieContainer is object)
            {
                httpCookieContainerManager.CookieContainer = cookieContainer;
            }

            return HttpWebResponseInterceptorProxy<I>.Create(soapClient, handlers is object ? handlers : new Collection<Action<HttpWebResponse>>(), faultHandlers is object ? faultHandlers : new Collection<Action<FaultException>>(), genericHandlers is object ? genericHandlers : new Collection<Action<Exception>>());
        }

    }
}
