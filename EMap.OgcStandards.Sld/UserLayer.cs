using EMap.OgcStandards.Se;

namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class UserLayer {
        
        private string nameField;
        
        private DescriptionType descriptionField;
        
        private object itemField;
        
        private object item1Field;
        
        private UserStyle[] userStyleField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("InlineFeature", typeof(InlineFeature))]
        [System.Xml.Serialization.XmlElementAttribute("RemoteOWS", typeof(RemoteOWS))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LayerCoverageConstraints", typeof(LayerCoverageConstraints))]
        [System.Xml.Serialization.XmlElementAttribute("LayerFeatureConstraints", typeof(LayerFeatureConstraints))]
        public object Item1 {
            get {
                return this.item1Field;
            }
            set {
                this.item1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserStyle")]
        public UserStyle[] UserStyle {
            get {
                return this.userStyleField;
            }
            set {
                this.userStyleField = value;
            }
        }
    }
}
