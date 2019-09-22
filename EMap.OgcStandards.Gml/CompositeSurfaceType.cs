namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompositeSurface", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CompositeSurfaceType : AbstractSurfaceType {
        
        private SurfacePropertyType[] surfaceMemberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("surfaceMember")]
        public SurfacePropertyType[] surfaceMember {
            get {
                return this.surfaceMemberField;
            }
            set {
                this.surfaceMemberField = value;
            }
        }
    }
}
