namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoCurve", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoCurveType : AbstractTopologyType {
        
        private DirectedEdgePropertyType[] directedEdgeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("directedEdge")]
        public DirectedEdgePropertyType[] directedEdge {
            get {
                return this.directedEdgeField;
            }
            set {
                this.directedEdgeField = value;
            }
        }
    }
}
