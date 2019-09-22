namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Description", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class DescriptionType {
        
        private string titleField;
        
        private string abstractField;
        
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
    }
}
