using System.Runtime.Serialization;
using System.Xml.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277;

[DataContract, Writable]
public class Transaction364
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }
    [DataMember, WritableValue, PropertyClassification("Beginning of Hierarchical Transaction", 20)]
    public BHT BHT { get; set; }

    [DataMember, WritableValue, PropertyClassification("Information Source Level Hierarchical Loop", 40)]
    public SourceLevelLoop364[] SourceLevelLoop { get; set; } // 2000A
    [DataMember, WritableValue, PropertyClassification("Transaction Set Trailer", 50)]
    public SE SE { get; set; }
    
    internal List<SourceLevelLoop364> SourceLevelLoopForDeserialize;
}