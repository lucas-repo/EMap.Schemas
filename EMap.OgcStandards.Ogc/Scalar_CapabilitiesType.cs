namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public partial class Scalar_CapabilitiesType {
        
        private LogicalOperators logicalOperatorsField;
        
        private ComparisonOperatorsType comparisonOperatorsField;
        
        private object[] arithmeticOperatorsField;
        
        /// <remarks/>
        public LogicalOperators LogicalOperators {
            get {
                return this.logicalOperatorsField;
            }
            set {
                this.logicalOperatorsField = value;
            }
        }
        
        /// <remarks/>
        public ComparisonOperatorsType ComparisonOperators {
            get {
                return this.comparisonOperatorsField;
            }
            set {
                this.comparisonOperatorsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Functions", typeof(FunctionsType), IsNullable=false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SimpleArithmetic", typeof(SimpleArithmetic), IsNullable=false)]
        public object[] ArithmeticOperators {
            get {
                return this.arithmeticOperatorsField;
            }
            set {
                this.arithmeticOperatorsField = value;
            }
        }
    }
}
