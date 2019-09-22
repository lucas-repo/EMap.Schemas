namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("TextSymbolizer", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class TextSymbolizerType : SymbolizerType {
        
        private GeometryType geometryField;
        
        private ParameterValueType labelField;
        
        private SvgParameterType[] fontField;
        
        private LabelPlacementType labelPlacementField;
        
        private HaloType haloField;
        
        private FillType fillField;
        
        /// <remarks/>
        public GeometryType Geometry {
            get {
                return this.geometryField;
            }
            set {
                this.geometryField = value;
            }
        }
        
        /// <remarks/>
        public ParameterValueType Label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SvgParameter", IsNullable=false)]
        public SvgParameterType[] Font {
            get {
                return this.fontField;
            }
            set {
                this.fontField = value;
            }
        }
        
        /// <remarks/>
        public LabelPlacementType LabelPlacement {
            get {
                return this.labelPlacementField;
            }
            set {
                this.labelPlacementField = value;
            }
        }
        
        /// <remarks/>
        public HaloType Halo {
            get {
                return this.haloField;
            }
            set {
                this.haloField = value;
            }
        }
        
        /// <remarks/>
        public FillType Fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
    }
}
