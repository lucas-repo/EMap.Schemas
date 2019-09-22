namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute("TopoPoint", Namespace="http://www.opengis.net/gml", IsNullable=false)]
    public partial class TopoPointType : AbstractTopologyType {
        
        private DirectedNodePropertyType directedNodeField;
        
        /// <remarks/>
        public DirectedNodePropertyType directedNode {
            get {
                return this.directedNodeField;
            }
            set {
                this.directedNodeField = value;
            }
        }
    }
}
