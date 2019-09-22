namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Stroke", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class StrokeType {
        
        private object itemField;
        
        private SvgParameterType[] svgParameterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GraphicFill", typeof(GraphicFillType))]
        [System.Xml.Serialization.XmlElementAttribute("GraphicStroke", typeof(GraphicStrokeType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SvgParameter")]
        public SvgParameterType[] SvgParameter {
            get {
                return this.svgParameterField;
            }
            set {
                this.svgParameterField = value;
            }
        }
    }
}
