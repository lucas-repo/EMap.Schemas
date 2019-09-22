using EMap.OgcStandards.Ogc;

namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class FeatureTypeConstraint {
        
        private System.Xml.XmlQualifiedName featureTypeNameField;
        
        private FilterType filterField;
        
        private Extent[] extentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/se")]
        public System.Xml.XmlQualifiedName FeatureTypeName {
            get {
                return this.featureTypeNameField;
            }
            set {
                this.featureTypeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.opengis.net/ogc")]
        public FilterType Filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extent")]
        public Extent[] Extent {
            get {
                return this.extentField;
            }
            set {
                this.extentField = value;
            }
        }
    }
}
