namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class ServiceIdentification : DescriptionType1 {
        
        private CodeType1 serviceTypeField;
        
        private string[] serviceTypeVersionField;
        
        private string feesField;
        
        private string[] accessConstraintsField;
        
        /// <remarks/>
        public CodeType1 ServiceType {
            get {
                return this.serviceTypeField;
            }
            set {
                this.serviceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceTypeVersion")]
        public string[] ServiceTypeVersion {
            get {
                return this.serviceTypeVersionField;
            }
            set {
                this.serviceTypeVersionField = value;
            }
        }
        
        /// <remarks/>
        public string Fees {
            get {
                return this.feesField;
            }
            set {
                this.feesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccessConstraints")]
        public string[] AccessConstraints {
            get {
                return this.accessConstraintsField;
            }
            set {
                this.accessConstraintsField = value;
            }
        }
    }
}
