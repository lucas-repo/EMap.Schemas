namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class UserDefinedSymbolization {
        
        private bool supportSLDField;
        
        private bool userLayerField;
        
        private bool userStyleField;
        
        private bool remoteWFSField;
        
        private bool inlineFeatureField;
        
        private bool remoteWCSField;
        
        public UserDefinedSymbolization() {
            this.supportSLDField = false;
            this.userLayerField = false;
            this.userStyleField = false;
            this.remoteWFSField = false;
            this.inlineFeatureField = false;
            this.remoteWCSField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportSLD {
            get {
                return this.supportSLDField;
            }
            set {
                this.supportSLDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UserLayer {
            get {
                return this.userLayerField;
            }
            set {
                this.userLayerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UserStyle {
            get {
                return this.userStyleField;
            }
            set {
                this.userStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool RemoteWFS {
            get {
                return this.remoteWFSField;
            }
            set {
                this.remoteWFSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool InlineFeature {
            get {
                return this.inlineFeatureField;
            }
            set {
                this.inlineFeatureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool RemoteWCS {
            get {
                return this.remoteWCSField;
            }
            set {
                this.remoteWCSField = value;
            }
        }
    }
}
