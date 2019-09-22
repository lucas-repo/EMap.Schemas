namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sld")]
    public partial class OutputType {
        
        private OutputTypeSize sizeField;
        
        private string formatField;
        
        private bool transparentField;
        
        private bool transparentFieldSpecified;
        
        private string bGcolorField;
        
        /// <remarks/>
        public OutputTypeSize Size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/wms")]
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        public bool Transparent {
            get {
                return this.transparentField;
            }
            set {
                this.transparentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransparentSpecified {
            get {
                return this.transparentFieldSpecified;
            }
            set {
                this.transparentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string BGcolor {
            get {
                return this.bGcolorField;
            }
            set {
                this.bGcolorField = value;
            }
        }
    }
}
