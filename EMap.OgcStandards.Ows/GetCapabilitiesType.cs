namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("GetCapabilities", Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class GetCapabilitiesType {
        
        private string[] acceptVersionsField;
        
        private string[] sectionsField;
        
        private string[] acceptFormatsField;
        
        private string updateSequenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Version", IsNullable=false)]
        public string[] AcceptVersions {
            get {
                return this.acceptVersionsField;
            }
            set {
                this.acceptVersionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Section", IsNullable=false)]
        public string[] Sections {
            get {
                return this.sectionsField;
            }
            set {
                this.sectionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OutputFormat", IsNullable=false)]
        public string[] AcceptFormats {
            get {
                return this.acceptFormatsField;
            }
            set {
                this.acceptFormatsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string updateSequence {
            get {
                return this.updateSequenceField;
            }
            set {
                this.updateSequenceField = value;
            }
        }
    }
}
