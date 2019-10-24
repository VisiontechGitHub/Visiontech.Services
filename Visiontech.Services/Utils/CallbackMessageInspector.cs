using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Visiontech.Services.Utils
{
    public class CallbackMessageInspector : ICallbackMessageInspector
    {
        public ICollection<Action<Message>> RequestCallbacks { get; } = new Collection<Action<Message>>();

        public ICollection<Action<Message>> ResponseCallbacks { get; } = new Collection<Action<Message>>();

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            foreach (Action<Message> action in ResponseCallbacks) {
                action.Invoke(reply);
            }
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            foreach (Action<Message> action in RequestCallbacks)
            {
                action.Invoke(request);
            }

            return null;
        }

    }
}
