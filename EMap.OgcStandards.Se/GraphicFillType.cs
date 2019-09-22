namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("GraphicFill", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class GraphicFillType {
        
        private GraphicType graphicField;
        
        /// <remarks/>
        public GraphicType Graphic {
            get {
                return this.graphicField;
            }
            set {
                this.graphicField = value;
            }
        }
    }
}
