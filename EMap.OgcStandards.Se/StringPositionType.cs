namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("StringPosition", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class StringPositionType : FunctionType1 {
        
        private ParameterValueType lookupStringField;
        
        private ParameterValueType stringValueField;
        
        private searchDirectionType searchDirectionField;
        
        private bool searchDirectionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ParameterValueType LookupString {
            get {
                return this.lookupStringField;
            }
            set {
                this.lookupStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        public searchDirectionType searchDirection {
            get {
                return this.searchDirectionField;
            }
            set {
                this.searchDirectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool searchDirectionSpecified {
            get {
                return this.searchDirectionFieldSpecified;
            }
            set {
                this.searchDirectionFieldSpecified = value;
            }
        }
    }
}
