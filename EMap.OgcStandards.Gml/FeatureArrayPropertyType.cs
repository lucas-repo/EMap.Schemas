namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("featureMembers", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class FeatureArrayPropertyType {
        
        private AbstractFeatureType[] _FeatureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_Feature")]
        public AbstractFeatureType[] _Feature {
            get {
                return this._FeatureField;
            }
            set {
                this._FeatureField = value;
            }
        }
    }
}
