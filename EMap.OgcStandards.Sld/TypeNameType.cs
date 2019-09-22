namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sld")]
    public partial class TypeNameType {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoverageName", typeof(string), Namespace="http://www.opengis.net/se")]
        [System.Xml.Serialization.XmlElementAttribute("FeatureTypeName", typeof(System.Xml.XmlQualifiedName), Namespace="http://www.opengis.net/se")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
