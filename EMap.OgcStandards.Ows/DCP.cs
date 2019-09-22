namespace EMap.OgcStandards.Ows {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/ows")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/ows", IsNullable=false)]
    public partial class DCP {
        
        private HTTP1 itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HTTP")]
        public HTTP1 Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
