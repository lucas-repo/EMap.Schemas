namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class OperationsMetadata {
        
        private Operation[] operationField;
        
        private DomainType[] parameterField;
        
        private DomainType[] constraintField;
        
        private object extendedCapabilitiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Operation")]
        public Operation[] Operation {
            get {
                return this.operationField;
            }
            set {
                this.operationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public DomainType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constraint")]
        public DomainType[] Constraint {
            get {
                return this.constraintField;
            }
            set {
                this.constraintField = value;
            }
        }
        
        /// <remarks/>
        public object ExtendedCapabilities {
            get {
                return this.extendedCapabilitiesField;
            }
            set {
                this.extendedCapabilitiesField = value;
            }
        }
    }
}
