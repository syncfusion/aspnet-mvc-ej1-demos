using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MvcSampleBrowser
{
    [ServiceContract]
    public interface IOlapChartService
    {
        [OperationContract]
        Dictionary<string, object> InitializeChart(string action,string customObject);

        [OperationContract]
        Dictionary<string, object> DrillChart(string action, string drilledSeries, string olapReport,string customObject);

        [OperationContract]
        void Export(System.IO.Stream stream);
    }
}
