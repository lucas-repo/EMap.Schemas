namespace EMap.OgcStandards.Gml {
    
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengis.net/gml")]
    public partial class RelatedTimeType : TimePrimitivePropertyType {
        
        private RelatedTimeTypeRelativePosition relativePositionField;
        
        private bool relativePositionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RelatedTimeTypeRelativePosition relativePosition {
            get {
                return this.relativePositionField;
            }
            set {
                this.relativePositionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool relativePositionSpecified {
            get {
                return this.relativePositionFieldSpecified;
            }
            set {
                this.relativePositionFieldSpecified = value;
            }
        }
    }
}
