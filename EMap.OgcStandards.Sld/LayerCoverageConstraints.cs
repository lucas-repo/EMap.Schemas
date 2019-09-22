namespace EMap.OgcStandards.Sld {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/sld")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/sld", IsNullable=false)]
    public partial class LayerCoverageConstraints {
        
        private CoverageConstraint[] coverageConstraintField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoverageConstraint")]
        public CoverageConstraint[] CoverageConstraint {
            get {
                return this.coverageConstraintField;
            }
            set {
                this.coverageConstraintField = value;
            }
        }
    }
}
