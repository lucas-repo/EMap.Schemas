namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("ChangeCase", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class ChangeCaseType : FunctionType1 {
        
        private ParameterValueType stringValueField;
        
        private directionType directionField;
        
        private bool directionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ParameterValueType StringValue {
            get {
                return this.stringValueField;
            }
            set {
                this.stringValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public directionType direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool directionSpecified {
            get {
                return this.directionFieldSpecified;
            }
            set {
                this.directionFieldSpecified = value;
            }
        }
    }
}
