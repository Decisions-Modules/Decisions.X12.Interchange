using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange997;

public class TransactionSetResponseHeaderLoop2000
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Response Header", 10)]
    public AK2 AK2 { get; set; }
    
    // 2100 Loop
    [DataMember, WritableValue, PropertyClassification("Error Identification Loop", 20)]
    public DataSegmentLoop2100[] DataSegmentLoop2100 { get; set; }
    
    [DataMember, WritableValue, PropertyClassification("Transaction Set Response Trailer", 30)]
    public AK5 AK5 { get; set; }

    internal List<DataSegmentLoop2100> DataSegmentLoop2100ForDeserialize;
}