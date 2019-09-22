namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("ImageOutline", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class ImageOutlineType {
        
        private SymbolizerType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineSymbolizer", typeof(LineSymbolizerType))]
        [System.Xml.Serialization.XmlElementAttribute("PolygonSymbolizer", typeof(PolygonSymbolizerType))]
        public SymbolizerType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
