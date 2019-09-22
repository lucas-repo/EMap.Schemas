namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiLineStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPolygonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiGeometryType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractGeometricAggregateType : AbstractGeometryType {
    }
}
