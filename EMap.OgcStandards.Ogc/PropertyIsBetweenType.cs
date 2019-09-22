namespace EMap.OgcStandards.Ogc {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/ogc")]
    [System.Xml.Serialization.XmlRootAttribute("PropertyIsBetween", Namespace="http://www.opengis.net/ogc", IsNullable=false)]
    public partial class PropertyIsBetweenType : ComparisonOpsType {
        
        private ExpressionType expressionField;
        
        private LowerBoundaryType lowerBoundaryField;
        
        private UpperBoundaryType upperBoundaryField;
        
        /// <remarks/>
        public ExpressionType expression {
            get {
                return this.expressionField;
            }
            set {
                this.expressionField = value;
            }
        }
        
        /// <remarks/>
        public LowerBoundaryType LowerBoundary {
            get {
                return this.lowerBoundaryField;
            }
            set {
                this.lowerBoundaryField = value;
            }
        }
        
        /// <remarks/>
        public UpperBoundaryType UpperBoundary {
            get {
                return this.upperBoundaryField;
            }
            set {
                this.upperBoundaryField = value;
            }
        }
    }
}
