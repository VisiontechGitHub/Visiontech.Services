using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Visiontech.Services.Utils
{
    public interface IAuthenticatingMessageInspector : IClientMessageInspector
    {

        HttpRequestMessageProperty HttpRequestMessageProperty
        {
            get; set;
        }

    }
}
