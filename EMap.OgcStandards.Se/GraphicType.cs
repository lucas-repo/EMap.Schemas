namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("Graphic", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class GraphicType {
        
        private object[] itemsField;
        
        private ParameterValueType opacityField;
        
        private ParameterValueType sizeField;
        
        private ParameterValueType rotationField;
        
        private AnchorPointType anchorPointField;
        
        private DisplacementType displacementField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalGraphic", typeof(ExternalGraphicType))]
        [System.Xml.Serialization.XmlElementAttribute("Mark", typeof(MarkType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
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
        public ParameterValueType Size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        
        /// <remarks/>
        public ParameterValueType Rotation {
            get {
                return this.rotationField;
            }
            set {
                this.rotationField = value;
            }
        }
        
        /// <remarks/>
        public AnchorPointType AnchorPoint {
            get {
                return this.anchorPointField;
            }
            set {
                this.anchorPointField = value;
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
    }
}
