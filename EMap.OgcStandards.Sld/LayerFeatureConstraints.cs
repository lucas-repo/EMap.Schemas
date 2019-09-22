namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class LayerFeatureConstraints {
        
        private FeatureTypeConstraint[] featureTypeConstraintField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeatureTypeConstraint")]
        public FeatureTypeConstraint[] FeatureTypeConstraint {
            get {
                return this.featureTypeConstraintField;
            }
            set {
                this.featureTypeConstraintField = value;
            }
        }
    }
}
