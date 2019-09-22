using EMap.OgcStandards.Gml;

namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("DWithin", Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class DistanceBufferType : SpatialOpsType {
        
        private PropertyNameType propertyNameField;
        
        private AbstractGeometryType _GeometryField;
        
        private DistanceType distanceField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/gml", Order=1)]
        public AbstractGeometryType _Geometry {
            get {
                return this._GeometryField;
            }
            set {
                this._GeometryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public DistanceType Distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
            }
        }
    }
}
