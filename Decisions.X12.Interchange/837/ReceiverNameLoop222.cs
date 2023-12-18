using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace X12Interchange837
{
    public class ReceiverNameLoop222
    {
        [DataMember, WritableValue, PropertyClassification("Name", 10)]
        public NM1 NM1 { get; set; }

    }
}
