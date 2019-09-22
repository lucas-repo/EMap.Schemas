namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("LegendGraphic", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class LegendGraphicType {
        
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
