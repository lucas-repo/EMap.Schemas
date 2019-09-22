namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimePrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractTimeGeometricPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePeriodType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractTimeObjectType : AbstractGMLType {
    }
}
