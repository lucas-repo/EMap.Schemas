namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGriddedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class AbstractParametricCurveSurfaceType : AbstractSurfacePatchType {
    }
}
