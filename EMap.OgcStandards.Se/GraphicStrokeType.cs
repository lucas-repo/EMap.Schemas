namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("GraphicStroke", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class GraphicStrokeType {
        
        private GraphicType graphicField;
        
        private ParameterValueType initialGapField;
        
        private ParameterValueType gapField;
        
        /// <remarks/>
        public GraphicType Graphic {
            get {
                return this.graphicField;
            }
            set {
                this.graphicField = value;
            }
        }
        
        /// <remarks/>
        public ParameterValueType InitialGap {
            get {
                return this.initialGapField;
            }
            set {
                this.initialGapField = value;
            }
        }
        
        /// <remarks/>
        public ParameterValueType Gap {
            get {
                return this.gapField;
            }
            set {
                this.gapField = value;
            }
        }
    }
}
