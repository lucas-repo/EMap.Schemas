using EMap.OgcStandards.Gml;

namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Equals", Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class BinarySpatialOpType : SpatialOpsType {
        
        private PropertyNameType propertyNameField;
        
        private object itemField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("_Geometry", typeof(AbstractGeometryType), Namespace="http://www.opengis.net/gml", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("PropertyName", typeof(PropertyNameType), Order=1)]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
