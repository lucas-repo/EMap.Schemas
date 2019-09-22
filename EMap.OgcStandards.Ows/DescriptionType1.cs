namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DescriptionType", Namespace="http://www.opengis.net/ows")]
    public partial class DescriptionType1 {
        
        private string titleField;
        
        private string abstractField;
        
        private KeywordsType[] keywordsField;
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Abstract {
            get {
                return this.abstractField;
            }
            set {
                this.abstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keywords")]
        public KeywordsType[] Keywords {
            get {
                return this.keywordsField;
            }
            set {
                this.keywordsField = value;
            }
        }
    }
}
