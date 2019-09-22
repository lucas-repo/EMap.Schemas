namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("Add", Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class BinaryOperatorType : ExpressionType {
        
        private ExpressionType[] expressionField;
        
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
    }
}
