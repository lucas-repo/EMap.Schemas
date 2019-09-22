using EMap.OgcStandards.Se;

namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/sld")]
    public partial class LayerDescriptionType {
        
        private owsTypeType owsTypeField;
        
        private OnlineResourceType onlineResourceField;
        
        private TypeNameType[] typeNameField;
        
        /// <remarks/>
        public owsTypeType owsType {
            get {
                return this.owsTypeField;
            }
            set {
                this.owsTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/se")]
        public OnlineResourceType OnlineResource {
            get {
                return this.onlineResourceField;
            }
            set {
                this.onlineResourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TypeName")]
        public TypeNameType[] TypeName {
            get {
                return this.typeNameField;
            }
            set {
                this.typeNameField = value;
            }
        }
    }
}
