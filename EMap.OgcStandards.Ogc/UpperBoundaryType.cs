namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    public partial class UpperBoundaryType {
        
        private ExpressionType expressionField;
        
        /// <remarks/>
        public ExpressionType expression {
            get {
                return this.expressionField;
            }
            set {
                this.expressionField = value;
            }
        }
    }
}
