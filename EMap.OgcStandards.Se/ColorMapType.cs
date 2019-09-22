namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("ColorMap", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class ColorMapType {
        
        private FunctionType1 itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Categorize", typeof(CategorizeType))]
        [System.Xml.Serialization.XmlElementAttribute("Interpolate", typeof(InterpolateType))]
        public FunctionType1 Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
