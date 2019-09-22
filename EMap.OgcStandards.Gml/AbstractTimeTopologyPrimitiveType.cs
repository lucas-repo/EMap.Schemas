namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeEdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeNodeType))]
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public abstract partial class AbstractTimeTopologyPrimitiveType : AbstractTimePrimitiveType {
        
        private ReferenceType complexField;
        
        /// <remarks/>
        public ReferenceType complex {
            get {
                return this.complexField;
            }
            set {
                this.complexField = value;
            }
        }
    }
}
