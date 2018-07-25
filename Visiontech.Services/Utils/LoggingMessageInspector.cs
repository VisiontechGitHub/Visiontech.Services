using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Visiontech.Services.Utils
{
    public class LoggingMessageInspector : IClientMessageInspector
    {

        public bool Enabled { set; get; }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            if (ReferenceEquals(true, Enabled))
            {
                Debug.WriteLine("REPLY :");
                Debug.WriteLine(reply);
            }
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            if (ReferenceEquals(true, Enabled))
            {
                Debug.WriteLine("REQUEST :");
                Debug.WriteLine(request);
            }
            return null;
        }

    }
}
