using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MvcSampleBrowser
{
    [ServiceContract]
    public interface IOlapGaugeService
    {
        [OperationContract]
        Dictionary<string, object> InitializeGauge(string action, string customObject);
    }
}
