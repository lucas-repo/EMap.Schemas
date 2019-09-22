namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("InlineContent", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class InlineContentType {
        
        private System.Xml.XmlNode[] anyField;
        
        private InlineContentTypeEncoding encodingField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InlineContentTypeEncoding encoding {
            get {
                return this.encodingField;
            }
            set {
                this.encodingField = value;
            }
        }
    }
}
