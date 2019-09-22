namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Fill", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class FillType {
        
        private GraphicFillType graphicFillField;
        
        private SvgParameterType[] svgParameterField;
        
        /// <remarks/>
        public GraphicFillType GraphicFill {
            get {
                return this.graphicFillField;
            }
            set {
                this.graphicFillField = value;
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
