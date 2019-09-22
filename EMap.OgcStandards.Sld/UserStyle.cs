using EMap.OgcStandards.Se;

namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class UserStyle {
        
        private string nameField;
        
        private DescriptionType descriptionField;
        
        private bool isDefaultField;
        
        private bool isDefaultFieldSpecified;
        
        private object[] itemsField;
        
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
        public bool IsDefault {
            get {
                return this.isDefaultField;
            }
            set {
                this.isDefaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDefaultSpecified {
            get {
                return this.isDefaultFieldSpecified;
            }
            set {
                this.isDefaultFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoverageStyle", typeof(CoverageStyleType), Namespace="http://www.opengis.net/se")]
        [System.Xml.Serialization.XmlElementAttribute("FeatureTypeStyle", typeof(FeatureTypeStyleType), Namespace="http://www.opengis.net/se")]
        [System.Xml.Serialization.XmlElementAttribute("OnlineResource", typeof(OnlineResourceType), Namespace="http://www.opengis.net/se")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
