namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("Exception", Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class ExceptionType {
        
        private string[] exceptionTextField;
        
        private string exceptionCodeField;
        
        private string locatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExceptionText")]
        public string[] ExceptionText {
            get {
                return this.exceptionTextField;
            }
            set {
                this.exceptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exceptionCode {
            get {
                return this.exceptionCodeField;
            }
            set {
                this.exceptionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string locator {
            get {
                return this.locatorField;
            }
            set {
                this.locatorField = value;
            }
        }
    }
}
