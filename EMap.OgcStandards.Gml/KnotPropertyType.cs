namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class KnotPropertyType {
        
        private KnotType knotField;
        
        /// <remarks/>
        public KnotType Knot {
            get {
                return this.knotField;
            }
            set {
                this.knotField = value;
            }
        }
    }
}
