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

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            Debug.WriteLine("REPLY :");
            Debug.WriteLine(reply);
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            Debug.WriteLine("REQUEST :");
            Debug.WriteLine(request);
            return null;
        }

    }
}
