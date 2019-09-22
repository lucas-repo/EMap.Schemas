namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("ProjectedCRS", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class ProjectedCRSType : AbstractGeneralDerivedCRSType {
        
        private CartesianCSRefType usesCartesianCSField;
        
        /// <remarks/>
        public CartesianCSRefType usesCartesianCS {
            get {
                return this.usesCartesianCSField;
            }
            set {
                this.usesCartesianCSField = value;
            }
        }
    }
}
