namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public partial class SpatialOperatorType {
        
        private System.Xml.XmlQualifiedName[] geometryOperandsField;
        
        private SpatialOperatorNameType nameField;
        
        private bool nameFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GeometryOperand", IsNullable=false)]
        public System.Xml.XmlQualifiedName[] GeometryOperands {
            get {
                return this.geometryOperandsField;
            }
            set {
                this.geometryOperandsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SpatialOperatorNameType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nameSpecified {
            get {
                return this.nameFieldSpecified;
            }
            set {
                this.nameFieldSpecified = value;
            }
        }
    }
}
