namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute("DescribeLayerResponse", Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class DescribeLayerResponseType {
        
        private string versionField;
        
        private LayerDescriptionType[] layerDescriptionField;
        
        /// <remarks/>
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LayerDescription")]
        public LayerDescriptionType[] LayerDescription {
            get {
                return this.layerDescriptionField;
            }
            set {
                this.layerDescriptionField = value;
            }
        }
    }
}
