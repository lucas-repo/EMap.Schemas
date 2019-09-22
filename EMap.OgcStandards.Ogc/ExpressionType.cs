namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(MapItemType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(FunctionType1))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(RecodeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FunctionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LiteralType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyNameType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public abstract partial class ExpressionType {
    }
}
