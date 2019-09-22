namespace EMap.OgcStandards.Se {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/se")]
    [System.Xml.Serialization.XmlRootAttribute("PointPlacement", Namespace="http://www.opengis.net/se", IsNullable=false)]
    public partial class PointPlacementType {
        
        private AnchorPointType anchorPointField;
        
        private DisplacementType displacementField;
        
        private ParameterValueType rotationField;
        
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
        
        /// <remarks/>
        public ParameterValueType Rotation {
            get {
                return this.rotationField;
            }
            set {
                this.rotationField = value;
            }
        }
    }
}
