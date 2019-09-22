namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("PolygonSymbolizer", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class PolygonSymbolizerType : SymbolizerType {
        
        private GeometryType geometryField;
        
        private FillType fillField;
        
        private StrokeType strokeField;
        
        private DisplacementType displacementField;
        
        private ParameterValueType perpendicularOffsetField;
        
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
        public FillType Fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
        
        /// <remarks/>
        public StrokeType Stroke {
            get {
                return this.strokeField;
            }
            set {
                this.strokeField = value;
            }
        }
        
        /// <remarks/>
        public DisplacementType Displacement {
            get {
                return this.displacementField;
            }
            set {
                this.displacementField = value;
            }
        }
        
        /// <remarks/>
        public ParameterValueType PerpendicularOffset {
            get {
                return this.perpendicularOffsetField;
            }
            set {
                this.perpendicularOffsetField = value;
            }
        }
    }
}
