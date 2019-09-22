namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("RasterSymbolizer", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class RasterSymbolizerType : SymbolizerType {
        
        private GeometryType geometryField;
        
        private ParameterValueType opacityField;
        
        private ChannelSelectionType channelSelectionField;
        
        private OverlapBehavior overlapBehaviorField;
        
        private bool overlapBehaviorFieldSpecified;
        
        private ColorMapType colorMapField;
        
        private ContrastEnhancementType contrastEnhancementField;
        
        private ShadedReliefType shadedReliefField;
        
        private ImageOutlineType imageOutlineField;
        
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
        public ParameterValueType Opacity {
            get {
                return this.opacityField;
            }
            set {
                this.opacityField = value;
            }
        }
        
        /// <remarks/>
        public ChannelSelectionType ChannelSelection {
            get {
                return this.channelSelectionField;
            }
            set {
                this.channelSelectionField = value;
            }
        }
        
        /// <remarks/>
        public OverlapBehavior OverlapBehavior {
            get {
                return this.overlapBehaviorField;
            }
            set {
                this.overlapBehaviorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OverlapBehaviorSpecified {
            get {
                return this.overlapBehaviorFieldSpecified;
            }
            set {
                this.overlapBehaviorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ColorMapType ColorMap {
            get {
                return this.colorMapField;
            }
            set {
                this.colorMapField = value;
            }
        }
        
        /// <remarks/>
        public ContrastEnhancementType ContrastEnhancement {
            get {
                return this.contrastEnhancementField;
            }
            set {
                this.contrastEnhancementField = value;
            }
        }
        
        /// <remarks/>
        public ShadedReliefType ShadedRelief {
            get {
                return this.shadedReliefField;
            }
            set {
                this.shadedReliefField = value;
            }
        }
        
        /// <remarks/>
        public ImageOutlineType ImageOutline {
            get {
                return this.imageOutlineField;
            }
            set {
                this.imageOutlineField = value;
            }
        }
    }
}
