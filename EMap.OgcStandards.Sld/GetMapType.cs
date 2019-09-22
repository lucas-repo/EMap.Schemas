using EMap.OgcStandards.Ows;

namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute("GetMap", Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class GetMapType {
        
        private StyledLayerDescriptor styledLayerDescriptorField;
        
        private string cRSField;
        
        private BoundingBoxType boundingBoxField;
        
        private OutputType outputField;
        
        private ExceptionsType exceptionsField;
        
        private bool exceptionsFieldSpecified;
        
        private System.DateTime timeField;
        
        private bool timeFieldSpecified;
        
        private ElevationType elevationField;
        
        private string versionField;
        
        public GetMapType() {
            this.versionField = "1.3.0";
        }
        
        /// <remarks/>
        public StyledLayerDescriptor StyledLayerDescriptor {
            get {
                return this.styledLayerDescriptorField;
            }
            set {
                this.styledLayerDescriptorField = value;
            }
        }
        
        /// <remarks/>
        public string CRS {
            get {
                return this.cRSField;
            }
            set {
                this.cRSField = value;
            }
        }
        
        /// <remarks/>
        public BoundingBoxType BoundingBox {
            get {
                return this.boundingBoxField;
            }
            set {
                this.boundingBoxField = value;
            }
        }
        
        /// <remarks/>
        public OutputType Output {
            get {
                return this.outputField;
            }
            set {
                this.outputField = value;
            }
        }
        
        /// <remarks/>
        public ExceptionsType Exceptions {
            get {
                return this.exceptionsField;
            }
            set {
                this.exceptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExceptionsSpecified {
            get {
                return this.exceptionsFieldSpecified;
            }
            set {
                this.exceptionsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeSpecified {
            get {
                return this.timeFieldSpecified;
            }
            set {
                this.timeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ElevationType Elevation {
            get {
                return this.elevationField;
            }
            set {
                this.elevationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
}
