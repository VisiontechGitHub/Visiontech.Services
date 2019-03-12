using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Visiontech.Services.Utils
{
    public class AuthenticatingMessageInspector : IAuthenticatingMessageInspector
    {

        public string Bearer
        {
            get; set;
        }

        public ICollection<string> Cookies
        {
            get; set;
        }

        public IDictionary<string, string> Headers
        {
            get; set;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            if (reply.Properties.ContainsKey(HttpResponseMessageProperty.Name))
            {

                WebHeaderCollection webHeaderCollection = (reply.Properties[HttpResponseMessageProperty.Name] as HttpResponseMessageProperty).Headers;

                if (!(webHeaderCollection[HttpResponseHeader.SetCookie] is null))
                {
                    if (Cookies is null)
                    {
                        Cookies = new Collection<string>();
                    }
                    foreach (string cookie in webHeaderCollection[HttpResponseHeader.SetCookie].Split(','))
                    {
                        Cookies.Add(cookie);
                    }
                }

            }

        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {

            if (!request.Properties.ContainsKey(HttpRequestMessageProperty.Name))
            {
                request.Properties.Add(HttpRequestMessageProperty.Name, new HttpRequestMessageProperty());
            }

            if (!string.IsNullOrWhiteSpace(Bearer))
            {
                (request.Properties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty).Headers.Add(HttpRequestHeader.Authorization, "Bearer " + Bearer);
            }

            if (Cookies != null)
            {
                (request.Properties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty).Headers[HttpRequestHeader.Cookie] = string.Join(";", Cookies);
            }

            if (Headers != null)
            {
                foreach (string header in Headers.Keys)
                {
                    (request.Properties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty).Headers.Add(header, Headers[header]);
                }
            }

            return null;
        }

    }
}
