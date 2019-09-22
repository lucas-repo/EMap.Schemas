using EMap.OgcStandards.Gml;

namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class InlineFeature {
        
        private FeatureCollectionType[] featureCollectionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeatureCollection", Namespace="http://www.opengis.net/gml")]
        public FeatureCollectionType[] FeatureCollection {
            get {
                return this.featureCollectionField;
            }
            set {
                this.featureCollectionField = value;
            }
        }
    }
}
