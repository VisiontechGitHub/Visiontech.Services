using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Visiontech.Services.Utils
{
    public class AuthenticatingMessageInspector : IAuthenticatingMessageInspector
    {

        public HttpRequestMessageProperty HttpRequestMessageProperty
        {
            get; set;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {

            if (HttpRequestMessageProperty is object)
            {
                if (request.Properties.ContainsKey(HttpRequestMessageProperty.Name))
                {
                    request.Properties.Remove(HttpRequestMessageProperty.Name);
                }
                request.Properties.Add(HttpRequestMessageProperty.Name, HttpRequestMessageProperty);
            }

            return null;
        }

    }
}
