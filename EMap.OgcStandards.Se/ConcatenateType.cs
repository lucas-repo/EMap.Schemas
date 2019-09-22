namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Concatenate", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class ConcatenateType : FunctionType1 {
        
        private ParameterValueType[] stringValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StringValue", Order=0)]
        public ParameterValueType[] StringValue {
            get {
                return this.stringValueField;
            }
            set {
                this.stringValueField = value;
            }
        }
    }
}
