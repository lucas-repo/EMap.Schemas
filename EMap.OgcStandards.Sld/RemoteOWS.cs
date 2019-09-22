using EMap.OgcStandards.Se;

namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class RemoteOWS {
        
        private Service serviceField;
        
        private OnlineResourceType onlineResourceField;
        
        /// <remarks/>
        public Service Service {
            get {
                return this.serviceField;
            }
            set {
                this.serviceField = value;
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
    }
}
