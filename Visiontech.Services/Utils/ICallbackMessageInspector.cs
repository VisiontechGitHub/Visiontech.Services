using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Visiontech.Services.Utils
{
    public interface ICallbackMessageInspector : IClientMessageInspector
    {

        ICollection<Action<Message>> RequestCallbacks
        {
            get;
        }

        ICollection<Action<Message>> ResponseCallbacks
        {
            get;
        }

    }
}
