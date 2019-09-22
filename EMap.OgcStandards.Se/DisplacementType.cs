namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Displacement", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class DisplacementType {
        
        private ParameterValueType displacementXField;
        
        private ParameterValueType displacementYField;
        
        /// <remarks/>
        public ParameterValueType DisplacementX {
            get {
                return this.displacementXField;
            }
            set {
                this.displacementXField = value;
            }
        }
        
        /// <remarks/>
        public ParameterValueType DisplacementY {
            get {
                return this.displacementYField;
            }
            set {
                this.displacementYField = value;
            }
        }
    }
}
