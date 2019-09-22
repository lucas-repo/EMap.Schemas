using EMap.OgcStandards.Se;

namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class StyledLayerDescriptor {
        
        private string nameField;
        
        private DescriptionType descriptionField;
        
        private UseSLDLibrary[] useSLDLibraryField;
        
        private object[] itemsField;
        
        private VersionType versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/se")]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/se")]
        public DescriptionType Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UseSLDLibrary")]
        public UseSLDLibrary[] UseSLDLibrary {
            get {
                return this.useSLDLibraryField;
            }
            set {
                this.useSLDLibraryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NamedLayer", typeof(NamedLayer))]
        [System.Xml.Serialization.XmlElementAttribute("UserLayer", typeof(UserLayer))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VersionType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
}
