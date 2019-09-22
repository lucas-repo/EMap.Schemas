namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute("Keywords", Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class KeywordsType {
        
        private string[] keywordField;
        
        private CodeType1 typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword")]
        public string[] Keyword {
            get {
                return this.keywordField;
            }
            set {
                this.keywordField = value;
            }
        }
        
        /// <remarks/>
        public CodeType1 Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
}
