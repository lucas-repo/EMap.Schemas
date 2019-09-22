namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Categorize", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class CategorizeType : FunctionType1 {
        
        private ParameterValueType lookupValueField;
        
        private ParameterValueType valueField;
        
        private ParameterValueType[] thresholdField;
        
        private ParameterValueType[] value1Field;
        
        private ThreshholdsBelongToType threshholdsBelongToField;
        
        private bool threshholdsBelongToFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ParameterValueType LookupValue {
            get {
                return this.lookupValueField;
            }
            set {
                this.lookupValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ParameterValueType Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Threshold", Order=2)]
        public ParameterValueType[] Threshold {
            get {
                return this.thresholdField;
            }
            set {
                this.thresholdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value", Order=3)]
        public ParameterValueType[] Value1 {
            get {
                return this.value1Field;
            }
            set {
                this.value1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ThreshholdsBelongToType threshholdsBelongTo {
            get {
                return this.threshholdsBelongToField;
            }
            set {
                this.threshholdsBelongToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool threshholdsBelongToSpecified {
            get {
                return this.threshholdsBelongToFieldSpecified;
            }
            set {
                this.threshholdsBelongToFieldSpecified = value;
            }
        }
    }
}
