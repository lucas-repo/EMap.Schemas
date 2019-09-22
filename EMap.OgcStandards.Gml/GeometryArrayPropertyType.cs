namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("geometryMembers", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class GeometryArrayPropertyType {
        
        private AbstractGeometryType[] _GeometryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Geometry")]
        public AbstractGeometryType[] _Geometry {
            get {
                return this._GeometryField;
            }
            set {
                this._GeometryField = value;
            }
        }
    }
}
