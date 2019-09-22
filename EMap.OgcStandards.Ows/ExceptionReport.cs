namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class ExceptionReport {
        
        private ExceptionType[] exceptionField;
        
        private string versionField;
        
        private string languageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Exception")]
        public ExceptionType[] Exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
    }
}
