namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsEqualTo", Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class BinaryComparisonOpType : ComparisonOpsType {
        
        private ExpressionType[] expressionField;
        
        private bool matchCaseField;
        
        public BinaryComparisonOpType() {
            this.matchCaseField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expression")]
        public ExpressionType[] expression {
            get {
                return this.expressionField;
            }
            set {
                this.expressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool matchCase {
            get {
                return this.matchCaseField;
            }
            set {
                this.matchCaseField = value;
            }
        }
    }
}
