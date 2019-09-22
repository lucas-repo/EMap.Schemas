namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("DerivedUnit", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class DerivedUnitType : UnitDefinitionType {
        
        private DerivationUnitTermType[] derivationUnitTermField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("derivationUnitTerm")]
        public DerivationUnitTermType[] derivationUnitTerm {
            get {
                return this.derivationUnitTermField;
            }
            set {
                this.derivationUnitTermField = value;
            }
        }
    }
}
