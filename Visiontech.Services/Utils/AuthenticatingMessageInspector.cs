using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Visiontech.Services.Utils
{
    public class AuthenticatingMessageInspector : IAuthenticatingMessageInspector
    {

        public string Bearer
        {
            get; set;
        }

        public CookieCollection Cookies
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
                        Cookies = new CookieCollection();
                    }
                    foreach (string str in webHeaderCollection[HttpResponseHeader.SetCookie].ToString().Split(";".ToCharArray()))
                    {
                        Cookies.Add(new Cookie(str.Split("=".ToCharArray())[0].Trim(), str.Split("=".ToCharArray())[1].Trim()));
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
                IList<string> cookies = new List<string>();
                foreach (Cookie cookie in Cookies)
                {
                    cookies.Add(string.Join("=", new[] { cookie.Name, cookie.Value }));
                }
                (request.Properties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty).Headers.Add(HttpRequestHeader.Cookie, string.Join("; ", cookies));
            }

            return null;
        }

    }
}
