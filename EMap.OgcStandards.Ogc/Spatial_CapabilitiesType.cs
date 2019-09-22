namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public partial class Spatial_CapabilitiesType {
        
        private System.Xml.XmlQualifiedName[] geometryOperandsField;
        
        private SpatialOperatorType[] spatialOperatorsField;
        
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
        [System.Xml.Serialization.XmlArrayItemAttribute("SpatialOperator", IsNullable=false)]
        public SpatialOperatorType[] SpatialOperators {
            get {
                return this.spatialOperatorsField;
            }
            set {
                this.spatialOperatorsField = value;
            }
        }
    }
}
