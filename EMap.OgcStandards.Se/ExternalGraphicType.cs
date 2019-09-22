namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("ExternalGraphic", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class ExternalGraphicType {
        
        private object itemField;
        
        private string formatField;
        
        private ColorReplacementType[] colorReplacementField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InlineContent", typeof(InlineContentType))]
        [System.Xml.Serialization.XmlElementAttribute("OnlineResource", typeof(OnlineResourceType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ColorReplacement")]
        public ColorReplacementType[] ColorReplacement {
            get {
                return this.colorReplacementField;
            }
            set {
                this.colorReplacementField = value;
            }
        }
    }
}
