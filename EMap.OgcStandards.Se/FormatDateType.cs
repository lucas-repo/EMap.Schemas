namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("FormatDate", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class FormatDateType : FunctionType1 {
        
        private ParameterValueType dateValueField;
        
        private string patternField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ParameterValueType DateValue {
            get {
                return this.dateValueField;
            }
            set {
                this.dateValueField = value;
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
    }
}
