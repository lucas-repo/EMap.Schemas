using EMap.OgcStandards.Gml;

namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("BBOX", Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class BBOXType : SpatialOpsType {
        
        private PropertyNameType propertyNameField;
        
        private EnvelopeType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PropertyNameType PropertyName {
            get {
                return this.propertyNameField;
            }
            set {
                this.propertyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Envelope", typeof(EnvelopeType), Namespace="http://www.opengis.net/gml", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("EnvelopeWithTimePeriod", typeof(EnvelopeWithTimePeriodType), Namespace="http://www.opengis.net/gml", Order=1)]
        public EnvelopeType Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
