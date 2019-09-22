namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("CompoundCRS", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class CompoundCRSType : AbstractReferenceSystemType {
        
        private CoordinateReferenceSystemRefType[] includesCRSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("includesCRS")]
        public CoordinateReferenceSystemRefType[] includesCRS {
            get {
                return this.includesCRSField;
            }
            set {
                this.includesCRSField = value;
            }
        }
    }
}
