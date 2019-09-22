namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("FormatNumber", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class FormatNumberType : FunctionType1 {
        
        private ParameterValueType numericValueField;
        
        private string patternField;
        
        private string negativePatternField;
        
        private string decimalPointField;
        
        private string groupingSeparatorField;
        
        public FormatNumberType() {
            this.decimalPointField = ".";
            this.groupingSeparatorField = ",";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ParameterValueType NumericValue {
            get {
                return this.numericValueField;
            }
            set {
                this.numericValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Pattern {
            get {
                return this.patternField;
            }
            set {
                this.patternField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string NegativePattern {
            get {
                return this.negativePatternField;
            }
            set {
                this.negativePatternField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(".")]
        public string decimalPoint {
            get {
                return this.decimalPointField;
            }
            set {
                this.decimalPointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(",")]
        public string groupingSeparator {
            get {
                return this.groupingSeparatorField;
            }
            set {
                this.groupingSeparatorField = value;
            }
        }
    }
}
