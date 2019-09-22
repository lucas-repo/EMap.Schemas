namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class GridLimitsType {
        
        private GridEnvelopeType gridEnvelopeField;
        
        /// <remarks/>
        public GridEnvelopeType GridEnvelope {
            get {
                return this.gridEnvelopeField;
            }
            set {
                this.gridEnvelopeField = value;
            }
        }
    }
}
