using System.Runtime.Serialization;
using Decisions.X12.Interchange.Segments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using DecisionsFramework.Design.Properties;

namespace X12Interchange277X364;

[DataContract, Writable]
public class Transaction364
{
    [DataMember, WritableValue, PropertyClassification("Transaction Set Header", 10)]
    public ST ST { get; set; }
    [DataMember, WritableValue, PropertyClassification("Beginning of Hierarchical Transaction", 20)]
    public BHT BHT { get; set; }

    [DataMember, WritableValue, PropertyClassification("Information Source Level Hierarchical Loop", 30)]
    public SourceLevelLoop3642000A[] SourceLevelLoop3642000A { get; set; } // 2000A
    [DataMember, WritableValue, PropertyClassification("Transaction Set Trailer", 40)]
    public SE SE { get; set; }
    
    internal List<SourceLevelLoop3642000A> SourceLevelLoop3642000AForDeserialize;
}