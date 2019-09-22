namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public partial class ComparisonOperatorsType {
        
        private ComparisonOperatorType[] comparisonOperatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComparisonOperator")]
        public ComparisonOperatorType[] ComparisonOperator {
            get {
                return this.comparisonOperatorField;
            }
            set {
                this.comparisonOperatorField = value;
            }
        }
    }
}
