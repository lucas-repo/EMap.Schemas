namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DerivedCRS", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DerivedCRSType : AbstractGeneralDerivedCRSType {
        
        private DerivedCRSTypeType derivedCRSTypeField;
        
        private CoordinateSystemRefType usesCSField;
        
        /// <remarks/>
        public DerivedCRSTypeType derivedCRSType {
            get {
                return this.derivedCRSTypeField;
            }
            set {
                this.derivedCRSTypeField = value;
            }
        }
        
        /// <remarks/>
        public CoordinateSystemRefType usesCS {
            get {
                return this.usesCSField;
            }
            set {
                this.usesCSField = value;
            }
        }
    }
}
