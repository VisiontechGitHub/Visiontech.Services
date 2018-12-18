using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Dispatcher;

namespace Visiontech.Services.Utils
{
    public interface IAuthenticatingMessageInspector : IClientMessageInspector
    {

        string Bearer
        {
            get; set;
        }

        ICollection<string> Cookies
        {
            get; set;
        }

    }
}
