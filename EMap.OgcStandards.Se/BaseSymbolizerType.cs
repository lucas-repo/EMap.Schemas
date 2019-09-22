namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("BaseSymbolizer", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class BaseSymbolizerType {
        
        private OnlineResourceType onlineResourceField;
        
        /// <remarks/>
        public OnlineResourceType OnlineResource {
            get {
                return this.onlineResourceField;
            }
            set {
                this.onlineResourceField = value;
            }
        }
    }
}
