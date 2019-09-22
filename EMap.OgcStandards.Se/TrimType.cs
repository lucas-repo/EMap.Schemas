namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Trim", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class TrimType : FunctionType1 {
        
        private ParameterValueType stringValueField;
        
        private stripOffPositionType stripOffPositionField;
        
        private bool stripOffPositionFieldSpecified;
        
        private string stripOffCharField;
        
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
        public stripOffPositionType stripOffPosition {
            get {
                return this.stripOffPositionField;
            }
            set {
                this.stripOffPositionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stripOffPositionSpecified {
            get {
                return this.stripOffPositionFieldSpecified;
            }
            set {
                this.stripOffPositionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stripOffChar {
            get {
                return this.stripOffCharField;
            }
            set {
                this.stripOffCharField = value;
            }
        }
    }
}
