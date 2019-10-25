using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;

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
        } = new Collection<string>();

        public ICollection<string> CookieFilters
        {
            get; set;
        } = new List<string>();

        public IDictionary<string, string> Headers
        {
            get; set;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            if (reply.Properties.ContainsKey(HttpResponseMessageProperty.Name) && reply.Properties[HttpResponseMessageProperty.Name] is HttpResponseMessageProperty httpResponseMessageProperty)
            {

                WebHeaderCollection webHeaderCollection = httpResponseMessageProperty.Headers;

                if (webHeaderCollection[HttpResponseHeader.SetCookie] is object && Cookies is object)
                {
                    foreach (string cookie in webHeaderCollection[HttpResponseHeader.SetCookie].Split(',').Where(cookie => CookieFilters is null || !CookieFilters.Any(filter => Regex.IsMatch(cookie, filter))))
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

            if (request.Properties[HttpRequestMessageProperty.Name] is HttpRequestMessageProperty httpRequestMessageProperty)
            {
                if (!string.IsNullOrWhiteSpace(Bearer))
                {
                    httpRequestMessageProperty.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + Bearer);
                }
                if (Cookies != null)
                {
                    httpRequestMessageProperty.Headers[HttpRequestHeader.Cookie] = string.Join(";", Cookies.Where(cookie => CookieFilters is null || !CookieFilters.Any(filter => Regex.IsMatch(cookie, filter))));
                }
                if (Headers != null)
                {
                    foreach (string header in Headers.Keys)
                    {
                        httpRequestMessageProperty.Headers.Add(header, Headers[header]);
                    }
                }
            }

            return null;
        }

    }
}
