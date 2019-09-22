namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Font", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class FontType {
        
        private SvgParameterType[] svgParameterField;
        
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
