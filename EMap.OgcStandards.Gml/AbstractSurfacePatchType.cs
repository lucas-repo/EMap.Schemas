namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractParametricCurveSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGriddedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectangleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolygonPatchType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractSurfacePatchType {
    }
}
