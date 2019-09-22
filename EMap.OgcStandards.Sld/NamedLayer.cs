using EMap.OgcStandards.Se;

namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class NamedLayer {
        
        private string nameField;
        
        private DescriptionType descriptionField;
        
        private FeatureTypeConstraint[] layerFeatureConstraintsField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("LayerFeatureConstraints", typeof(LayerFeatureConstraints))]
        public FeatureTypeConstraint[] LayerFeatureConstraints {
            get {
                return this.layerFeatureConstraintsField;
            }
            set {
                this.layerFeatureConstraintsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NamedStyle", typeof(NamedStyle))]
        [System.Xml.Serialization.XmlElementAttribute("UserStyle", typeof(UserStyle))]
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
