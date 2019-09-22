namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("LabelStyle", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class LabelStyleType : BaseStyleDescriptorType {
        
        private string styleField;
        
        private LabelType labelField;
        
        /// <remarks/>
        public string style {
            get {
                return this.styleField;
            }
            set {
                this.styleField = value;
            }
        }
        
        /// <remarks/>
        public LabelType label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
    }
}
